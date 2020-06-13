namespace OBS_AdvancedTimer
{
    partial class FRM_Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.BTN_ResetTimer = new System.Windows.Forms.Button();
            this.BTN_StopTimer = new System.Windows.Forms.Button();
            this.BTN_StartTimer = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BTN_FileBrowser = new System.Windows.Forms.Button();
            this.TBX_FilePath = new System.Windows.Forms.TextBox();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.PAN_Timer = new System.Windows.Forms.Panel();
            this.TBX_Seconds = new System.Windows.Forms.TextBox();
            this.TBX_Hour = new System.Windows.Forms.TextBox();
            this.TBX_Minutes = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.CBX_Lang = new System.Windows.Forms.ComboBox();
            this.LBL_Lang = new System.Windows.Forms.Label();
            this.LBL_Error = new System.Windows.Forms.Label();
            this.TBX_Format = new System.Windows.Forms.TextBox();
            this.LBL_Format = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BTN_EditFormat = new System.Windows.Forms.Button();
            this.notifIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.LBL_OutputFile = new System.Windows.Forms.Label();
            this.LBL_Dev = new System.Windows.Forms.Label();
            this.LBL_Ver = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTN_Info = new System.Windows.Forms.Button();
            this.BTN_Reduce = new System.Windows.Forms.Button();
            this.BTN_Close = new System.Windows.Forms.Button();
            this.PAN_Timer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_ResetTimer
            // 
            this.BTN_ResetTimer.BackColor = System.Drawing.Color.Chocolate;
            this.BTN_ResetTimer.Enabled = false;
            this.BTN_ResetTimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_ResetTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_ResetTimer.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.BTN_ResetTimer.ForeColor = System.Drawing.Color.White;
            this.BTN_ResetTimer.Location = new System.Drawing.Point(685, 284);
            this.BTN_ResetTimer.Name = "BTN_ResetTimer";
            this.BTN_ResetTimer.Size = new System.Drawing.Size(246, 45);
            this.BTN_ResetTimer.TabIndex = 129;
            this.BTN_ResetTimer.Text = "Reset timer";
            this.BTN_ResetTimer.UseVisualStyleBackColor = false;
            this.BTN_ResetTimer.Click += new System.EventHandler(this.BTN_ResetTimer_Click);
            // 
            // BTN_StopTimer
            // 
            this.BTN_StopTimer.BackColor = System.Drawing.Color.Brown;
            this.BTN_StopTimer.Enabled = false;
            this.BTN_StopTimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_StopTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_StopTimer.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.BTN_StopTimer.ForeColor = System.Drawing.Color.White;
            this.BTN_StopTimer.Location = new System.Drawing.Point(405, 284);
            this.BTN_StopTimer.Name = "BTN_StopTimer";
            this.BTN_StopTimer.Size = new System.Drawing.Size(246, 45);
            this.BTN_StopTimer.TabIndex = 128;
            this.BTN_StopTimer.Text = "Stop timer";
            this.BTN_StopTimer.UseVisualStyleBackColor = false;
            this.BTN_StopTimer.Click += new System.EventHandler(this.BTN_StopTimer_Click);
            // 
            // BTN_StartTimer
            // 
            this.BTN_StartTimer.BackColor = System.Drawing.Color.OliveDrab;
            this.BTN_StartTimer.Enabled = false;
            this.BTN_StartTimer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_StartTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_StartTimer.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.BTN_StartTimer.ForeColor = System.Drawing.Color.White;
            this.BTN_StartTimer.Location = new System.Drawing.Point(125, 284);
            this.BTN_StartTimer.Name = "BTN_StartTimer";
            this.BTN_StartTimer.Size = new System.Drawing.Size(246, 45);
            this.BTN_StartTimer.TabIndex = 127;
            this.BTN_StartTimer.Text = "Start timer";
            this.BTN_StartTimer.UseVisualStyleBackColor = false;
            this.BTN_StartTimer.Click += new System.EventHandler(this.BTN_StartTimer_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BTN_FileBrowser
            // 
            this.BTN_FileBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_FileBrowser.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_FileBrowser.Location = new System.Drawing.Point(806, 537);
            this.BTN_FileBrowser.Name = "BTN_FileBrowser";
            this.BTN_FileBrowser.Size = new System.Drawing.Size(46, 29);
            this.BTN_FileBrowser.TabIndex = 130;
            this.BTN_FileBrowser.Text = "...";
            this.BTN_FileBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTN_FileBrowser.UseVisualStyleBackColor = true;
            this.BTN_FileBrowser.Click += new System.EventHandler(this.BTN_FileBrowser_Click);
            // 
            // TBX_FilePath
            // 
            this.TBX_FilePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TBX_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_FilePath.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.TBX_FilePath.ForeColor = System.Drawing.Color.White;
            this.TBX_FilePath.Location = new System.Drawing.Point(238, 541);
            this.TBX_FilePath.Name = "TBX_FilePath";
            this.TBX_FilePath.ReadOnly = true;
            this.TBX_FilePath.Size = new System.Drawing.Size(554, 27);
            this.TBX_FilePath.TabIndex = 131;
            // 
            // PAN_Timer
            // 
            this.PAN_Timer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PAN_Timer.Controls.Add(this.TBX_Seconds);
            this.PAN_Timer.Controls.Add(this.TBX_Hour);
            this.PAN_Timer.Controls.Add(this.TBX_Minutes);
            this.PAN_Timer.Controls.Add(this.Label1);
            this.PAN_Timer.Controls.Add(this.Label2);
            this.PAN_Timer.Location = new System.Drawing.Point(264, 138);
            this.PAN_Timer.Name = "PAN_Timer";
            this.PAN_Timer.Size = new System.Drawing.Size(528, 125);
            this.PAN_Timer.TabIndex = 133;
            this.PAN_Timer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // TBX_Seconds
            // 
            this.TBX_Seconds.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.TBX_Seconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Seconds.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Seconds.ForeColor = System.Drawing.Color.White;
            this.TBX_Seconds.Location = new System.Drawing.Point(353, 11);
            this.TBX_Seconds.MaxLength = 2;
            this.TBX_Seconds.Name = "TBX_Seconds";
            this.TBX_Seconds.Size = new System.Drawing.Size(117, 99);
            this.TBX_Seconds.TabIndex = 129;
            this.TBX_Seconds.Text = "00";
            this.TBX_Seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBX_Seconds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_Secondes_KeyPress);
            // 
            // TBX_Hour
            // 
            this.TBX_Hour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.TBX_Hour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Hour.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Hour.ForeColor = System.Drawing.Color.White;
            this.TBX_Hour.Location = new System.Drawing.Point(56, 13);
            this.TBX_Hour.MaxLength = 2;
            this.TBX_Hour.Name = "TBX_Hour";
            this.TBX_Hour.Size = new System.Drawing.Size(117, 99);
            this.TBX_Hour.TabIndex = 128;
            this.TBX_Hour.Text = "00";
            this.TBX_Hour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBX_Hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_Hour_KeyPress);
            // 
            // TBX_Minutes
            // 
            this.TBX_Minutes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.TBX_Minutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Minutes.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Minutes.ForeColor = System.Drawing.Color.White;
            this.TBX_Minutes.Location = new System.Drawing.Point(203, 11);
            this.TBX_Minutes.MaxLength = 2;
            this.TBX_Minutes.Name = "TBX_Minutes";
            this.TBX_Minutes.Size = new System.Drawing.Size(117, 99);
            this.TBX_Minutes.TabIndex = 127;
            this.TBX_Minutes.Text = "00";
            this.TBX_Minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBX_Minutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_Minutes_KeyPress);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(170, 3);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(43, 99);
            this.Label1.TabIndex = 130;
            this.Label1.Text = ":";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label2
            // 
            this.Label2.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(320, 2);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 99);
            this.Label2.TabIndex = 131;
            this.Label2.Text = ":";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBX_Lang
            // 
            this.CBX_Lang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CBX_Lang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBX_Lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBX_Lang.ForeColor = System.Drawing.Color.White;
            this.CBX_Lang.FormattingEnabled = true;
            this.CBX_Lang.Items.AddRange(new object[] {
            "English",
            "Français",
            "Deutsch",
            "Español",
            "Italiano",
            "Português",
            "Polski",
            "Русский",
            "中国"});
            this.CBX_Lang.Location = new System.Drawing.Point(115, 8);
            this.CBX_Lang.Name = "CBX_Lang";
            this.CBX_Lang.Size = new System.Drawing.Size(121, 27);
            this.CBX_Lang.TabIndex = 138;
            this.CBX_Lang.SelectedIndexChanged += new System.EventHandler(this.CBX_Lang_SelectedIndexChanged);
            // 
            // LBL_Lang
            // 
            this.LBL_Lang.Location = new System.Drawing.Point(12, 11);
            this.LBL_Lang.Name = "LBL_Lang";
            this.LBL_Lang.Size = new System.Drawing.Size(97, 19);
            this.LBL_Lang.TabIndex = 139;
            this.LBL_Lang.Text = "Language :";
            this.LBL_Lang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Lang.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Error
            // 
            this.LBL_Error.ForeColor = System.Drawing.Color.Brown;
            this.LBL_Error.Location = new System.Drawing.Point(12, 569);
            this.LBL_Error.Name = "LBL_Error";
            this.LBL_Error.Size = new System.Drawing.Size(1042, 59);
            this.LBL_Error.TabIndex = 140;
            this.LBL_Error.Text = "Error :";
            this.LBL_Error.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LBL_Error.Visible = false;
            // 
            // TBX_Format
            // 
            this.TBX_Format.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.TBX_Format.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBX_Format.Enabled = false;
            this.TBX_Format.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.TBX_Format.ForeColor = System.Drawing.Color.White;
            this.TBX_Format.Location = new System.Drawing.Point(251, 458);
            this.TBX_Format.Name = "TBX_Format";
            this.TBX_Format.Size = new System.Drawing.Size(448, 27);
            this.TBX_Format.TabIndex = 141;
            // 
            // LBL_Format
            // 
            this.LBL_Format.Location = new System.Drawing.Point(481, 347);
            this.LBL_Format.Name = "LBL_Format";
            this.LBL_Format.Size = new System.Drawing.Size(94, 25);
            this.LBL_Format.TabIndex = 142;
            this.LBL_Format.Text = "Format :";
            this.LBL_Format.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_Format.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(419, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 30);
            this.label4.TabIndex = 143;
            this.label4.Text = "%h hour %m minutes and %s seconds ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(419, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(280, 30);
            this.label7.TabIndex = 146;
            this.label7.Text = "1 hour 14 minutes 04 seconds";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(315, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 30);
            this.label5.TabIndex = 147;
            this.label5.Text = "Example :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(315, 408);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 30);
            this.label6.TabIndex = 148;
            this.label6.Text = "Display :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BTN_EditFormat
            // 
            this.BTN_EditFormat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BTN_EditFormat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BTN_EditFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_EditFormat.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EditFormat.ForeColor = System.Drawing.Color.White;
            this.BTN_EditFormat.Location = new System.Drawing.Point(713, 458);
            this.BTN_EditFormat.Name = "BTN_EditFormat";
            this.BTN_EditFormat.Size = new System.Drawing.Size(79, 23);
            this.BTN_EditFormat.TabIndex = 149;
            this.BTN_EditFormat.Text = "Modify";
            this.BTN_EditFormat.UseVisualStyleBackColor = false;
            this.BTN_EditFormat.Click += new System.EventHandler(this.BTN_EditFormat_Click);
            // 
            // notifIcon
            // 
            this.notifIcon.BalloonTipText = "EchoDream\'s OBS\'Timer is still running in background";
            this.notifIcon.BalloonTipTitle = "EchoDream\'s OBS\'Timer is active";
            this.notifIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifIcon.Icon")));
            this.notifIcon.Text = "EchoDream\'s OBS\'Timer is Active";
            this.notifIcon.Visible = true;
            this.notifIcon.Click += new System.EventHandler(this.notifIcon_Click);
            // 
            // LBL_OutputFile
            // 
            this.LBL_OutputFile.Location = new System.Drawing.Point(387, 514);
            this.LBL_OutputFile.Name = "LBL_OutputFile";
            this.LBL_OutputFile.Size = new System.Drawing.Size(274, 24);
            this.LBL_OutputFile.TabIndex = 151;
            this.LBL_OutputFile.Text = "Output file directory :";
            this.LBL_OutputFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LBL_OutputFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Dev
            // 
            this.LBL_Dev.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Dev.ForeColor = System.Drawing.Color.White;
            this.LBL_Dev.Location = new System.Drawing.Point(6, 628);
            this.LBL_Dev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Dev.Name = "LBL_Dev";
            this.LBL_Dev.Size = new System.Drawing.Size(280, 23);
            this.LBL_Dev.TabIndex = 152;
            this.LBL_Dev.Text = "Made with ❤ by Maxmistral";
            this.LBL_Dev.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // LBL_Ver
            // 
            this.LBL_Ver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Ver.ForeColor = System.Drawing.Color.White;
            this.LBL_Ver.Location = new System.Drawing.Point(988, 628);
            this.LBL_Ver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBL_Ver.Name = "LBL_Ver";
            this.LBL_Ver.Size = new System.Drawing.Size(71, 23);
            this.LBL_Ver.TabIndex = 153;
            this.LBL_Ver.Text = "V1.0.0";
            this.LBL_Ver.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OBS_AdvancedTimer.Properties.Resources.OBSTimer_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(331, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 118);
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            // 
            // BTN_Info
            // 
            this.BTN_Info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BTN_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.BTN_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Info.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.BTN_Info.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Info.Image")));
            this.BTN_Info.Location = new System.Drawing.Point(941, 5);
            this.BTN_Info.Name = "BTN_Info";
            this.BTN_Info.Size = new System.Drawing.Size(34, 34);
            this.BTN_Info.TabIndex = 122;
            this.BTN_Info.UseVisualStyleBackColor = true;
            this.BTN_Info.Click += new System.EventHandler(this.BTN_Info_Click);
            // 
            // BTN_Reduce
            // 
            this.BTN_Reduce.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Reduce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BTN_Reduce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.BTN_Reduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Reduce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.BTN_Reduce.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Reduce.Image")));
            this.BTN_Reduce.Location = new System.Drawing.Point(983, 5);
            this.BTN_Reduce.Name = "BTN_Reduce";
            this.BTN_Reduce.Size = new System.Drawing.Size(34, 34);
            this.BTN_Reduce.TabIndex = 121;
            this.BTN_Reduce.UseVisualStyleBackColor = true;
            this.BTN_Reduce.Click += new System.EventHandler(this.BTN_Reduce_Click);
            // 
            // BTN_Close
            // 
            this.BTN_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.BTN_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.BTN_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.BTN_Close.Image = ((System.Drawing.Image)(resources.GetObject("BTN_Close.Image")));
            this.BTN_Close.Location = new System.Drawing.Point(1025, 4);
            this.BTN_Close.Name = "BTN_Close";
            this.BTN_Close.Size = new System.Drawing.Size(34, 34);
            this.BTN_Close.TabIndex = 120;
            this.BTN_Close.UseVisualStyleBackColor = true;
            this.BTN_Close.Click += new System.EventHandler(this.BTN_Close_Click);
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(1066, 657);
            this.Controls.Add(this.LBL_Ver);
            this.Controls.Add(this.LBL_Dev);
            this.Controls.Add(this.LBL_OutputFile);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTN_EditFormat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBL_Format);
            this.Controls.Add(this.TBX_Format);
            this.Controls.Add(this.LBL_Error);
            this.Controls.Add(this.LBL_Lang);
            this.Controls.Add(this.CBX_Lang);
            this.Controls.Add(this.PAN_Timer);
            this.Controls.Add(this.TBX_FilePath);
            this.Controls.Add(this.BTN_FileBrowser);
            this.Controls.Add(this.BTN_ResetTimer);
            this.Controls.Add(this.BTN_StopTimer);
            this.Controls.Add(this.BTN_StartTimer);
            this.Controls.Add(this.BTN_Info);
            this.Controls.Add(this.BTN_Reduce);
            this.Controls.Add(this.BTN_Close);
            this.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRM_Main";
            this.Text = "EchoDream\'s OBS\'Timer";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FRM_Main_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnStayClick_MouseDown);
            this.PAN_Timer.ResumeLayout(false);
            this.PAN_Timer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ResetTimer;
        private System.Windows.Forms.Button BTN_StopTimer;
        private System.Windows.Forms.Button BTN_StartTimer;
        private System.Windows.Forms.Button BTN_Reduce;
        private System.Windows.Forms.Button BTN_Close;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button BTN_FileBrowser;
        internal System.Windows.Forms.TextBox TBX_FilePath;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Panel PAN_Timer;
        internal System.Windows.Forms.TextBox TBX_Seconds;
        internal System.Windows.Forms.TextBox TBX_Hour;
        internal System.Windows.Forms.TextBox TBX_Minutes;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox CBX_Lang;
        private System.Windows.Forms.Label LBL_Lang;
        private System.Windows.Forms.Label LBL_Error;
        internal System.Windows.Forms.TextBox TBX_Format;
        private System.Windows.Forms.Label LBL_Format;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BTN_EditFormat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Info;
        private System.Windows.Forms.NotifyIcon notifIcon;
        private System.Windows.Forms.Label LBL_OutputFile;
        private System.Windows.Forms.Label LBL_Dev;
        private System.Windows.Forms.Label LBL_Ver;
    }
}

