namespace TP_LABA2_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Task = new System.Windows.Forms.Label();
            this.txtFirstWord = new System.Windows.Forms.TextBox();
            this.txtSecondWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Task
            // 
            this.Task.AutoSize = true;
            this.Task.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Task.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Task.Location = new System.Drawing.Point(29, 33);
            this.Task.MaximumSize = new System.Drawing.Size(750, 500);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(748, 47);
            this.Task.TabIndex = 0;
            this.Task.Text = resources.GetString("Task.Text");
            this.Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFirstWord
            // 
            this.txtFirstWord.Location = new System.Drawing.Point(299, 163);
            this.txtFirstWord.Name = "txtFirstWord";
            this.txtFirstWord.Size = new System.Drawing.Size(200, 23);
            this.txtFirstWord.TabIndex = 1;
            // 
            // txtSecondWord
            // 
            this.txtSecondWord.Location = new System.Drawing.Point(299, 243);
            this.txtSecondWord.Name = "txtSecondWord";
            this.txtSecondWord.Size = new System.Drawing.Size(200, 23);
            this.txtSecondWord.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(335, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите первое слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите второе слово";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(356, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Найти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecondWord);
            this.Controls.Add(this.txtFirstWord);
            this.Controls.Add(this.Task);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Task;
        private TextBox txtFirstWord;
        private TextBox txtSecondWord;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}