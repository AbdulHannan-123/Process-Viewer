namespace ProcessViewer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pDISK = new System.Diagnostics.PerformanceCounter();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.Processes = new MetroFramework.Controls.MetroTabPage();
            this.Performance = new MetroFramework.Controls.MetroTabPage();
            this.lblDISK = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DISKProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.RAMProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.lblCPU = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblRAM = new MetroFramework.Controls.MetroLabel();
            this.CPUProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.ProcessList = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endTask = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.Processes.SuspendLayout();
            this.Performance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pDISK
            // 
            this.pDISK.CategoryName = "PhysicalDisk";
            this.pDISK.CounterName = "% Disk Time";
            this.pDISK.InstanceName = "_Total";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.Processes);
            this.metroTabControl1.Controls.Add(this.Performance);
            this.metroTabControl1.Location = new System.Drawing.Point(23, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(535, 465);
            this.metroTabControl1.TabIndex = 11;
            this.metroTabControl1.UseSelectable = true;
            // 
            // Processes
            // 
            this.Processes.Controls.Add(this.metroButton1);
            this.Processes.Controls.Add(this.endTask);
            this.Processes.Controls.Add(this.ProcessList);
            this.Processes.HorizontalScrollbarBarColor = true;
            this.Processes.HorizontalScrollbarHighlightOnWheel = false;
            this.Processes.HorizontalScrollbarSize = 10;
            this.Processes.Location = new System.Drawing.Point(4, 38);
            this.Processes.Name = "Processes";
            this.Processes.Size = new System.Drawing.Size(527, 423);
            this.Processes.TabIndex = 0;
            this.Processes.Text = "Processes";
            this.Processes.VerticalScrollbarBarColor = true;
            this.Processes.VerticalScrollbarHighlightOnWheel = false;
            this.Processes.VerticalScrollbarSize = 10;
            // 
            // Performance
            // 
            this.Performance.Controls.Add(this.lblDISK);
            this.Performance.Controls.Add(this.metroLabel4);
            this.Performance.Controls.Add(this.chart1);
            this.Performance.Controls.Add(this.DISKProgressBar);
            this.Performance.Controls.Add(this.metroLabel1);
            this.Performance.Controls.Add(this.RAMProgressBar);
            this.Performance.Controls.Add(this.lblCPU);
            this.Performance.Controls.Add(this.metroLabel2);
            this.Performance.Controls.Add(this.lblRAM);
            this.Performance.Controls.Add(this.CPUProgressBar);
            this.Performance.HorizontalScrollbarBarColor = true;
            this.Performance.HorizontalScrollbarHighlightOnWheel = false;
            this.Performance.HorizontalScrollbarSize = 10;
            this.Performance.Location = new System.Drawing.Point(4, 38);
            this.Performance.Name = "Performance";
            this.Performance.Size = new System.Drawing.Size(527, 423);
            this.Performance.TabIndex = 1;
            this.Performance.Text = "Performance";
            this.Performance.VerticalScrollbarBarColor = true;
            this.Performance.VerticalScrollbarHighlightOnWheel = false;
            this.Performance.VerticalScrollbarSize = 10;
            // 
            // lblDISK
            // 
            this.lblDISK.AutoSize = true;
            this.lblDISK.Location = new System.Drawing.Point(411, 116);
            this.lblDISK.Name = "lblDISK";
            this.lblDISK.Size = new System.Drawing.Size(31, 19);
            this.lblDISK.TabIndex = 20;
            this.lblDISK.Text = "0 %";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 116);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(42, 19);
            this.metroLabel4.TabIndex = 19;
            this.metroLabel4.Text = "DISK :";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(21, 151);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "DISK";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(503, 276);
            this.chart1.TabIndex = 17;
            // 
            // DISKProgressBar
            // 
            this.DISKProgressBar.Location = new System.Drawing.Point(58, 112);
            this.DISKProgressBar.Name = "DISKProgressBar";
            this.DISKProgressBar.Size = new System.Drawing.Size(347, 23);
            this.DISKProgressBar.TabIndex = 18;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 25);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "CPU :";
            // 
            // RAMProgressBar
            // 
            this.RAMProgressBar.Location = new System.Drawing.Point(58, 66);
            this.RAMProgressBar.Name = "RAMProgressBar";
            this.RAMProgressBar.Size = new System.Drawing.Size(347, 23);
            this.RAMProgressBar.TabIndex = 12;
            // 
            // lblCPU
            // 
            this.lblCPU.AutoSize = true;
            this.lblCPU.Location = new System.Drawing.Point(411, 25);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(31, 19);
            this.lblCPU.TabIndex = 16;
            this.lblCPU.Text = "0 %";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 70);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "RAM :";
            // 
            // lblRAM
            // 
            this.lblRAM.AutoSize = true;
            this.lblRAM.Location = new System.Drawing.Point(411, 70);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(31, 19);
            this.lblRAM.TabIndex = 15;
            this.lblRAM.Text = "0 %";
            // 
            // CPUProgressBar
            // 
            this.CPUProgressBar.Location = new System.Drawing.Point(58, 25);
            this.CPUProgressBar.Name = "CPUProgressBar";
            this.CPUProgressBar.Size = new System.Drawing.Size(347, 19);
            this.CPUProgressBar.TabIndex = 14;
            // 
            // ProcessList
            // 
            this.ProcessList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ProcessList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProcessList.FullRowSelect = true;
            this.ProcessList.Location = new System.Drawing.Point(0, 16);
            this.ProcessList.MultiSelect = false;
            this.ProcessList.Name = "ProcessList";
            this.ProcessList.OwnerDraw = true;
            this.ProcessList.Size = new System.Drawing.Size(514, 314);
            this.ProcessList.TabIndex = 2;
            this.ProcessList.UseCompatibleStateImageBehavior = false;
            this.ProcessList.UseSelectable = true;
            this.ProcessList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 100;
            // 
            // endTask
            // 
            this.endTask.Location = new System.Drawing.Point(401, 351);
            this.endTask.Name = "endTask";
            this.endTask.Size = new System.Drawing.Size(113, 23);
            this.endTask.TabIndex = 5;
            this.endTask.Text = "End Task";
            this.endTask.UseSelectable = true;
            this.endTask.Click += new System.EventHandler(this.endTask_Click_1);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(269, 351);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(113, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "New Task";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 568);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TASK MANAGER";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pDISK)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.Processes.ResumeLayout(false);
            this.Performance.ResumeLayout(false);
            this.Performance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter pDISK;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Processes;
        private MetroFramework.Controls.MetroTabPage Performance;
        private MetroFramework.Controls.MetroLabel lblDISK;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroProgressBar DISKProgressBar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar RAMProgressBar;
        private MetroFramework.Controls.MetroLabel lblCPU;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblRAM;
        private MetroFramework.Controls.MetroProgressBar CPUProgressBar;
        private MetroFramework.Controls.MetroListView ProcessList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroButton endTask;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

