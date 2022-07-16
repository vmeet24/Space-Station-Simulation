namespace DSN_UI
{
    partial class communicationform
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.LauchVehcileTelemetryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StopTelemetry = new System.Windows.Forms.Button();
            this.StartTelemetry = new System.Windows.Forms.Button();
            this.Deorbit = new System.Windows.Forms.Button();
            this.DeployPayload = new System.Windows.Forms.Button();
            this.SelectLaunchVehicleComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Decommission = new System.Windows.Forms.Button();
            this.PayloadDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PayloadTelemetryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.StopData = new System.Windows.Forms.Button();
            this.StartData = new System.Windows.Forms.Button();
            this.StopTelemetryPayload = new System.Windows.Forms.Button();
            this.StartTelemetryPayload = new System.Windows.Forms.Button();
            this.PayloadComboBox = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LaunchVehicle = new System.Windows.Forms.Button();
            this.LaunchVehicleComboBox = new System.Windows.Forms.ComboBox();
            this.Upload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(340, 78);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.LauchVehcileTelemetryRichTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.StopTelemetry);
            this.splitContainer1.Panel1.Controls.Add(this.StartTelemetry);
            this.splitContainer1.Panel1.Controls.Add(this.Deorbit);
            this.splitContainer1.Panel1.Controls.Add(this.DeployPayload);
            this.splitContainer1.Panel1.Controls.Add(this.SelectLaunchVehicleComboBox);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel2.Controls.Add(this.Decommission);
            this.splitContainer1.Panel2.Controls.Add(this.PayloadDataRichTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.PayloadTelemetryRichTextBox);
            this.splitContainer1.Panel2.Controls.Add(this.StopData);
            this.splitContainer1.Panel2.Controls.Add(this.StartData);
            this.splitContainer1.Panel2.Controls.Add(this.StopTelemetryPayload);
            this.splitContainer1.Panel2.Controls.Add(this.StartTelemetryPayload);
            this.splitContainer1.Panel2.Controls.Add(this.PayloadComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.panel7);
            this.splitContainer1.Size = new System.Drawing.Size(1087, 934);
            this.splitContainer1.SplitterDistance = 546;
            this.splitContainer1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(164, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Select Spacecraft";
            // 
            // LauchVehcileTelemetryRichTextBox
            // 
            this.LauchVehcileTelemetryRichTextBox.Location = new System.Drawing.Point(22, 326);
            this.LauchVehcileTelemetryRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LauchVehcileTelemetryRichTextBox.Name = "LauchVehcileTelemetryRichTextBox";
            this.LauchVehcileTelemetryRichTextBox.ReadOnly = true;
            this.LauchVehcileTelemetryRichTextBox.Size = new System.Drawing.Size(496, 520);
            this.LauchVehcileTelemetryRichTextBox.TabIndex = 10;
            this.LauchVehcileTelemetryRichTextBox.Text = "";
            // 
            // StopTelemetry
            // 
            this.StopTelemetry.BackColor = System.Drawing.Color.SeaShell;
            this.StopTelemetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopTelemetry.Location = new System.Drawing.Point(333, 854);
            this.StopTelemetry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopTelemetry.Name = "StopTelemetry";
            this.StopTelemetry.Size = new System.Drawing.Size(142, 41);
            this.StopTelemetry.TabIndex = 9;
            this.StopTelemetry.Text = "Stop Telemetry";
            this.StopTelemetry.UseVisualStyleBackColor = false;
            this.StopTelemetry.Click += new System.EventHandler(this.StopTelemetry_Click);
            // 
            // StartTelemetry
            // 
            this.StartTelemetry.BackColor = System.Drawing.Color.SeaShell;
            this.StartTelemetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTelemetry.Location = new System.Drawing.Point(61, 854);
            this.StartTelemetry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartTelemetry.Name = "StartTelemetry";
            this.StartTelemetry.Size = new System.Drawing.Size(142, 41);
            this.StartTelemetry.TabIndex = 8;
            this.StartTelemetry.Text = "Start Telemetry";
            this.StartTelemetry.UseVisualStyleBackColor = false;
            this.StartTelemetry.Click += new System.EventHandler(this.StartTelemetry_Click);
            // 
            // Deorbit
            // 
            this.Deorbit.BackColor = System.Drawing.Color.Red;
            this.Deorbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deorbit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Deorbit.Location = new System.Drawing.Point(351, 165);
            this.Deorbit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Deorbit.Name = "Deorbit";
            this.Deorbit.Size = new System.Drawing.Size(124, 50);
            this.Deorbit.TabIndex = 7;
            this.Deorbit.Text = "Deorbit";
            this.Deorbit.UseVisualStyleBackColor = false;
            this.Deorbit.Click += new System.EventHandler(this.Deorbit_Click);
            // 
            // DeployPayload
            // 
            this.DeployPayload.BackColor = System.Drawing.Color.SeaShell;
            this.DeployPayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeployPayload.Location = new System.Drawing.Point(61, 165);
            this.DeployPayload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeployPayload.Name = "DeployPayload";
            this.DeployPayload.Size = new System.Drawing.Size(142, 50);
            this.DeployPayload.TabIndex = 6;
            this.DeployPayload.Text = "Deploy Payload";
            this.DeployPayload.UseVisualStyleBackColor = false;
            this.DeployPayload.Click += new System.EventHandler(this.button1_Click);
            // 
            // SelectLaunchVehicleComboBox
            // 
            this.SelectLaunchVehicleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectLaunchVehicleComboBox.FormattingEnabled = true;
            this.SelectLaunchVehicleComboBox.Location = new System.Drawing.Point(61, 84);
            this.SelectLaunchVehicleComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SelectLaunchVehicleComboBox.Name = "SelectLaunchVehicleComboBox";
            this.SelectLaunchVehicleComboBox.Size = new System.Drawing.Size(392, 28);
            this.SelectLaunchVehicleComboBox.TabIndex = 5;
            this.SelectLaunchVehicleComboBox.SelectedIndexChanged += new System.EventHandler(this.LaunchVehicleComboBox_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(144, 216);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 259);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Decommission
            // 
            this.Decommission.BackColor = System.Drawing.Color.Red;
            this.Decommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decommission.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Decommission.Location = new System.Drawing.Point(356, 146);
            this.Decommission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Decommission.Name = "Decommission";
            this.Decommission.Size = new System.Drawing.Size(154, 50);
            this.Decommission.TabIndex = 17;
            this.Decommission.Text = "Decommission";
            this.Decommission.UseVisualStyleBackColor = false;
            this.Decommission.Click += new System.EventHandler(this.Decommission_Click);
            // 
            // PayloadDataRichTextBox
            // 
            this.PayloadDataRichTextBox.Location = new System.Drawing.Point(22, 216);
            this.PayloadDataRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayloadDataRichTextBox.Name = "PayloadDataRichTextBox";
            this.PayloadDataRichTextBox.ReadOnly = true;
            this.PayloadDataRichTextBox.Size = new System.Drawing.Size(487, 259);
            this.PayloadDataRichTextBox.TabIndex = 16;
            this.PayloadDataRichTextBox.Text = "";
            this.PayloadDataRichTextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Select Payload";
            // 
            // PayloadTelemetryRichTextBox
            // 
            this.PayloadTelemetryRichTextBox.Location = new System.Drawing.Point(23, 573);
            this.PayloadTelemetryRichTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayloadTelemetryRichTextBox.Name = "PayloadTelemetryRichTextBox";
            this.PayloadTelemetryRichTextBox.ReadOnly = true;
            this.PayloadTelemetryRichTextBox.Size = new System.Drawing.Size(487, 271);
            this.PayloadTelemetryRichTextBox.TabIndex = 15;
            this.PayloadTelemetryRichTextBox.Text = "";
            // 
            // StopData
            // 
            this.StopData.BackColor = System.Drawing.Color.Beige;
            this.StopData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopData.Location = new System.Drawing.Point(385, 482);
            this.StopData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopData.Name = "StopData";
            this.StopData.Size = new System.Drawing.Size(102, 50);
            this.StopData.TabIndex = 10;
            this.StopData.Text = "Stop Data";
            this.StopData.UseVisualStyleBackColor = false;
            this.StopData.Click += new System.EventHandler(this.StopData_Click);
            // 
            // StartData
            // 
            this.StartData.BackColor = System.Drawing.Color.Beige;
            this.StartData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartData.Location = new System.Drawing.Point(37, 484);
            this.StartData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartData.Name = "StartData";
            this.StartData.Size = new System.Drawing.Size(142, 50);
            this.StartData.TabIndex = 10;
            this.StartData.Text = "Start Data";
            this.StartData.UseVisualStyleBackColor = false;
            this.StartData.Click += new System.EventHandler(this.button9_Click);
            // 
            // StopTelemetryPayload
            // 
            this.StopTelemetryPayload.BackColor = System.Drawing.Color.Cornsilk;
            this.StopTelemetryPayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopTelemetryPayload.Location = new System.Drawing.Point(345, 852);
            this.StopTelemetryPayload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StopTelemetryPayload.Name = "StopTelemetryPayload";
            this.StopTelemetryPayload.Size = new System.Drawing.Size(142, 45);
            this.StopTelemetryPayload.TabIndex = 14;
            this.StopTelemetryPayload.Text = "Stop Telemetry";
            this.StopTelemetryPayload.UseVisualStyleBackColor = false;
            this.StopTelemetryPayload.Click += new System.EventHandler(this.StopTelemetryPayload_Click);
            // 
            // StartTelemetryPayload
            // 
            this.StartTelemetryPayload.BackColor = System.Drawing.Color.Beige;
            this.StartTelemetryPayload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTelemetryPayload.Location = new System.Drawing.Point(50, 852);
            this.StartTelemetryPayload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartTelemetryPayload.Name = "StartTelemetryPayload";
            this.StartTelemetryPayload.Size = new System.Drawing.Size(142, 45);
            this.StartTelemetryPayload.TabIndex = 13;
            this.StartTelemetryPayload.Text = "Start Telemetry";
            this.StartTelemetryPayload.UseVisualStyleBackColor = false;
            this.StartTelemetryPayload.Click += new System.EventHandler(this.StartTelemetryPayload_Click);
            // 
            // PayloadComboBox
            // 
            this.PayloadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PayloadComboBox.FormattingEnabled = true;
            this.PayloadComboBox.Location = new System.Drawing.Point(75, 84);
            this.PayloadComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PayloadComboBox.Name = "PayloadComboBox";
            this.PayloadComboBox.Size = new System.Drawing.Size(364, 28);
            this.PayloadComboBox.TabIndex = 10;
            this.PayloadComboBox.SelectedIndexChanged += new System.EventHandler(this.PayloadComboBox_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel7.Location = new System.Drawing.Point(21, 216);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(488, 261);
            this.panel7.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.LaunchVehicle);
            this.panel1.Controls.Add(this.LaunchVehicleComboBox);
            this.panel1.Location = new System.Drawing.Point(340, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1087, 55);
            this.panel1.TabIndex = 11;
            // 
            // LaunchVehicle
            // 
            this.LaunchVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchVehicle.Location = new System.Drawing.Point(602, 5);
            this.LaunchVehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LaunchVehicle.Name = "LaunchVehicle";
            this.LaunchVehicle.Size = new System.Drawing.Size(248, 44);
            this.LaunchVehicle.TabIndex = 8;
            this.LaunchVehicle.Text = "Launch Vehicle";
            this.LaunchVehicle.UseVisualStyleBackColor = true;
            this.LaunchVehicle.Click += new System.EventHandler(this.LaunchVehicle_Click_1);
            // 
            // LaunchVehicleComboBox
            // 
            this.LaunchVehicleComboBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LaunchVehicleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LaunchVehicleComboBox.FormattingEnabled = true;
            this.LaunchVehicleComboBox.Location = new System.Drawing.Point(338, 14);
            this.LaunchVehicleComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LaunchVehicleComboBox.Name = "LaunchVehicleComboBox";
            this.LaunchVehicleComboBox.Size = new System.Drawing.Size(257, 28);
            this.LaunchVehicleComboBox.TabIndex = 12;
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.Orange;
            this.Upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(18, 891);
            this.Upload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(266, 44);
            this.Upload.TabIndex = 0;
            this.Upload.Text = "Upload";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PeachPuff;
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.Upload);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 19);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 992);
            this.panel2.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(18, 541);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 69);
            this.panel5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.Location = new System.Drawing.Point(80, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Waiting";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(18, 514);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(266, 228);
            this.panel6.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(115, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "0";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(18, 205);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(266, 69);
            this.panel3.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(20, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Active Spacecrafts";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(18, 178);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(266, 228);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            // 
            // communicationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1437, 1025);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "communicationform";
            this.Text = "Communicationform";
            this.Load += new System.EventHandler(this.communicationform_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button StopTelemetry;
        private System.Windows.Forms.Button StartTelemetry;
        private System.Windows.Forms.Button Deorbit;
        private System.Windows.Forms.Button DeployPayload;
        private System.Windows.Forms.ComboBox SelectLaunchVehicleComboBox;
        private System.Windows.Forms.Button StopTelemetryPayload;
        private System.Windows.Forms.Button StartTelemetryPayload;
        private System.Windows.Forms.ComboBox PayloadComboBox;
        private System.Windows.Forms.Button StartData;
        private System.Windows.Forms.RichTextBox LauchVehcileTelemetryRichTextBox;
        private System.Windows.Forms.Button StopData;
        private System.Windows.Forms.RichTextBox PayloadTelemetryRichTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox PayloadDataRichTextBox;
        private System.Windows.Forms.Button Decommission;
        private System.Windows.Forms.Button LaunchVehicle;
        private System.Windows.Forms.ComboBox LaunchVehicleComboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel7;
    }
}