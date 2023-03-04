using System;
using System.Windows.Forms;

namespace JupiterRunner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public static void KillMyApp(string AppName)
        {
            var localByName = System.Diagnostics.Process.GetProcessesByName(AppName);
            foreach (System.Diagnostics.Process p in localByName)
            {
                p.WaitForExit(5000);
                p.Kill();
            }
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do you want to close all open jupyter-lab?", "Warning", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    KillMyApp("jupyter-lab");
                }
                else if (res == DialogResult.Cancel)
                {
                    return;
                }
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                //startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                startInfo.FileName = @"Jupiter\Scripts\jupyter-lab.exe";
                process.StartInfo = startInfo;
                process.Start();
                KillMyApp("conhost");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLoadNote_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Do you want to close all open jupyter-notebook?", "Warning", MessageBoxButtons.YesNoCancel);
                if (res == DialogResult.Yes)
                {
                    KillMyApp("jupyter-notebook");
                }
                else if (res == DialogResult.Cancel)
                {
                    return;
                }
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = @"Jupiter\Scripts\jupyter-notebook.exe";
               // startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnReInstall_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Do you want to reinstall the jupyter app?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    System.Diagnostics.Process process = new System.Diagnostics.Process();
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.FileName = "Reinstall.bat";
                    process.StartInfo = startInfo;
                    process.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
