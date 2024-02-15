using System;
using System.Diagnostics;
using System.Drawing;
using System.ServiceProcess;
using System.Windows.Forms;

namespace ODOOSVC
{
    public partial class ODOOSVCForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public ODOOSVCForm()
        {
            InitializeComponent();
        }

        private void ODServiceRestart_Click(object sender, EventArgs e)
        {
            RestartService("odoo-server-16.0");
        }

        private void PostServiceRestart_Click(object sender, EventArgs e)
        {
            RestartService("PostgreSQL_For_Odoo");
        }
       
        public void RestartService(string serviceName)
        {
            switch (serviceName)
            {
                case "odoo-server-16.0":
                    ODServiceLabel.ForeColor = Color.Red;
                    break;
                case "PostgreSQL_For_Odoo":
                    PostServiceLabel.ForeColor = Color.Red;
                    break;
            }
            var psi = new ProcessStartInfo("net.exe", "stop " + serviceName);
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = true;
            psi.CreateNoWindow = true;
            psi.WorkingDirectory = Environment.SystemDirectory;
            var st = Process.Start(psi);
            st.WaitForExit();

            psi = new ProcessStartInfo("net.exe", "start " + serviceName);
            psi.UseShellExecute = true;
            psi.CreateNoWindow = true;
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.WorkingDirectory = Environment.SystemDirectory;
            st = Process.Start(psi);
            st.WaitForExit();
            switch (serviceName)
            {
                case "odoo-server-16.0":
                    ODServiceLabel.ForeColor = Color.LightGreen;
                    break;
                case "PostgreSQL_For_Odoo":
                    PostServiceLabel.ForeColor = Color.LightGreen;
                    break;
            }
        }

        private void ODServiceStop_Click(object sender, EventArgs e)
        {
            StopService("odoo-server-16.0");
        }

        private void PostServiceStop_Click(object sender, EventArgs e)
        {
            StopService("PostgreSQL_For_Odoo");
        }

        public void StopService(string serviceName)
        {
            var psi = new ProcessStartInfo("net.exe", "stop " + serviceName);
            psi.WindowStyle = ProcessWindowStyle.Hidden;
            psi.UseShellExecute = true;
            psi.WorkingDirectory = Environment.SystemDirectory;
            var st = Process.Start(psi);
            st.WaitForExit();
            switch (serviceName)
            {
                case "odoo-server-16.0":
                    ODServiceLabel.ForeColor = Color.Red;
                    break;
                case "PostgreSQL_For_Odoo":
                    PostServiceLabel.ForeColor = Color.Red;
                    break;
            }
        }

        private void ODOOSVCForm_Load(object sender, EventArgs e)
        {
            var odooService = new ServiceController("odoo-server-16.0");
            var postgreService = new ServiceController("PostgreSQL_For_Odoo");

            if (odooService.Status == ServiceControllerStatus.Running)
                ODServiceLabel.ForeColor = Color.LightGreen;

            if (postgreService.Status == ServiceControllerStatus.Running)
                PostServiceLabel.ForeColor = Color.LightGreen;
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MinimizeLabel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void HeaderLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void HeaderIcon_MouseDown(object sender, MouseEventArgs e)
        {
            MoveForm();
        }

        private void MoveForm()
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}
