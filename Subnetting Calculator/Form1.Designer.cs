namespace Subnetting_Calculator
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
            this.firstOctectTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.scondOctectTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.thirdOctectTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fourthOctectTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maskTxtBox = new System.Windows.Forms.TextBox();
            this.subnettingTypeComboBox = new System.Windows.Forms.ComboBox();
            this.numberRequestedTxtBox = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.resultTxtBox = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Network Adress: ";
            // 
            // firstOctectTxtBox
            // 
            this.firstOctectTxtBox.Location = new System.Drawing.Point(135, 8);
            this.firstOctectTxtBox.MaxLength = 3;
            this.firstOctectTxtBox.Name = "firstOctectTxtBox";
            this.firstOctectTxtBox.Size = new System.Drawing.Size(40, 22);
            this.firstOctectTxtBox.TabIndex = 1;
            this.firstOctectTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstOctectTxtBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = ".";
            // 
            // scondOctectTxtBox
            // 
            this.scondOctectTxtBox.Location = new System.Drawing.Point(199, 8);
            this.scondOctectTxtBox.MaxLength = 3;
            this.scondOctectTxtBox.Name = "scondOctectTxtBox";
            this.scondOctectTxtBox.Size = new System.Drawing.Size(40, 22);
            this.scondOctectTxtBox.TabIndex = 3;
            this.scondOctectTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.scondOctectTxtBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = ".";
            // 
            // thirdOctectTxtBox
            // 
            this.thirdOctectTxtBox.Location = new System.Drawing.Point(263, 8);
            this.thirdOctectTxtBox.MaxLength = 3;
            this.thirdOctectTxtBox.Name = "thirdOctectTxtBox";
            this.thirdOctectTxtBox.Size = new System.Drawing.Size(40, 22);
            this.thirdOctectTxtBox.TabIndex = 5;
            this.thirdOctectTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.thirdOctectTxtBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = ".";
            // 
            // fourthOctectTxtBox
            // 
            this.fourthOctectTxtBox.Location = new System.Drawing.Point(327, 8);
            this.fourthOctectTxtBox.MaxLength = 3;
            this.fourthOctectTxtBox.Name = "fourthOctectTxtBox";
            this.fourthOctectTxtBox.Size = new System.Drawing.Size(40, 22);
            this.fourthOctectTxtBox.TabIndex = 7;
            this.fourthOctectTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fourthOctectTxtBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "/";
            // 
            // maskTxtBox
            // 
            this.maskTxtBox.Location = new System.Drawing.Point(391, 8);
            this.maskTxtBox.MaxLength = 2;
            this.maskTxtBox.Name = "maskTxtBox";
            this.maskTxtBox.Size = new System.Drawing.Size(40, 22);
            this.maskTxtBox.TabIndex = 9;
            this.maskTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskTxtBox_KeyPress);
            // 
            // subnettingTypeComboBox
            // 
            this.subnettingTypeComboBox.FormattingEnabled = true;
            this.subnettingTypeComboBox.Items.AddRange(new object[] {
            "Subnetworks",
            "Hosts"});
            this.subnettingTypeComboBox.Location = new System.Drawing.Point(16, 63);
            this.subnettingTypeComboBox.Name = "subnettingTypeComboBox";
            this.subnettingTypeComboBox.Size = new System.Drawing.Size(112, 24);
            this.subnettingTypeComboBox.TabIndex = 10;
            // 
            // numberRequestedTxtBox
            // 
            this.numberRequestedTxtBox.Location = new System.Drawing.Point(135, 65);
            this.numberRequestedTxtBox.MaxLength = 4;
            this.numberRequestedTxtBox.Name = "numberRequestedTxtBox";
            this.numberRequestedTxtBox.Size = new System.Drawing.Size(40, 22);
            this.numberRequestedTxtBox.TabIndex = 11;
            this.numberRequestedTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberRequestedTxtBox_KeyPress);
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(199, 157);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(149, 36);
            this.calculateBtn.TabIndex = 12;
            this.calculateBtn.Text = "Calculate!";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // resultTxtBox
            // 
            this.resultTxtBox.Location = new System.Drawing.Point(73, 243);
            this.resultTxtBox.Name = "resultTxtBox";
            this.resultTxtBox.ReadOnly = true;
            this.resultTxtBox.Size = new System.Drawing.Size(358, 189);
            this.resultTxtBox.TabIndex = 13;
            this.resultTxtBox.Text = "";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(213, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Export to PDF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultTxtBox);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.numberRequestedTxtBox);
            this.Controls.Add(this.subnettingTypeComboBox);
            this.Controls.Add(this.maskTxtBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fourthOctectTxtBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thirdOctectTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scondOctectTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstOctectTxtBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Subnetting Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstOctectTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox scondOctectTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox thirdOctectTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fourthOctectTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox maskTxtBox;
        private System.Windows.Forms.ComboBox subnettingTypeComboBox;
        private System.Windows.Forms.TextBox numberRequestedTxtBox;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.RichTextBox resultTxtBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}

