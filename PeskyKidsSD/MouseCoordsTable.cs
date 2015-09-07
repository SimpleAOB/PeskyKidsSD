/*
 * Created by SharpDevelop.
 * User: Win7-Gaming
 * Date: 9/3/2015
 * Time: 7:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PeskyKidsSD
{
	/// <summary>
	/// Description of MouseCoordsTable.
	/// </summary>
	public partial class MouseCoordsTable : Form
	{
		public MouseCoordsTable()
		{
			InitializeComponent();
		}
		void MouseCoordsTableLoad(object sender, EventArgs e)
		{
			
		}
		public void setTableMouse(string message) {
			textBox1.Clear();
			textBox1.Text = message;
		}
		public void setTableKeys(string message) {
			textBox2.Clear();
			textBox2.Text = message;
		}
	}
}
