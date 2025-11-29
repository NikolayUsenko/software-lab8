namespace software_lab8
{
    public partial class Form1 : Form
    {
        Color color = Color.Red;
        int mode = 0;
        double dx = 5;
        double x0 = 0.0, xn = 400.00;
        double a = 5, b = 100, p = -0.5, k = 2;
        int equation_index = 0;
        public Form1()
        {
            InitializeComponent();
            comboMode.SelectedIndex = mode;
            txtA.Text = a.ToString();
            txtB.Text = b.ToString();
            txtK.Text = k.ToString();
            txtP.Text = p.ToString();
        }

        private double MyFunc(double x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {

                switch (equation_index)
                {
                    case 0:
                        return a * Math.Pow(x, -p) * Math.Sin(k * x + b);
                        break;
                    case 1:
                        return Math.Pow(Math.Sin(2 * x), 2) + Math.Sin(k * x) + p;
                        break;
                    default: return 0;
                }
            }
        }

        private void btnRedraw_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            k = Convert.ToDouble(txtK.Text);
            p = Convert.ToDouble(txtP.Text);
            panelGraf.Invalidate();
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = color;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                color = dlg.Color;
                panelGraf.Invalidate();
            }
        }

        private void comboMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            mode = ((ComboBox)sender).SelectedIndex;
            panelGraf.Invalidate();
        }

        private void DrawCoordinateSystem(Graphics g)
        {
            int centerX = panelGraf.Width / 2;
            int centerY = panelGraf.Height / 2;

            g.DrawLine(Pens.Black, 0, centerY, panelGraf.Width, centerY);
            g.DrawLine(Pens.Black, centerX, 0, centerX, panelGraf.Height);
        }

        private void DrawFunction(Graphics g, double xScale, double yScale)
        {
            Point? previousPoint = null;
            Pen graphPen = new Pen(color, 2);
            Brush pointBrush = new SolidBrush(color);

            try
            {
                for (double x = x0; x <= xn; x += dx)
                {
                    double y = MyFunc(x);

                    int pixelX = (int)((x - x0) * xScale);
                    int pixelY = (int)(panelGraf.Height / 2 - y * yScale);

                    Point currentPoint = new Point(pixelX, pixelY);

                    if (previousPoint != null)
                    {
                        if (mode == 0)
                        {
                            g.DrawLine(graphPen, previousPoint.Value, currentPoint);
                        }
                        else if (mode == 1)
                        {
                            g.FillEllipse(pointBrush, currentPoint.X - 2, currentPoint.Y - 2, 4, 4);
                        }
                    }

                    previousPoint = currentPoint;
                }
            }
            finally
            {
                graphPen.Dispose();
                pointBrush.Dispose();
            }
        }

        private void panelGraf_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            if (panelGraf.Width <= 0 || panelGraf.Height <= 0)
                return;
            double xScale = panelGraf.Width / 60;
            double yScale = panelGraf.Height / 60;

            DrawCoordinateSystem(g);
            DrawFunction(g, xScale, yScale);
        }

        private void comboBoxChooseEquation_SelectedIndexChanged(object sender, EventArgs e)
        {
            equation_index = comboBoxChooseEquation.SelectedIndex;
        }
    }
}
