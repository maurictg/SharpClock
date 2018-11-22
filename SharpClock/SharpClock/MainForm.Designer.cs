/*
 * Created by SharpDevelop.
 * User: 15547
 * Date: 8-11-2018
 * Time: 09:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SharpClock
{
	partial class CLOCK
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Timer TIMER;
		private System.Windows.Forms.Label lblDate;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CLOCK));
			this.lblTime = new System.Windows.Forms.Label();
			this.TIMER = new System.Windows.Forms.Timer(this.components);
			this.lblDate = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblTime
			// 
			this.lblTime.Font = new System.Drawing.Font("Segoe UI", 35.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.ForeColor = System.Drawing.Color.White;
			this.lblTime.Location = new System.Drawing.Point(0, 0);
			this.lblTime.Margin = new System.Windows.Forms.Padding(0);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(217, 55);
			this.lblTime.TabIndex = 0;
			this.lblTime.Text = "00:00:00";
			this.lblTime.DoubleClick += new System.EventHandler(this.LblTimeDoubleClick);
			// 
			// TIMER
			// 
			this.TIMER.Interval = 1000;
			this.TIMER.Tick += new System.EventHandler(this.TIMERTick);
			// 
			// lblDate
			// 
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.ForeColor = System.Drawing.Color.Aqua;
			this.lblDate.Location = new System.Drawing.Point(70, 54);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(83, 19);
			this.lblDate.TabIndex = 1;
			this.lblDate.Text = "00-00-0000";
			// 
			// CLOCK
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(210, 72);
			this.ControlBox = false;
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.lblTime);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "CLOCK";
			this.Opacity = 0.9D;
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SharpClock";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Maroon;
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
