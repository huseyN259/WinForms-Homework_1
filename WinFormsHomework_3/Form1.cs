using WinFormsHomework_3.Properties;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsHomework_3;

public partial class Form1 : Form
{
	enum Cities { Baku, London };

	public DateTime CurrentTime;

	public Form1()
	{
		InitializeComponent();
		Timer();
		ChangeCity(Cities.Baku);
	}

	private void Timer()
	{
		Timer timer = new Timer();
		timer.Interval = 1000;
		timer.Tick += Timer_Tick;
		timer.Start();
	}

	private void Timer_Tick(object? sender, EventArgs e)
	{
		CurrentTime = CurrentTime.AddSeconds(1);
		label1.Text = CurrentTime.ToLongTimeString();
	}

	void ChangeCity(Cities city)
	{
		CurrentTime = DateTime.UtcNow.AddHours((int)city);

		switch (city)
		{
			case Cities.Baku:
				BackgroundImage = Resources.OIP__1_;
				break;
			case Cities.London:
				BackgroundImage = Resources.OIP__2_;
				break;
			default:
				break;
		}

		BackgroundImageLayout = ImageLayout.Zoom;
	}

	private void London_Click(object sender, EventArgs e) => ChangeCity(Cities.London);

	private void Baku_Click(object sender, EventArgs e) => ChangeCity(Cities.Baku);
}