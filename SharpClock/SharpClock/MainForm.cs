using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace SharpClock
{
	public partial class CLOCK : Form
	{
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        
		public CLOCK()
		{
			InitializeComponent();
			  this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5)); //15,15
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			TIMER.Start();
			lblDate.Text = DateTime.Now.ToShortDateString();
			lblTime.Text = DateTime.Now.ToLongTimeString();
		}
		
			protected override void WndProc(ref Message m)
			{
    			switch (m.Msg)
    			{
        			case 0x84:
            		base.WndProc(ref m);
            		if((int)m.Result == 0x1)
                		m.Result = (IntPtr)0x2;
            		return;
    			}

    			base.WndProc(ref m);
			}
			
			
			
			private const int SnapDist = 120; 
			
			private bool DoSnap(int pos, int edge) 
			{ int delta = pos - edge; return delta > 0 && delta <= SnapDist; } 
			
			protected override void OnResizeEnd(EventArgs e) 
			{ 
				base.OnResizeEnd(e); 
				
				Screen scn = Screen.FromPoint(this.Location); 
				if (DoSnap(this.Left, scn.WorkingArea.Left)) 
					this.Left= scn.WorkingArea.Left; 
				if (DoSnap(this.Top, scn.WorkingArea.Top)) 
					this.Top = scn.WorkingArea.Top; 
				if (DoSnap(scn.WorkingArea.Right, this.Right)) 
					this.Left = scn.WorkingArea.Right - this.Width; 
				if (DoSnap(scn.WorkingArea.Bottom, this.Bottom)) 
					this.Top = scn.WorkingArea.Bottom - this.Height; 
				
			}
			
		void TIMERTick(object sender, EventArgs e)
		{
		    lblTime.Text = DateTime.Now.ToLongTimeString();
		}
		void LblTimeClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		void LblTimeDoubleClick(object sender, EventArgs e)
		{
			if(MessageBox.Show("Exit timer?","Exit Timer",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
			{
				Application.Exit();
			}
		}
			
		
	}
}
