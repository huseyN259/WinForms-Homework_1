namespace WinFormsHomework_2;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}

	private void label1_MouseHover(object sender, EventArgs e)
	{
		if (sender is Label label1)
		{
			label1.Location = new Point(Random.Shared.Next(Width - label1.Width), Random.Shared.Next(Height - label1.Height));

			Text = label1.Location.ToString();
		}
	}

	private void label1_MouseMove(object sender, MouseEventArgs e) => Text = e.Location.ToString();
}