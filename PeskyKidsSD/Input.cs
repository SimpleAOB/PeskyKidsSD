/*
 * Created by SharpDevelop.
 * User: case512n03
 * Date: 9/2/2015
 * Time: 1:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PeskyKidsSD
{
	public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Change the main message, title, and if it's password protected (optional) of the Input Modal
        /// </summary>
        /// <param name="message">Required</param>
        /// <param name="title">Required</param>
        /// <param name="password">Optional</param>
        public void displaySettings(string message, string title, bool password = false)
        {
            this.Text = title;
            mainMessage.Text = message;
            if (password == true)
            {
                userInput.PasswordChar = '#';
            }
        }

        private void Input_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (mainMessage.Text == "")
            {
                MessageBox.Show("Please enter something");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Used to return the input from when ShowDialog is called. This would be called from a different CS file
        /// </summary>
        /// <returns>String</returns>
        public string returnText()
        {
            return userInput.Text;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                this.Close();
            }
        }
		void Button1Click(object sender, EventArgs e)
		{
			this.Close();
		}
		void UserInputKeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return) {
				this.Close();
			}
		}
		void InputLoad(object sender, EventArgs e)
		{
			userInput.Clear();
		}
    }
}
