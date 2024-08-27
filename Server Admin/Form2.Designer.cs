namespace Server_Admin
{
    partial class Form2
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
            btnSaveConfig = new Button();
            label6 = new Label();
            cbSteeringHelp = new ComboBox();
            cbBrakingHelp = new ComboBox();
            label1 = new Label();
            cbTractionControl = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbStabilityControl = new ComboBox();
            cbAutoShifting = new ComboBox();
            label4 = new Label();
            cbAntiLockBrakes = new ComboBox();
            label5 = new Label();
            lblStationName = new Label();
            SuspendLayout();
            // 
            // btnSaveConfig
            // 
            btnSaveConfig.Font = new Font("Segoe UI", 10F);
            btnSaveConfig.Location = new Point(194, 319);
            btnSaveConfig.Name = "btnSaveConfig";
            btnSaveConfig.Size = new Size(83, 30);
            btnSaveConfig.TabIndex = 15;
            btnSaveConfig.Text = "GUARDAR";
            btnSaveConfig.UseVisualStyleBackColor = true;
            btnSaveConfig.Click += btnSaveConfig_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(45, 54);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 17;
            label6.Text = "STEERING HELP";
            // 
            // cbSteeringHelp
            // 
            cbSteeringHelp.FormattingEnabled = true;
            cbSteeringHelp.Location = new Point(310, 50);
            cbSteeringHelp.Name = "cbSteeringHelp";
            cbSteeringHelp.Size = new Size(121, 23);
            cbSteeringHelp.TabIndex = 18;
            // 
            // cbBrakingHelp
            // 
            cbBrakingHelp.FormattingEnabled = true;
            cbBrakingHelp.Location = new Point(310, 91);
            cbBrakingHelp.Name = "cbBrakingHelp";
            cbBrakingHelp.Size = new Size(121, 23);
            cbBrakingHelp.TabIndex = 20;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(45, 95);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(102, 19);
            label1.TabIndex = 19;
            label1.Text = "BRAKING HELP";
            // 
            // cbTractionControl
            // 
            cbTractionControl.FormattingEnabled = true;
            cbTractionControl.Location = new Point(310, 222);
            cbTractionControl.Name = "cbTractionControl";
            cbTractionControl.Size = new Size(121, 23);
            cbTractionControl.TabIndex = 22;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(45, 226);
            label2.Name = "label2";
            label2.Size = new Size(141, 19);
            label2.TabIndex = 21;
            label2.Text = "TRACTION CONTROL";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(45, 137);
            label3.Name = "label3";
            label3.Size = new Size(136, 19);
            label3.TabIndex = 21;
            label3.Text = "STABILITY CONTROL";
            // 
            // cbStabilityControl
            // 
            cbStabilityControl.FormattingEnabled = true;
            cbStabilityControl.Location = new Point(310, 133);
            cbStabilityControl.Name = "cbStabilityControl";
            cbStabilityControl.Size = new Size(121, 23);
            cbStabilityControl.TabIndex = 22;
            // 
            // cbAutoShifting
            // 
            cbAutoShifting.FormattingEnabled = true;
            cbAutoShifting.Location = new Point(310, 178);
            cbAutoShifting.Name = "cbAutoShifting";
            cbAutoShifting.Size = new Size(121, 23);
            cbAutoShifting.TabIndex = 24;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(45, 182);
            label4.Name = "label4";
            label4.Size = new Size(108, 19);
            label4.TabIndex = 23;
            label4.Text = "AUTO SHIFTING";
            // 
            // cbAntiLockBrakes
            // 
            cbAntiLockBrakes.FormattingEnabled = true;
            cbAntiLockBrakes.Location = new Point(310, 266);
            cbAntiLockBrakes.Name = "cbAntiLockBrakes";
            cbAntiLockBrakes.Size = new Size(121, 23);
            cbAntiLockBrakes.TabIndex = 26;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(45, 270);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(131, 19);
            label5.TabIndex = 25;
            label5.Text = "ANTI-LOCK BRAKES";
            // 
            // lblStationName
            // 
            lblStationName.Anchor = AnchorStyles.Top;
            lblStationName.AutoSize = true;
            lblStationName.Font = new Font("Segoe UI", 14F);
            lblStationName.Location = new Point(190, 9);
            lblStationName.Name = "lblStationName";
            lblStationName.Size = new Size(94, 25);
            lblStationName.TabIndex = 27;
            lblStationName.Text = "PUESTO 1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(lblStationName);
            Controls.Add(cbAntiLockBrakes);
            Controls.Add(label5);
            Controls.Add(cbAutoShifting);
            Controls.Add(label4);
            Controls.Add(cbStabilityControl);
            Controls.Add(cbTractionControl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbBrakingHelp);
            Controls.Add(label1);
            Controls.Add(cbSteeringHelp);
            Controls.Add(label6);
            Controls.Add(btnSaveConfig);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveConfig;
        private Label label6;
        private ComboBox cbSteeringHelp;
        private ComboBox cbBrakingHelp;
        private Label label1;
        private ComboBox cbTractionControl;
        private Label label2;
        private Label label3;
        private ComboBox cbStabilityControl;
        private ComboBox cbAutoShifting;
        private Label label4;
        private ComboBox cbAntiLockBrakes;
        private Label label5;
        private Label lblStationName;
    }
}