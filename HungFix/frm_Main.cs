using Microsoft.Win32;
using System;
using System.Windows.Forms;

namespace HungFix
{
    public partial class frm_Main : Form
    {
        
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            try
            {
                using (RegistryKey key = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\GraphicsDrivers"))
                {
                    if (key != null)
                    {
                        object o = key.GetValue("TdrLevel");
                        if (o != null)
                        {
                            nud_Delay.Value = decimal.Parse(o.ToString());
                        }
                    }
                }
            }
            catch {}
        }

        private void btn_Default_Click(Object sender, EventArgs e)
        {
            RegistryKey regPath = Registry.LocalMachine.OpenSubKey("System\\CurrentControlSet\\Control\\GraphicsDrivers", true);
            regPath.DeleteValue("TdrLevel");
            MessageBox.Show("TDR is now back to default.\n\nThe computer might need to be restarted for the change to be effective.", "Done!");
            Application.Exit();
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            try
            {
                Registry.LocalMachine.CreateSubKey("System\\CurrentControlSet\\Control\\GraphicsDrivers").SetValue("TdrLevel", Convert.ToInt32(nud_Delay.Value));
                if(nud_Delay.Value != 0) { MessageBox.Show("TDR now set to: " + Convert.ToInt32(nud_Delay.Value).ToString() + "\n\nThe computer might need to be restarted for the change to be effective.", "Done"); }
                else { MessageBox.Show("TDR now disabled.\n\nThe computer might need to be restarted for the change to be effective.", "Done!"); }
                Application.Exit();        
            } catch { MessageBox.Show("Could not write into Registry", "Error"); }
        }

        private void btn_Cancel_Click(object sender, EventArgs e) { Application.Exit(); }

    }
}
