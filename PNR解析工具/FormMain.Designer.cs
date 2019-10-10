namespace PNR解析工具
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_OpenPath = new System.Windows.Forms.Button();
            this.BTN_StartProc = new System.Windows.Forms.Button();
            this.BTN_Choose = new System.Windows.Forms.Button();
            this.TB_FilePath = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LBState = new System.Windows.Forms.Label();
            this.BTN_OpenLogs = new System.Windows.Forms.Button();
            this.BTN_ClearLogs = new System.Windows.Forms.Button();
            this.CB_TxtLog = new System.Windows.Forms.CheckBox();
            this.CB_Kilo = new System.Windows.Forms.CheckBox();
            this.CB_SelLog = new System.Windows.Forms.CheckBox();
            this.LB_Log = new System.Windows.Forms.ListBox();
            this.BG_Proc = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_TryTime = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_TryNum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_ThreadNum = new System.Windows.Forms.ComboBox();
            this.Btn_OpenCur = new System.Windows.Forms.Button();
            this.BTN_StartScan = new System.Windows.Forms.Button();
            this.BTN_AddFile = new System.Windows.Forms.Button();
            this.TB_FilePahtUrlList = new System.Windows.Forms.TextBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.BG_Scan = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_OpenPath);
            this.groupBox1.Controls.Add(this.BTN_StartProc);
            this.groupBox1.Controls.Add(this.BTN_Choose);
            this.groupBox1.Controls.Add(this.TB_FilePath);
            this.groupBox1.Location = new System.Drawing.Point(1, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PNR原始文本文件路径";
            // 
            // BTN_OpenPath
            // 
            this.BTN_OpenPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OpenPath.Location = new System.Drawing.Point(639, 20);
            this.BTN_OpenPath.Name = "BTN_OpenPath";
            this.BTN_OpenPath.Size = new System.Drawing.Size(69, 23);
            this.BTN_OpenPath.TabIndex = 3;
            this.BTN_OpenPath.Text = "结果目录";
            this.BTN_OpenPath.UseVisualStyleBackColor = true;
            this.BTN_OpenPath.Click += new System.EventHandler(this.BTN_OpenPath_Click);
            // 
            // BTN_StartProc
            // 
            this.BTN_StartProc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_StartProc.Location = new System.Drawing.Point(564, 20);
            this.BTN_StartProc.Name = "BTN_StartProc";
            this.BTN_StartProc.Size = new System.Drawing.Size(69, 23);
            this.BTN_StartProc.TabIndex = 2;
            this.BTN_StartProc.Text = "开始解析";
            this.BTN_StartProc.UseVisualStyleBackColor = true;
            this.BTN_StartProc.Click += new System.EventHandler(this.BTN_StartProc_Click);
            // 
            // BTN_Choose
            // 
            this.BTN_Choose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Choose.Location = new System.Drawing.Point(489, 20);
            this.BTN_Choose.Name = "BTN_Choose";
            this.BTN_Choose.Size = new System.Drawing.Size(69, 23);
            this.BTN_Choose.TabIndex = 1;
            this.BTN_Choose.Text = "选择文件";
            this.BTN_Choose.UseVisualStyleBackColor = true;
            this.BTN_Choose.Click += new System.EventHandler(this.BTN_Choose_Click);
            // 
            // TB_FilePath
            // 
            this.TB_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_FilePath.Location = new System.Drawing.Point(11, 20);
            this.TB_FilePath.Name = "TB_FilePath";
            this.TB_FilePath.Size = new System.Drawing.Size(472, 21);
            this.TB_FilePath.TabIndex = 0;
            this.TB_FilePath.TextChanged += new System.EventHandler(this.TB_FilePath_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.txt";
            this.openFileDialog1.Filter = "PNR文本|*.txt|所有文件|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LBState);
            this.groupBox2.Controls.Add(this.BTN_OpenLogs);
            this.groupBox2.Controls.Add(this.BTN_ClearLogs);
            this.groupBox2.Controls.Add(this.CB_TxtLog);
            this.groupBox2.Controls.Add(this.CB_Kilo);
            this.groupBox2.Controls.Add(this.CB_SelLog);
            this.groupBox2.Controls.Add(this.LB_Log);
            this.groupBox2.Location = new System.Drawing.Point(1, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(714, 246);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "运行日志";
            // 
            // LBState
            // 
            this.LBState.AutoSize = true;
            this.LBState.ForeColor = System.Drawing.Color.Red;
            this.LBState.Location = new System.Drawing.Point(501, 5);
            this.LBState.Name = "LBState";
            this.LBState.Size = new System.Drawing.Size(53, 12);
            this.LBState.TabIndex = 46;
            this.LBState.Text = "等待开始";
            // 
            // BTN_OpenLogs
            // 
            this.BTN_OpenLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OpenLogs.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_OpenLogs.Location = new System.Drawing.Point(420, 2);
            this.BTN_OpenLogs.Name = "BTN_OpenLogs";
            this.BTN_OpenLogs.Size = new System.Drawing.Size(75, 22);
            this.BTN_OpenLogs.TabIndex = 45;
            this.BTN_OpenLogs.Text = "打开日志";
            this.BTN_OpenLogs.UseVisualStyleBackColor = true;
            this.BTN_OpenLogs.Click += new System.EventHandler(this.BTN_OpenLogs_Click);
            // 
            // BTN_ClearLogs
            // 
            this.BTN_ClearLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ClearLogs.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTN_ClearLogs.Location = new System.Drawing.Point(342, 2);
            this.BTN_ClearLogs.Name = "BTN_ClearLogs";
            this.BTN_ClearLogs.Size = new System.Drawing.Size(75, 22);
            this.BTN_ClearLogs.TabIndex = 44;
            this.BTN_ClearLogs.Text = "清空日志";
            this.BTN_ClearLogs.UseVisualStyleBackColor = true;
            this.BTN_ClearLogs.Click += new System.EventHandler(this.BTN_ClearLogs_Click);
            // 
            // CB_TxtLog
            // 
            this.CB_TxtLog.AutoSize = true;
            this.CB_TxtLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_TxtLog.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_TxtLog.Location = new System.Drawing.Point(237, 0);
            this.CB_TxtLog.Name = "CB_TxtLog";
            this.CB_TxtLog.Size = new System.Drawing.Size(96, 21);
            this.CB_TxtLog.TabIndex = 43;
            this.CB_TxtLog.Text = "文本记录日志";
            this.CB_TxtLog.UseVisualStyleBackColor = true;
            // 
            // CB_Kilo
            // 
            this.CB_Kilo.AutoSize = true;
            this.CB_Kilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Kilo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_Kilo.Location = new System.Drawing.Point(147, 0);
            this.CB_Kilo.Name = "CB_Kilo";
            this.CB_Kilo.Size = new System.Drawing.Size(88, 21);
            this.CB_Kilo.TabIndex = 42;
            this.CB_Kilo.Text = "最大1000行";
            this.CB_Kilo.UseVisualStyleBackColor = true;
            // 
            // CB_SelLog
            // 
            this.CB_SelLog.AutoSize = true;
            this.CB_SelLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_SelLog.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CB_SelLog.Location = new System.Drawing.Point(69, 0);
            this.CB_SelLog.Name = "CB_SelLog";
            this.CB_SelLog.Size = new System.Drawing.Size(72, 21);
            this.CB_SelLog.TabIndex = 41;
            this.CB_SelLog.Text = "日志滚屏";
            this.CB_SelLog.UseVisualStyleBackColor = true;
            // 
            // LB_Log
            // 
            this.LB_Log.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LB_Log.FormattingEnabled = true;
            this.LB_Log.ItemHeight = 17;
            this.LB_Log.Location = new System.Drawing.Point(6, 32);
            this.LB_Log.Name = "LB_Log";
            this.LB_Log.Size = new System.Drawing.Size(702, 208);
            this.LB_Log.TabIndex = 1;
            // 
            // BG_Proc
            // 
            this.BG_Proc.WorkerReportsProgress = true;
            this.BG_Proc.WorkerSupportsCancellation = true;
            this.BG_Proc.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BG_Proc_DoWork);
            this.BG_Proc.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BG_Proc_RunWorkerCompleted);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.CB_TryTime);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.CB_TryNum);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.CB_ThreadNum);
            this.groupBox3.Controls.Add(this.Btn_OpenCur);
            this.groupBox3.Controls.Add(this.BTN_StartScan);
            this.groupBox3.Controls.Add(this.BTN_AddFile);
            this.groupBox3.Controls.Add(this.TB_FilePahtUrlList);
            this.groupBox3.Location = new System.Drawing.Point(1, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(714, 111);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PNR数据抓取";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "重试周期:";
            // 
            // CB_TryTime
            // 
            this.CB_TryTime.FormattingEnabled = true;
            this.CB_TryTime.Items.AddRange(new object[] {
            "1000ms",
            "2000ms",
            "5000ms",
            "10000ms",
            "20000ms"});
            this.CB_TryTime.Location = new System.Drawing.Point(639, 81);
            this.CB_TryTime.Name = "CB_TryTime";
            this.CB_TryTime.Size = new System.Drawing.Size(69, 20);
            this.CB_TryTime.TabIndex = 8;
            this.CB_TryTime.TextChanged += new System.EventHandler(this.CB_TryTime_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(564, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "失败重试数:";
            // 
            // CB_TryNum
            // 
            this.CB_TryNum.FormattingEnabled = true;
            this.CB_TryNum.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "30",
            "50",
            "100",
            "200"});
            this.CB_TryNum.Location = new System.Drawing.Point(639, 53);
            this.CB_TryNum.Name = "CB_TryNum";
            this.CB_TryNum.Size = new System.Drawing.Size(69, 20);
            this.CB_TryNum.TabIndex = 6;
            this.CB_TryNum.TextChanged += new System.EventHandler(this.CB_TryNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(564, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "线程数设置:";
            // 
            // CB_ThreadNum
            // 
            this.CB_ThreadNum.FormattingEnabled = true;
            this.CB_ThreadNum.Items.AddRange(new object[] {
            "1",
            "5",
            "10",
            "20",
            "30",
            "50",
            "100",
            "200"});
            this.CB_ThreadNum.Location = new System.Drawing.Point(639, 23);
            this.CB_ThreadNum.Name = "CB_ThreadNum";
            this.CB_ThreadNum.Size = new System.Drawing.Size(69, 20);
            this.CB_ThreadNum.TabIndex = 4;
            this.CB_ThreadNum.SelectedIndexChanged += new System.EventHandler(this.CB_ThreadNum_SelectedIndexChanged);
            this.CB_ThreadNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CB_ThreadNum_KeyPress);
            this.CB_ThreadNum.TextChanged += new System.EventHandler(this.CB_ThreadNum_TextChanged);
            // 
            // Btn_OpenCur
            // 
            this.Btn_OpenCur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_OpenCur.Location = new System.Drawing.Point(489, 79);
            this.Btn_OpenCur.Name = "Btn_OpenCur";
            this.Btn_OpenCur.Size = new System.Drawing.Size(69, 23);
            this.Btn_OpenCur.TabIndex = 3;
            this.Btn_OpenCur.Text = "结果目录";
            this.Btn_OpenCur.UseVisualStyleBackColor = true;
            this.Btn_OpenCur.Click += new System.EventHandler(this.Btn_OpenCur_Click);
            // 
            // BTN_StartScan
            // 
            this.BTN_StartScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_StartScan.Location = new System.Drawing.Point(489, 50);
            this.BTN_StartScan.Name = "BTN_StartScan";
            this.BTN_StartScan.Size = new System.Drawing.Size(69, 23);
            this.BTN_StartScan.TabIndex = 2;
            this.BTN_StartScan.Text = "开始抓取";
            this.BTN_StartScan.UseVisualStyleBackColor = true;
            this.BTN_StartScan.Click += new System.EventHandler(this.BTN_StartScan_Click);
            // 
            // BTN_AddFile
            // 
            this.BTN_AddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AddFile.Location = new System.Drawing.Point(489, 21);
            this.BTN_AddFile.Name = "BTN_AddFile";
            this.BTN_AddFile.Size = new System.Drawing.Size(69, 23);
            this.BTN_AddFile.TabIndex = 1;
            this.BTN_AddFile.Text = "添加文件";
            this.BTN_AddFile.UseVisualStyleBackColor = true;
            this.BTN_AddFile.Click += new System.EventHandler(this.BTN_AddFile_Click);
            // 
            // TB_FilePahtUrlList
            // 
            this.TB_FilePahtUrlList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_FilePahtUrlList.Location = new System.Drawing.Point(11, 20);
            this.TB_FilePahtUrlList.Multiline = true;
            this.TB_FilePahtUrlList.Name = "TB_FilePahtUrlList";
            this.TB_FilePahtUrlList.Size = new System.Drawing.Size(472, 81);
            this.TB_FilePahtUrlList.TabIndex = 0;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "*.txt";
            this.openFileDialog2.Filter = "URL文本|*.txt|所有文件|*.*";
            this.openFileDialog2.Multiselect = true;
            this.openFileDialog2.Title = "请选择包含URL信息的文件，支持多选";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // BG_Scan
            // 
            this.BG_Scan.WorkerReportsProgress = true;
            this.BG_Scan.WorkerSupportsCancellation = true;
            this.BG_Scan.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BG_Scan_DoWork);
            this.BG_Scan.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BG_Scan_RunWorkerCompleted);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 436);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PNR解析工具-[易本地工作室 www.ebend.net QQ:100004117 软件定制服务]";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_Choose;
        private System.Windows.Forms.TextBox TB_FilePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BTN_StartProc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_OpenLogs;
        private System.Windows.Forms.Button BTN_ClearLogs;
        private System.Windows.Forms.CheckBox CB_TxtLog;
        private System.Windows.Forms.CheckBox CB_Kilo;
        private System.Windows.Forms.CheckBox CB_SelLog;
        private System.Windows.Forms.ListBox LB_Log;
        private System.ComponentModel.BackgroundWorker BG_Proc;
        private System.Windows.Forms.Label LBState;
        private System.Windows.Forms.Button BTN_OpenPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Btn_OpenCur;
        private System.Windows.Forms.Button BTN_StartScan;
        private System.Windows.Forms.Button BTN_AddFile;
        private System.Windows.Forms.TextBox TB_FilePahtUrlList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_TryNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_ThreadNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_TryTime;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.ComponentModel.BackgroundWorker BG_Scan;
    }
}

