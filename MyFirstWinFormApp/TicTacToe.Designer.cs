namespace MyFirstWinFormApp
{
	partial class TicTacToe
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
			this.cell_00 = new System.Windows.Forms.Button();
			this.cell_10 = new System.Windows.Forms.Button();
			this.cell_01 = new System.Windows.Forms.Button();
			this.cell_11 = new System.Windows.Forms.Button();
			this.cell_20 = new System.Windows.Forms.Button();
			this.cell_21 = new System.Windows.Forms.Button();
			this.cell_02 = new System.Windows.Forms.Button();
			this.cell_12 = new System.Windows.Forms.Button();
			this.cell_22 = new System.Windows.Forms.Button();
			this.turnsLbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// cell_00
			// 
			this.cell_00.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cell_00.Location = new System.Drawing.Point(42, 55);
			this.cell_00.Name = "cell_00";
			this.cell_00.Size = new System.Drawing.Size(76, 67);
			this.cell_00.TabIndex = 0;
			this.cell_00.UseVisualStyleBackColor = true;
			this.cell_00.Click += new System.EventHandler(this.cell_00_Click);
			// 
			// cell_10
			// 
			this.cell_10.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cell_10.Location = new System.Drawing.Point(124, 55);
			this.cell_10.Name = "cell_10";
			this.cell_10.Size = new System.Drawing.Size(76, 67);
			this.cell_10.TabIndex = 0;
			this.cell_10.UseVisualStyleBackColor = true;
			this.cell_10.Click += new System.EventHandler(this.cell_10_Click);
			// 
			// cell_01
			// 
			this.cell_01.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cell_01.Location = new System.Drawing.Point(42, 128);
			this.cell_01.Name = "cell_01";
			this.cell_01.Size = new System.Drawing.Size(76, 67);
			this.cell_01.TabIndex = 0;
			this.cell_01.UseVisualStyleBackColor = true;
			this.cell_01.Click += new System.EventHandler(this.cell_01_Click);
			// 
			// cell_11
			// 
			this.cell_11.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cell_11.Location = new System.Drawing.Point(124, 128);
			this.cell_11.Name = "cell_11";
			this.cell_11.Size = new System.Drawing.Size(76, 67);
			this.cell_11.TabIndex = 0;
			this.cell_11.UseVisualStyleBackColor = true;
			this.cell_11.Click += new System.EventHandler(this.cell_11_Click);
			// 
			// cell_20
			// 
			this.cell_20.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cell_20.Location = new System.Drawing.Point(206, 55);
			this.cell_20.Name = "cell_20";
			this.cell_20.Size = new System.Drawing.Size(76, 67);
			this.cell_20.TabIndex = 0;
			this.cell_20.UseVisualStyleBackColor = true;
			this.cell_20.Click += new System.EventHandler(this.cell_20_Click);
			// 
			// cell_21
			// 
			this.cell_21.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cell_21.Location = new System.Drawing.Point(206, 128);
			this.cell_21.Name = "cell_21";
			this.cell_21.Size = new System.Drawing.Size(76, 67);
			this.cell_21.TabIndex = 0;
			this.cell_21.UseVisualStyleBackColor = true;
			this.cell_21.Click += new System.EventHandler(this.cell_21_Click);
			// 
			// cell_02
			// 
			this.cell_02.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cell_02.Location = new System.Drawing.Point(42, 201);
			this.cell_02.Name = "cell_02";
			this.cell_02.Size = new System.Drawing.Size(76, 67);
			this.cell_02.TabIndex = 0;
			this.cell_02.UseVisualStyleBackColor = true;
			this.cell_02.Click += new System.EventHandler(this.cell_02_Click);
			// 
			// cell_12
			// 
			this.cell_12.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cell_12.Location = new System.Drawing.Point(124, 201);
			this.cell_12.Name = "cell_12";
			this.cell_12.Size = new System.Drawing.Size(76, 67);
			this.cell_12.TabIndex = 0;
			this.cell_12.UseVisualStyleBackColor = true;
			this.cell_12.Click += new System.EventHandler(this.cell_12_Click);
			// 
			// cell_22
			// 
			this.cell_22.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cell_22.Location = new System.Drawing.Point(206, 201);
			this.cell_22.Name = "cell_22";
			this.cell_22.Size = new System.Drawing.Size(76, 67);
			this.cell_22.TabIndex = 0;
			this.cell_22.UseVisualStyleBackColor = true;
			this.cell_22.Click += new System.EventHandler(this.cell_22_Click);
			// 
			// turnsLbl
			// 
			this.turnsLbl.AutoSize = true;
			this.turnsLbl.Location = new System.Drawing.Point(42, 296);
			this.turnsLbl.Name = "turnsLbl";
			this.turnsLbl.Size = new System.Drawing.Size(40, 15);
			this.turnsLbl.TabIndex = 1;
			this.turnsLbl.Text = "Turn : ";
			// 
			// TicTacToe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 450);
			this.Controls.Add(this.turnsLbl);
			this.Controls.Add(this.cell_22);
			this.Controls.Add(this.cell_21);
			this.Controls.Add(this.cell_12);
			this.Controls.Add(this.cell_02);
			this.Controls.Add(this.cell_11);
			this.Controls.Add(this.cell_01);
			this.Controls.Add(this.cell_20);
			this.Controls.Add(this.cell_10);
			this.Controls.Add(this.cell_00);
			this.Name = "TicTacToe";
			this.Text = "TicTacToe";
			this.Load += new System.EventHandler(this.TicTacToe_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button cell_00;
		private Button cell_10;
		private Button cell_01;
		private Button cell_11;
		private Button cell_20;
		private Button cell_21;
		private Button cell_02;
		private Button cell_12;
		private Button cell_22;
		private Label turnsLbl;
	}
}