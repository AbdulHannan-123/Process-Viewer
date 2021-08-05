using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessViewer
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(runTextBox.Text)) {
                try {
                    Process process = new Process();
                    process.StartInfo.FileName = runTextBox.Text;
                    process.Start();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
            }
        }
    }
}
