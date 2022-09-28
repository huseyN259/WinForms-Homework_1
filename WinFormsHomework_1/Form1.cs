namespace WinFormsHomework_1;

public partial class Form1 : Form
{
	Bitmap bitmap;
	Graphics g;
	Point point;
	Pen pen = new Pen(Color.Crimson, 5);

	int width = default, height = default, move = default;

	private void Form1_MouseDown(object sender, MouseEventArgs e)
	{
		paint = true;
		point = new Point(e.X, e.Y);
	}

	private void Form1_MouseUp(object sender, MouseEventArgs e)
	{
		if (width < 20 || height < 20)
			MessageBox.Show("Width or Heigth can't be lower minimum value", "Alert");
		else
		{
			int[] randomColors = { Random.Shared.Next(255), Random.Shared.Next(255), Random.Shared.Next(255) };

			Label label = new Label()
			{
				BackColor = Color.FromArgb(randomColors[0], randomColors[2], randomColors[1]),
				ForeColor = Color.FromArgb(randomColors[2], randomColors[1], randomColors[0]),
				Location = new Point(point.X, point.Y),
				AutoSize = false,
				Width = width,
				Height = height,
				Text = move++.ToString(),
				Font = new Font("HUSEYN", move < 10 ? 20 : 10, FontStyle.Italic),
			};

			label.MouseClick += label1_MouseClick;
			label.MouseDoubleClick += label1_MouseDoubleClick;
		}
	}

	private void Form1_MouseMove(object sender, MouseEventArgs e)
	{
		if (paint)
		{
			width = e.X - point.X;
			height = e.Y - point.Y;

			this.Refresh();
		}
	}

	private void Form1_Paint(object sender, PaintEventArgs e)
	{
		Graphics graphics = e.Graphics;

		if (paint)
			graphics.DrawRectangle(pen, point.X, point.Y, width, height);
		else
			graphics.Clear(Color.White);
	}

	private void label1_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Label? newLabel = sender as Label;

			this.Text = $"Label {newLabel?.Text} [Width : {newLabel?.Width.ToString()} Height : {newLabel?.Height.ToString()}]";
		}
	}

	private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			Controls.Remove(sender as Label);
	}

	bool paint = false;

	public Form1()
	{
		InitializeComponent();

		bitmap = new Bitmap(Width, Height);
		g = Graphics.FromImage(bitmap);

		this.BackgroundImage = bitmap;
	}
}