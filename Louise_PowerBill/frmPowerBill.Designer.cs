namespace Louise_PowerBill
{
    partial class frmPowerBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPowerBill));
            this.lblUsage = new System.Windows.Forms.Label();
            this.lblBill = new System.Windows.Forms.Label();
            this.txtUsage = new System.Windows.Forms.TextBox();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.pnlindustrial = new System.Windows.Forms.Panel();
            this.txtOffPeakUsage = new System.Windows.Forms.TextBox();
            this.txtPeakUsage = new System.Windows.Forms.TextBox();
            this.lblOffPeakUsage = new System.Windows.Forms.Label();
            this.lblPeakUsage = new System.Windows.Forms.Label();
            this.lblCustType = new System.Windows.Forms.Label();
            this.pnlUsage = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblAcctNo = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.lblCustTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtResidential = new System.Windows.Forms.TextBox();
            this.txtCommercial = new System.Windows.Forms.TextBox();
            this.txtIndustrial = new System.Windows.Forms.TextBox();
            this.txtOverall = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlindustrial.SuspendLayout();
            this.pnlUsage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUsage
            // 
            this.lblUsage.AutoSize = true;
            this.lblUsage.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsage.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsage.Location = new System.Drawing.Point(23, 15);
            this.lblUsage.Name = "lblUsage";
            this.lblUsage.Size = new System.Drawing.Size(312, 43);
            this.lblUsage.TabIndex = 20;
            this.lblUsage.Text = "Enter Usage (kWh):";
            // 
            // lblBill
            // 
            this.lblBill.AutoSize = true;
            this.lblBill.BackColor = System.Drawing.SystemColors.Control;
            this.lblBill.Font = new System.Drawing.Font("Trebuchet MS", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.Location = new System.Drawing.Point(316, 799);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(189, 49);
            this.lblBill.TabIndex = 20;
            this.lblBill.Text = "Total Bill:";
            // 
            // txtUsage
            // 
            this.txtUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsage.Location = new System.Drawing.Point(381, 15);
            this.txtUsage.Name = "txtUsage";
            this.txtUsage.Size = new System.Drawing.Size(392, 45);
            this.txtUsage.TabIndex = 2;
            // 
            // txtBill
            // 
            this.txtBill.BackColor = System.Drawing.SystemColors.Info;
            this.txtBill.Enabled = false;
            this.txtBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.Location = new System.Drawing.Point(511, 797);
            this.txtBill.Name = "txtBill";
            this.txtBill.ReadOnly = true;
            this.txtBill.Size = new System.Drawing.Size(361, 49);
            this.txtBill.TabIndex = 6;
            this.txtBill.TabStop = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(345, 896);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(187, 59);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Add";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(538, 896);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(190, 59);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(734, 896);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 59);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResidential.Location = new System.Drawing.Point(170, 286);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(226, 47);
            this.radResidential.TabIndex = 20;
            this.radResidential.Text = "R&esidential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCommercial.Location = new System.Drawing.Point(442, 286);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(237, 47);
            this.radCommercial.TabIndex = 20;
            this.radCommercial.Text = "C&ommercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIndustrial.Location = new System.Drawing.Point(725, 286);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(200, 47);
            this.radIndustrial.TabIndex = 20;
            this.radIndustrial.Text = "I&ndustrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // pnlindustrial
            // 
            this.pnlindustrial.Controls.Add(this.txtOffPeakUsage);
            this.pnlindustrial.Controls.Add(this.txtPeakUsage);
            this.pnlindustrial.Controls.Add(this.lblOffPeakUsage);
            this.pnlindustrial.Controls.Add(this.lblPeakUsage);
            this.pnlindustrial.Location = new System.Drawing.Point(-1, 588);
            this.pnlindustrial.Name = "pnlindustrial";
            this.pnlindustrial.Size = new System.Drawing.Size(1114, 163);
            this.pnlindustrial.TabIndex = 9;
            this.pnlindustrial.Visible = false;
            // 
            // txtOffPeakUsage
            // 
            this.txtOffPeakUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPeakUsage.Location = new System.Drawing.Point(703, 80);
            this.txtOffPeakUsage.Name = "txtOffPeakUsage";
            this.txtOffPeakUsage.Size = new System.Drawing.Size(374, 45);
            this.txtOffPeakUsage.TabIndex = 20;
            // 
            // txtPeakUsage
            // 
            this.txtPeakUsage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakUsage.Location = new System.Drawing.Point(703, 12);
            this.txtPeakUsage.Name = "txtPeakUsage";
            this.txtPeakUsage.Size = new System.Drawing.Size(374, 45);
            this.txtPeakUsage.TabIndex = 20;
            // 
            // lblOffPeakUsage
            // 
            this.lblOffPeakUsage.AutoSize = true;
            this.lblOffPeakUsage.BackColor = System.Drawing.SystemColors.Control;
            this.lblOffPeakUsage.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeakUsage.Location = new System.Drawing.Point(33, 82);
            this.lblOffPeakUsage.Name = "lblOffPeakUsage";
            this.lblOffPeakUsage.Size = new System.Drawing.Size(648, 43);
            this.lblOffPeakUsage.TabIndex = 11;
            this.lblOffPeakUsage.Text = "Enter usage (kWh) during off-peak hours:";
            // 
            // lblPeakUsage
            // 
            this.lblPeakUsage.AutoSize = true;
            this.lblPeakUsage.BackColor = System.Drawing.SystemColors.Control;
            this.lblPeakUsage.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakUsage.Location = new System.Drawing.Point(29, 14);
            this.lblPeakUsage.Name = "lblPeakUsage";
            this.lblPeakUsage.Size = new System.Drawing.Size(592, 43);
            this.lblPeakUsage.TabIndex = 10;
            this.lblPeakUsage.Text = "Enter usage (kWh) during peak hours:";
            // 
            // lblCustType
            // 
            this.lblCustType.AutoSize = true;
            this.lblCustType.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustType.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustType.Location = new System.Drawing.Point(72, 211);
            this.lblCustType.Name = "lblCustType";
            this.lblCustType.Size = new System.Drawing.Size(359, 43);
            this.lblCustType.TabIndex = 10;
            this.lblCustType.Text = "Select Customer Type:";
            // 
            // pnlUsage
            // 
            this.pnlUsage.Controls.Add(this.txtUsage);
            this.pnlUsage.Controls.Add(this.lblUsage);
            this.pnlUsage.Location = new System.Drawing.Point(118, 510);
            this.pnlUsage.Name = "pnlUsage";
            this.pnlUsage.Size = new System.Drawing.Size(820, 72);
            this.pnlUsage.TabIndex = 11;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(867, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 48);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Power Bill";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcctNo.Location = new System.Drawing.Point(500, 362);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(392, 45);
            this.txtAcctNo.TabIndex = 0;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(500, 426);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(392, 45);
            this.txtCustName.TabIndex = 1;
            // 
            // lblAcctNo
            // 
            this.lblAcctNo.AutoSize = true;
            this.lblAcctNo.BackColor = System.Drawing.SystemColors.Control;
            this.lblAcctNo.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNo.Location = new System.Drawing.Point(258, 364);
            this.lblAcctNo.Name = "lblAcctNo";
            this.lblAcctNo.Size = new System.Drawing.Size(204, 43);
            this.lblAcctNo.TabIndex = 15;
            this.lblAcctNo.Text = "Account No:";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustName.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(190, 437);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(272, 43);
            this.lblCustName.TabIndex = 16;
            this.lblCustName.Text = "Customer Name:";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 42;
            this.lstCustomers.Location = new System.Drawing.Point(1149, 119);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(781, 466);
            this.lstCustomers.TabIndex = 17;
            // 
            // lblCustTotal
            // 
            this.lblCustTotal.AutoSize = true;
            this.lblCustTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblCustTotal.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustTotal.Location = new System.Drawing.Point(1141, 602);
            this.lblCustTotal.Name = "lblCustTotal";
            this.lblCustTotal.Size = new System.Drawing.Size(377, 43);
            this.lblCustTotal.TabIndex = 18;
            this.lblCustTotal.Text = "Total No. of Customers:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 43);
            this.label2.TabIndex = 19;
            this.label2.Text = "Residential:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 43);
            this.label3.TabIndex = 20;
            this.label3.Text = "Commercial:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(189, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 43);
            this.label4.TabIndex = 21;
            this.label4.Text = "Industrial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 43);
            this.label5.TabIndex = 22;
            this.label5.Text = "Overall Total:";
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.Info;
            this.txtCount.Enabled = false;
            this.txtCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.ForeColor = System.Drawing.SystemColors.Info;
            this.txtCount.Location = new System.Drawing.Point(1564, 602);
            this.txtCount.Name = "txtCount";
            this.txtCount.ReadOnly = true;
            this.txtCount.Size = new System.Drawing.Size(331, 45);
            this.txtCount.TabIndex = 23;
            // 
            // txtResidential
            // 
            this.txtResidential.BackColor = System.Drawing.SystemColors.Info;
            this.txtResidential.Enabled = false;
            this.txtResidential.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResidential.Location = new System.Drawing.Point(415, 56);
            this.txtResidential.Name = "txtResidential";
            this.txtResidential.ReadOnly = true;
            this.txtResidential.Size = new System.Drawing.Size(331, 45);
            this.txtResidential.TabIndex = 24;
            // 
            // txtCommercial
            // 
            this.txtCommercial.BackColor = System.Drawing.SystemColors.Info;
            this.txtCommercial.Enabled = false;
            this.txtCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommercial.Location = new System.Drawing.Point(415, 114);
            this.txtCommercial.Name = "txtCommercial";
            this.txtCommercial.ReadOnly = true;
            this.txtCommercial.Size = new System.Drawing.Size(331, 45);
            this.txtCommercial.TabIndex = 25;
            // 
            // txtIndustrial
            // 
            this.txtIndustrial.BackColor = System.Drawing.SystemColors.Info;
            this.txtIndustrial.Enabled = false;
            this.txtIndustrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndustrial.Location = new System.Drawing.Point(415, 171);
            this.txtIndustrial.Name = "txtIndustrial";
            this.txtIndustrial.ReadOnly = true;
            this.txtIndustrial.Size = new System.Drawing.Size(331, 45);
            this.txtIndustrial.TabIndex = 26;
            // 
            // txtOverall
            // 
            this.txtOverall.BackColor = System.Drawing.SystemColors.Info;
            this.txtOverall.Enabled = false;
            this.txtOverall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverall.Location = new System.Drawing.Point(415, 246);
            this.txtOverall.Name = "txtOverall";
            this.txtOverall.ReadOnly = true;
            this.txtOverall.Size = new System.Drawing.Size(331, 45);
            this.txtOverall.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOverall);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtIndustrial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCommercial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtResidential);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1149, 668);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 309);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Charges";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 49);
            this.label1.TabIndex = 29;
            this.label1.Text = "Add Customer Charge";
            // 
            // frmPowerBill
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(2088, 1083);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCustTotal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblAcctNo);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtAcctNo);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.pnlUsage);
            this.Controls.Add(this.lblCustType);
            this.Controls.Add(this.pnlindustrial);
            this.Controls.Add(this.radIndustrial);
            this.Controls.Add(this.radCommercial);
            this.Controls.Add(this.radResidential);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.lblBill);
            this.Name = "frmPowerBill";
            this.Text = "Power Bill Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlindustrial.ResumeLayout(false);
            this.pnlindustrial.PerformLayout();
            this.pnlUsage.ResumeLayout(false);
            this.pnlUsage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsage;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.TextBox txtUsage;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.Panel pnlindustrial;
        private System.Windows.Forms.Label lblOffPeakUsage;
        private System.Windows.Forms.Label lblPeakUsage;
        private System.Windows.Forms.TextBox txtOffPeakUsage;
        private System.Windows.Forms.TextBox txtPeakUsage;
        private System.Windows.Forms.Label lblCustType;
        private System.Windows.Forms.Panel pnlUsage;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAcctNo;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblAcctNo;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label lblCustTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtResidential;
        private System.Windows.Forms.TextBox txtCommercial;
        private System.Windows.Forms.TextBox txtIndustrial;
        private System.Windows.Forms.TextBox txtOverall;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}

