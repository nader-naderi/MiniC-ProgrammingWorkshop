namespace MyFirstWinFormApp
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
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.loginBtn = new System.Windows.Forms.Button();
			this.lastNameTxtBox = new System.Windows.Forms.TextBox();
			this.firstNameTxtBox = new System.Windows.Forms.TextBox();
			this.titleLbl = new System.Windows.Forms.Label();
			this.creatorLbl = new System.Windows.Forms.Label();
			this.lastnameLbl = new System.Windows.Forms.Label();
			this.firstnameLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(293, 367);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(215, 61);
			this.button1.TabIndex = 0;
			this.button1.Text = "Press Me !";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			// 
			// loginBtn
			// 
			this.loginBtn.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.loginBtn.Location = new System.Drawing.Point(114, 224);
			this.loginBtn.Name = "loginBtn";
			this.loginBtn.Size = new System.Drawing.Size(264, 53);
			this.loginBtn.TabIndex = 0;
			this.loginBtn.Text = "Login";
			this.loginBtn.UseVisualStyleBackColor = true;
			this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
			// 
			// lastNameTxtBox
			// 
			this.lastNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lastNameTxtBox.Location = new System.Drawing.Point(115, 165);
			this.lastNameTxtBox.Multiline = true;
			this.lastNameTxtBox.Name = "lastNameTxtBox";
			this.lastNameTxtBox.Size = new System.Drawing.Size(263, 41);
			this.lastNameTxtBox.TabIndex = 1;
			// 
			// firstNameTxtBox
			// 
			this.firstNameTxtBox.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.firstNameTxtBox.Location = new System.Drawing.Point(114, 110);
			this.firstNameTxtBox.Multiline = true;
			this.firstNameTxtBox.Name = "firstNameTxtBox";
			this.firstNameTxtBox.Size = new System.Drawing.Size(264, 40);
			this.firstNameTxtBox.TabIndex = 1;
			// 
			// titleLbl
			// 
			this.titleLbl.AutoSize = true;
			this.titleLbl.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.titleLbl.Location = new System.Drawing.Point(9, 17);
			this.titleLbl.Name = "titleLbl";
			this.titleLbl.Size = new System.Drawing.Size(267, 51);
			this.titleLbl.TabIndex = 2;
			this.titleLbl.Text = "Member Login";
			// 
			// creatorLbl
			// 
			this.creatorLbl.AutoSize = true;
			this.creatorLbl.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.creatorLbl.Location = new System.Drawing.Point(141, 304);
			this.creatorLbl.Name = "creatorLbl";
			this.creatorLbl.Size = new System.Drawing.Size(198, 25);
			this.creatorLbl.TabIndex = 3;
			this.creatorLbl.Text = "Created by NDRCreates";
			// 
			// lastnameLbl
			// 
			this.lastnameLbl.AutoSize = true;
			this.lastnameLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lastnameLbl.Location = new System.Drawing.Point(2, 176);
			this.lastnameLbl.Name = "lastnameLbl";
			this.lastnameLbl.Size = new System.Drawing.Size(104, 30);
			this.lastnameLbl.TabIndex = 2;
			this.lastnameLbl.Text = "Lastname";
			// 
			// firstnameLbl
			// 
			this.firstnameLbl.AutoSize = true;
			this.firstnameLbl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.firstnameLbl.Location = new System.Drawing.Point(1, 120);
			this.firstnameLbl.Name = "firstnameLbl";
			this.firstnameLbl.Size = new System.Drawing.Size(107, 30);
			this.firstnameLbl.TabIndex = 2;
			this.firstnameLbl.Text = "Firstname";
			// 
			// Form1
			// 
			this.ClientSize = new System.Drawing.Size(390, 366);
			this.Controls.Add(this.creatorLbl);
			this.Controls.Add(this.firstnameLbl);
			this.Controls.Add(this.lastnameLbl);
			this.Controls.Add(this.titleLbl);
			this.Controls.Add(this.firstNameTxtBox);
			this.Controls.Add(this.lastNameTxtBox);
			this.Controls.Add(this.loginBtn);
			this.Name = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button button1;
		private Label label1;
		private Button loginBtn;
		private TextBox lastNameTxtBox;
		private TextBox firstNameTxtBox;
		private Label titleLbl;
		private Label creatorLbl;
		private Label lastnameLbl;
		private Label firstnameLbl;
	}
}