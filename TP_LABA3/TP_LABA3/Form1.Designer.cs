namespace TP_LABA3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblHSV;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TextBox txtRedDelta;
        private System.Windows.Forms.Button btnAddRed;
        private System.Windows.Forms.Button btnSubRed;
        private System.Windows.Forms.TextBox txtGreenDelta;
        private System.Windows.Forms.Button btnAddGreen;
        private System.Windows.Forms.Button btnSubGreen;
        private System.Windows.Forms.TextBox txtBlueDelta;
        private System.Windows.Forms.Button btnAddBlue;
        private System.Windows.Forms.Button btnSubBlue;
        private System.Windows.Forms.TextBox txtSatDelta;
        private System.Windows.Forms.Button btnAddSat;
        private System.Windows.Forms.Button btnSubSat;
        private System.Windows.Forms.TextBox txtValDelta;
        private System.Windows.Forms.Button btnAddVal;
        private System.Windows.Forms.Button btnSubVal;

        /// <summary>
        /// Метод, требуемый для поддержки конструктора — не изменяйте содержимое данного метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHSV = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.panelColor = new System.Windows.Forms.Panel();
            this.txtRedDelta = new System.Windows.Forms.TextBox();
            this.btnAddRed = new System.Windows.Forms.Button();
            this.btnSubRed = new System.Windows.Forms.Button();
            this.txtGreenDelta = new System.Windows.Forms.TextBox();
            this.btnAddGreen = new System.Windows.Forms.Button();
            this.btnSubGreen = new System.Windows.Forms.Button();
            this.txtBlueDelta = new System.Windows.Forms.TextBox();
            this.btnAddBlue = new System.Windows.Forms.Button();
            this.btnSubBlue = new System.Windows.Forms.Button();
            this.txtSatDelta = new System.Windows.Forms.TextBox();
            this.btnAddSat = new System.Windows.Forms.Button();
            this.btnSubSat = new System.Windows.Forms.Button();
            this.txtValDelta = new System.Windows.Forms.TextBox();
            this.btnAddVal = new System.Windows.Forms.Button();
            this.btnSubVal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHSV
            // 
            this.lblHSV.AutoSize = true;
            this.lblHSV.Location = new System.Drawing.Point(77, 101);
            this.lblHSV.Name = "lblHSV";
            this.lblHSV.Size = new System.Drawing.Size(67, 15);
            this.lblHSV.TabIndex = 0;
            this.lblHSV.Text = "HSV(0, 0, 0)";
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(77, 126);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(67, 15);
            this.lblRGB.TabIndex = 1;
            this.lblRGB.Text = "RGB(0, 0, 0)";
            // 
            // panelColor
            // 
            this.panelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColor.Location = new System.Drawing.Point(77, 151);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(100, 100);
            this.panelColor.TabIndex = 2;
            // 
            // txtRedDelta
            // 
            this.txtRedDelta.Location = new System.Drawing.Point(207, 101);
            this.txtRedDelta.Name = "txtRedDelta";
            this.txtRedDelta.Size = new System.Drawing.Size(50, 23);
            this.txtRedDelta.TabIndex = 3;
            this.txtRedDelta.Text = "10";
            // 
            // btnAddRed
            // 
            this.btnAddRed.Location = new System.Drawing.Point(267, 101);
            this.btnAddRed.Name = "btnAddRed";
            this.btnAddRed.Size = new System.Drawing.Size(55, 23);
            this.btnAddRed.TabIndex = 4;
            this.btnAddRed.Text = "+Red";
            this.btnAddRed.UseVisualStyleBackColor = true;
            this.btnAddRed.Click += new System.EventHandler(this.btnAddRed_Click);
            // 
            // btnSubRed
            // 
            this.btnSubRed.Location = new System.Drawing.Point(327, 101);
            this.btnSubRed.Name = "btnSubRed";
            this.btnSubRed.Size = new System.Drawing.Size(55, 23);
            this.btnSubRed.TabIndex = 5;
            this.btnSubRed.Text = "-Red";
            this.btnSubRed.UseVisualStyleBackColor = true;
            this.btnSubRed.Click += new System.EventHandler(this.btnSubRed_Click);
            // 
            // txtGreenDelta
            // 
            this.txtGreenDelta.Location = new System.Drawing.Point(207, 131);
            this.txtGreenDelta.Name = "txtGreenDelta";
            this.txtGreenDelta.Size = new System.Drawing.Size(50, 23);
            this.txtGreenDelta.TabIndex = 6;
            this.txtGreenDelta.Text = "10";
            // 
            // btnAddGreen
            // 
            this.btnAddGreen.Location = new System.Drawing.Point(267, 131);
            this.btnAddGreen.Name = "btnAddGreen";
            this.btnAddGreen.Size = new System.Drawing.Size(55, 23);
            this.btnAddGreen.TabIndex = 7;
            this.btnAddGreen.Text = "+Green";
            this.btnAddGreen.UseVisualStyleBackColor = true;
            this.btnAddGreen.Click += new System.EventHandler(this.btnAddGreen_Click);
            // 
            // btnSubGreen
            // 
            this.btnSubGreen.Location = new System.Drawing.Point(327, 131);
            this.btnSubGreen.Name = "btnSubGreen";
            this.btnSubGreen.Size = new System.Drawing.Size(55, 23);
            this.btnSubGreen.TabIndex = 8;
            this.btnSubGreen.Text = "-Green";
            this.btnSubGreen.UseVisualStyleBackColor = true;
            this.btnSubGreen.Click += new System.EventHandler(this.btnSubGreen_Click);
            // 
            // txtBlueDelta
            // 
            this.txtBlueDelta.Location = new System.Drawing.Point(207, 161);
            this.txtBlueDelta.Name = "txtBlueDelta";
            this.txtBlueDelta.Size = new System.Drawing.Size(50, 23);
            this.txtBlueDelta.TabIndex = 9;
            this.txtBlueDelta.Text = "10";
            // 
            // btnAddBlue
            // 
            this.btnAddBlue.Location = new System.Drawing.Point(267, 161);
            this.btnAddBlue.Name = "btnAddBlue";
            this.btnAddBlue.Size = new System.Drawing.Size(55, 23);
            this.btnAddBlue.TabIndex = 10;
            this.btnAddBlue.Text = "+Blue";
            this.btnAddBlue.UseVisualStyleBackColor = true;
            this.btnAddBlue.Click += new System.EventHandler(this.btnAddBlue_Click);
            // 
            // btnSubBlue
            // 
            this.btnSubBlue.Location = new System.Drawing.Point(327, 161);
            this.btnSubBlue.Name = "btnSubBlue";
            this.btnSubBlue.Size = new System.Drawing.Size(55, 23);
            this.btnSubBlue.TabIndex = 11;
            this.btnSubBlue.Text = "-Blue";
            this.btnSubBlue.UseVisualStyleBackColor = true;
            this.btnSubBlue.Click += new System.EventHandler(this.btnSubBlue_Click);
            // 
            // txtSatDelta
            // 
            this.txtSatDelta.Location = new System.Drawing.Point(207, 191);
            this.txtSatDelta.Name = "txtSatDelta";
            this.txtSatDelta.Size = new System.Drawing.Size(50, 23);
            this.txtSatDelta.TabIndex = 12;
            this.txtSatDelta.Text = "0.1";
            // 
            // btnAddSat
            // 
            this.btnAddSat.Location = new System.Drawing.Point(267, 191);
            this.btnAddSat.Name = "btnAddSat";
            this.btnAddSat.Size = new System.Drawing.Size(55, 23);
            this.btnAddSat.TabIndex = 13;
            this.btnAddSat.Text = "+Sat";
            this.btnAddSat.UseVisualStyleBackColor = true;
            this.btnAddSat.Click += new System.EventHandler(this.btnAddSat_Click);
            // 
            // btnSubSat
            // 
            this.btnSubSat.Location = new System.Drawing.Point(327, 191);
            this.btnSubSat.Name = "btnSubSat";
            this.btnSubSat.Size = new System.Drawing.Size(55, 23);
            this.btnSubSat.TabIndex = 14;
            this.btnSubSat.Text = "-Sat";
            this.btnSubSat.UseVisualStyleBackColor = true;
            this.btnSubSat.Click += new System.EventHandler(this.btnSubSat_Click);
            // 
            // txtValDelta
            // 
            this.txtValDelta.Location = new System.Drawing.Point(207, 221);
            this.txtValDelta.Name = "txtValDelta";
            this.txtValDelta.Size = new System.Drawing.Size(50, 23);
            this.txtValDelta.TabIndex = 15;
            this.txtValDelta.Text = "0.1";
            // 
            // btnAddVal
            // 
            this.btnAddVal.Location = new System.Drawing.Point(267, 221);
            this.btnAddVal.Name = "btnAddVal";
            this.btnAddVal.Size = new System.Drawing.Size(55, 23);
            this.btnAddVal.TabIndex = 16;
            this.btnAddVal.Text = "+Val";
            this.btnAddVal.UseVisualStyleBackColor = true;
            this.btnAddVal.Click += new System.EventHandler(this.btnAddVal_Click);
            // 
            // btnSubVal
            // 
            this.btnSubVal.Location = new System.Drawing.Point(327, 221);
            this.btnSubVal.Name = "btnSubVal";
            this.btnSubVal.Size = new System.Drawing.Size(55, 23);
            this.btnSubVal.TabIndex = 17;
            this.btnSubVal.Text = "-Val";
            this.btnSubVal.UseVisualStyleBackColor = true;
            this.btnSubVal.Click += new System.EventHandler(this.btnSubVal_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.btnSubVal);
            this.Controls.Add(this.btnAddVal);
            this.Controls.Add(this.txtValDelta);
            this.Controls.Add(this.btnSubSat);
            this.Controls.Add(this.btnAddSat);
            this.Controls.Add(this.txtSatDelta);
            this.Controls.Add(this.btnSubBlue);
            this.Controls.Add(this.btnAddBlue);
            this.Controls.Add(this.txtBlueDelta);
            this.Controls.Add(this.btnSubGreen);
            this.Controls.Add(this.btnAddGreen);
            this.Controls.Add(this.txtGreenDelta);
            this.Controls.Add(this.btnSubRed);
            this.Controls.Add(this.btnAddRed);
            this.Controls.Add(this.txtRedDelta);
            this.Controls.Add(this.panelColor);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.lblHSV);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Color Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
