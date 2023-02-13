namespace PhoneBook
{
    partial class PhoneBook
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.jobTxtBox = new System.Windows.Forms.TextBox();
            this.ageTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.preBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(174, 104);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(236, 23);
            this.nameTxtBox.TabIndex = 0;
            // 
            // phoneNumberTxtBox
            // 
            this.phoneNumberTxtBox.Location = new System.Drawing.Point(174, 133);
            this.phoneNumberTxtBox.Name = "phoneNumberTxtBox";
            this.phoneNumberTxtBox.Size = new System.Drawing.Size(236, 23);
            this.phoneNumberTxtBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Phone Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jobTxtBox
            // 
            this.jobTxtBox.Location = new System.Drawing.Point(174, 166);
            this.jobTxtBox.Name = "jobTxtBox";
            this.jobTxtBox.Size = new System.Drawing.Size(236, 23);
            this.jobTxtBox.TabIndex = 0;
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.Location = new System.Drawing.Point(174, 195);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(236, 23);
            this.ageTxtBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Job";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Age";
            // 
            // preBtn
            // 
            this.preBtn.Location = new System.Drawing.Point(84, 358);
            this.preBtn.Name = "preBtn";
            this.preBtn.Size = new System.Drawing.Size(75, 47);
            this.preBtn.TabIndex = 4;
            this.preBtn.Text = "previous";
            this.preBtn.UseVisualStyleBackColor = true;
            this.preBtn.Click += new System.EventHandler(this.preBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(346, 358);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 47);
            this.nextBtn.TabIndex = 5;
            this.nextBtn.Text = "next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // PhoneBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.preBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.jobTxtBox);
            this.Controls.Add(this.phoneNumberTxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "PhoneBook";
            this.Text = "PhoneBook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nameTxtBox;
        private TextBox phoneNumberTxtBox;
        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox jobTxtBox;
        private TextBox ageTxtBox;
        private Label label3;
        private Label label4;
        private Button preBtn;
        private Button nextBtn;
    }
}