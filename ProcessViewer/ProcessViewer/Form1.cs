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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] processes;

        void getAllProcesses()
        {
            ProcessList.Items.Clear();
            var processes = Process.GetProcesses().Where(p => (long)p.MainWindowHandle != 0).ToArray();
            
           foreach(Process p in processes)
            {
                ListViewItem item = new ListViewItem(p.ProcessName);
                item.SubItems.Add(p.Id.ToString());
                item.SubItems.Add(p.Responding ? "Running" : "Suspended");
                ProcessList.Items.Add(item);
            }

        }
        int GetCpuUsageForProcess(Process process)
        {
            var cpuCounter = new PerformanceCounter("Process", "% Processor Time", process.ProcessName);
            cpuCounter.NextValue();
            return (int)cpuCounter.NextValue();
        }
        private void timer_Tick(object sender, EventArgs e)
        {

            

            float fcpu  = pCPU.NextValue();
            float fram  = pRAM.NextValue();
            float fdisk = pDISK.NextValue();
            

            CPUProgressBar.Value = (int)fcpu;
            RAMProgressBar.Value = (int)fram;
            DISKProgressBar.Value = (int)fdisk;

            lblCPU.Text = string.Format("{0:0.00}%", fcpu);
            lblRAM.Text = string.Format("{0:0.00}%", fram);
            lblDISK.Text = string.Format("{0:0.00}%", fdisk);


            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
            chart1.Series["DISK"].Points.AddY(fdisk);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAllProcesses();
            timer.Start();
            chart1.ChartAreas[0].AxisY.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.Series["CPU"].Color = Color.Red;
            chart1.Series["RAM"].Color = Color.Blue;
            chart1.Series["DISK"].Color = Color.Green;

            
        }

        private void endTask_Click_1(object sender, EventArgs e)
        {
            kill(ProcessList.SelectedItems[0].Text);
            getAllProcesses();   
        }

        private void kill(string process)
        {
            try
            {
                Process[] proc = Process.GetProcessesByName(process);
                proc[0].Kill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (Form2 form2 = new Form2()) {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    getAllProcesses();
                }
            }
        }
    }
}
