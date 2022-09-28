namespace WinFormsHomework_3;

partial class Form1
{
	private System.ComponentModel.IContainer components = null;

	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
			components.Dispose();
		
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	private void InitializeComponent()
	{
			this.Baku = new System.Windows.Forms.Button();
			this.London = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Baku
			// 
			this.Baku.Location = new System.Drawing.Point(676, 66);
			this.Baku.Name = "Baku";
			this.Baku.Size = new System.Drawing.Size(124, 95);
			this.Baku.TabIndex = 1;
			this.Baku.Text = "Baku";
			this.Baku.UseVisualStyleBackColor = true;
			this.Baku.Click += new System.EventHandler(this.Baku_Click);
			// 
			// London
			// 
			this.London.Location = new System.Drawing.Point(2, 59);
			this.London.Name = "London";
			this.London.Size = new System.Drawing.Size(118, 102);
			this.London.TabIndex = 2;
			this.London.Text = "London";
			this.London.UseVisualStyleBackColor = true;
			this.London.Click += new System.EventHandler(this.London_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::WinFormsHomework_3.Properties.Resources.OIP__2_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.London);
			this.Controls.Add(this.Baku);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

	}

	#endregion
	private Button Baku;
	private Button London;
	private Label label1;
}