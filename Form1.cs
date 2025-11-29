namespace software_lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            MainTimer.Start();
            this.Paint += Form1_Paint;

        }


        Point pos = new Point(100, 100);
        private int R = 50;
        double T = 0;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            gr.DrawEllipse(new Pen(Color.Blue, 10), pos.X - R, pos.Y - R, 2 * R, 2 * R);
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            T += 0.1;
            pos.X = (int)(300 + 150 * Math.Sin(T));
            pos.Y = (int)(300 + 100 * Math.Cos(T));
            this.Invalidate();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainTimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
