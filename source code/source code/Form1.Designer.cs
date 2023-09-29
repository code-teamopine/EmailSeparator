namespace SMTPProvider
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailPath = new System.Windows.Forms.TextBox();
            this.rdTypeThree = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.rdTypeTwo = new System.Windows.Forms.RadioButton();
            this.rdTypeOne = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(478, 69);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Upload";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 218);
            this.textBox1.TabIndex = 3;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email SMTP Provider Tab";
            // 
            // txtEmailPath
            // 
            this.txtEmailPath.Location = new System.Drawing.Point(175, 71);
            this.txtEmailPath.Name = "txtEmailPath";
            this.txtEmailPath.ReadOnly = true;
            this.txtEmailPath.Size = new System.Drawing.Size(271, 20);
            this.txtEmailPath.TabIndex = 5;
            // 
            // rdTypeThree
            // 
            this.rdTypeThree.AutoSize = true;
            this.rdTypeThree.Location = new System.Drawing.Point(175, 113);
            this.rdTypeThree.Name = "rdTypeThree";
            this.rdTypeThree.Size = new System.Drawing.Size(195, 17);
            this.rdTypeThree.TabIndex = 6;
            this.rdTypeThree.TabStop = true;
            this.rdTypeThree.Text = "smtp.xxx.com:xxx@xxx.com:pass:57";
            this.rdTypeThree.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(553, 68);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // rdTypeTwo
            // 
            this.rdTypeTwo.AutoSize = true;
            this.rdTypeTwo.Location = new System.Drawing.Point(377, 113);
            this.rdTypeTwo.Name = "rdTypeTwo";
            this.rdTypeTwo.Size = new System.Drawing.Size(99, 17);
            this.rdTypeTwo.TabIndex = 8;
            this.rdTypeTwo.TabStop = true;
            this.rdTypeTwo.Text = "Email;Password";
            this.rdTypeTwo.UseVisualStyleBackColor = true;
            // 
            // rdTypeOne
            // 
            this.rdTypeOne.AutoSize = true;
            this.rdTypeOne.Location = new System.Drawing.Point(497, 113);
            this.rdTypeOne.Name = "rdTypeOne";
            this.rdTypeOne.Size = new System.Drawing.Size(50, 17);
            this.rdTypeOne.TabIndex = 9;
            this.rdTypeOne.TabStop = true;
            this.rdTypeOne.Text = "Email";
            this.rdTypeOne.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rdTypeOne);
            this.Controls.Add(this.rdTypeTwo);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.rdTypeThree);
            this.Controls.Add(this.txtEmailPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailPath;
        private System.Windows.Forms.RadioButton rdTypeThree;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RadioButton rdTypeTwo;
        private System.Windows.Forms.RadioButton rdTypeOne;
    }
}

