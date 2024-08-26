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
            btnSaveStation6 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnSaveStation6
            // 
            btnSaveStation6.Font = new Font("Segoe UI", 10F);
            btnSaveStation6.Location = new Point(191, 489);
            btnSaveStation6.Name = "btnSaveStation6";
            btnSaveStation6.Size = new Size(83, 30);
            btnSaveStation6.TabIndex = 15;
            btnSaveStation6.Text = "GUARDAR";
            btnSaveStation6.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(38, 69);
            label6.Name = "label6";
            label6.Size = new Size(172, 19);
            label6.TabIndex = 17;
            label6.Text = "AYUDA DE CONDUCCION";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(303, 65);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 18;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(btnSaveStation6);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveStation6;
        private Label label6;
        private ComboBox comboBox1;
    }
}