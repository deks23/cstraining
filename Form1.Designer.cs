namespace WindowsFormsApplication1
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
            this.ZabawkiDoDodania = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.DodaneZabawki = new System.Windows.Forms.ListBox();
            this.SpeedText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.IncreaseButton = new System.Windows.Forms.Button();
            this.DecreaseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ZabawkiDoDodania
            // 
            this.ZabawkiDoDodania.FormattingEnabled = true;
            this.ZabawkiDoDodania.Location = new System.Drawing.Point(26, 58);
            this.ZabawkiDoDodania.Name = "ZabawkiDoDodania";
            this.ZabawkiDoDodania.Size = new System.Drawing.Size(79, 95);
            this.ZabawkiDoDodania.TabIndex = 0;
            this.ZabawkiDoDodania.SelectedIndexChanged += new System.EventHandler(this.ZabawkiDoDodania_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(258, 77);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DodaneZabawki
            // 
            this.DodaneZabawki.FormattingEnabled = true;
            this.DodaneZabawki.Location = new System.Drawing.Point(361, 58);
            this.DodaneZabawki.Name = "DodaneZabawki";
            this.DodaneZabawki.Size = new System.Drawing.Size(120, 95);
            this.DodaneZabawki.TabIndex = 2;
            this.DodaneZabawki.SelectedIndexChanged += new System.EventHandler(this.DodaneZabawki_SelectedIndexChanged);
            // 
            // SpeedText
            // 
            this.SpeedText.Location = new System.Drawing.Point(124, 33);
            this.SpeedText.Name = "SpeedText";
            this.SpeedText.Size = new System.Drawing.Size(100, 20);
            this.SpeedText.TabIndex = 3;
            this.SpeedText.TextChanged += new System.EventHandler(this.SpeedText_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IncreaseButton);
            this.groupBox1.Controls.Add(this.DecreaseButton);
            this.groupBox1.Controls.Add(this.SpeedText);
            this.groupBox1.Location = new System.Drawing.Point(693, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // IncreaseButton
            // 
            this.IncreaseButton.Location = new System.Drawing.Point(240, 30);
            this.IncreaseButton.Name = "IncreaseButton";
            this.IncreaseButton.Size = new System.Drawing.Size(75, 23);
            this.IncreaseButton.TabIndex = 5;
            this.IncreaseButton.Text = "+";
            this.IncreaseButton.UseVisualStyleBackColor = true;
            this.IncreaseButton.Click += new System.EventHandler(this.IncreaseButton_Click);
            // 
            // DecreaseButton
            // 
            this.DecreaseButton.Location = new System.Drawing.Point(6, 30);
            this.DecreaseButton.Name = "DecreaseButton";
            this.DecreaseButton.Size = new System.Drawing.Size(75, 23);
            this.DecreaseButton.TabIndex = 4;
            this.DecreaseButton.Text = "-";
            this.DecreaseButton.UseVisualStyleBackColor = true;
            this.DecreaseButton.Click += new System.EventHandler(this.DecreaseButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 680);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DodaneZabawki);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ZabawkiDoDodania);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ZabawkiDoDodania;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox DodaneZabawki;
        private System.Windows.Forms.TextBox SpeedText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button IncreaseButton;
        private System.Windows.Forms.Button DecreaseButton;
    }
}

