/*
 * Created by SharpDevelop.
 * User: case512n03
 * Date: 9/2/2015
 * Time: 1:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PeskyKidsSD
{
	partial class Input
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox mainMessage;
		private System.Windows.Forms.TextBox userInput;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.mainMessage = new System.Windows.Forms.TextBox();
			this.userInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(204, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// mainMessage
			// 
			this.mainMessage.BackColor = System.Drawing.SystemColors.Menu;
			this.mainMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mainMessage.Location = new System.Drawing.Point(12, 12);
			this.mainMessage.Multiline = true;
			this.mainMessage.Name = "mainMessage";
			this.mainMessage.ReadOnly = true;
			this.mainMessage.Size = new System.Drawing.Size(186, 72);
			this.mainMessage.TabIndex = 1;
			// 
			// userInput
			// 
			this.userInput.Location = new System.Drawing.Point(12, 90);
			this.userInput.Name = "userInput";
			this.userInput.Size = new System.Drawing.Size(267, 20);
			this.userInput.TabIndex = 2;
			this.userInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserInputKeyDown);
			// 
			// Input
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 122);
			this.Controls.Add(this.userInput);
			this.Controls.Add(this.mainMessage);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Input";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Input";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.InputLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
