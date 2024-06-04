namespace FaizOraniHesaplama
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
			dtpKaza = new DateTimePicker();
			dtpDava = new DateTimePicker();
			label1 = new Label();
			label2 = new Label();
			textBox1 = new TextBox();
			label3 = new Label();
			lblSonuc = new Label();
			btnHesapla = new Button();
			SuspendLayout();
			// 
			// dtpKaza
			// 
			dtpKaza.Format = DateTimePickerFormat.Short;
			dtpKaza.Location = new Point(138, 57);
			dtpKaza.Name = "dtpKaza";
			dtpKaza.Size = new Size(250, 27);
			dtpKaza.TabIndex = 0;
			dtpKaza.ValueChanged += dtpKaza_ValueChanged;
			// 
			// dtpDava
			// 
			dtpDava.Format = DateTimePickerFormat.Short;
			dtpDava.Location = new Point(141, 109);
			dtpDava.Name = "dtpDava";
			dtpDava.Size = new Size(247, 27);
			dtpDava.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(48, 62);
			label1.Name = "label1";
			label1.Size = new Size(80, 20);
			label1.TabIndex = 2;
			label1.Text = "Kaza Tarihi";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(48, 114);
			label2.Name = "label2";
			label2.Size = new Size(86, 20);
			label2.TabIndex = 3;
			label2.Text = "Dava Tarihi ";
			// 
			// textBox1
			// 
			textBox1.Location = new Point(141, 158);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(247, 27);
			textBox1.TabIndex = 4;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(24, 161);
			label3.Name = "label3";
			label3.Size = new Size(110, 20);
			label3.TabIndex = 5;
			label3.Text = "Tazminat Tutarı";
			// 
			// lblSonuc
			// 
			lblSonuc.AutoSize = true;
			lblSonuc.Location = new Point(255, 220);
			lblSonuc.Name = "lblSonuc";
			lblSonuc.Size = new Size(50, 20);
			lblSonuc.TabIndex = 6;
			lblSonuc.Text = "label4";
			// 
			// btnHesapla
			// 
			btnHesapla.Location = new Point(432, 97);
			btnHesapla.Name = "btnHesapla";
			btnHesapla.Size = new Size(149, 55);
			btnHesapla.TabIndex = 7;
			btnHesapla.Text = "Hesapla";
			btnHesapla.UseVisualStyleBackColor = true;
			btnHesapla.Click += btnHesapla_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(642, 273);
			Controls.Add(btnHesapla);
			Controls.Add(lblSonuc);
			Controls.Add(label3);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dtpDava);
			Controls.Add(dtpKaza);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dtpKaza;
		private DateTimePicker dtpDava;
		private Label label1;
		private Label label2;
		private TextBox textBox1;
		private Label label3;
		private Label lblSonuc;
		private Button btnHesapla;
	}
}
