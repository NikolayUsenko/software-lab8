using System.Drawing.Drawing2D;

namespace software_lab8
{
    public partial class Form1 : Form
    {
        private Color colorRight = Color.Gray;
        private Color colorTop = Color.Gray;
        private Color hoverColor = Color.Orange;

        private bool hoverRight = false;
        private bool hoverTop = false;

        private Point axisXPos = new Point(460, 255);
        private Point axisYPos = new Point(220, 40);

        private bool dragX = false, dragY = false;
        private bool animToggle = false;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int cx = 250;
            int cy = 250;
            float scale = 60f;

            // Радиусы
            float R_outer = 2f * scale;
            float R_inner = 1f * scale;

            // Окружности
            RectangleF circleMain = new RectangleF(cx - R_outer, cy - R_outer, R_outer * 2, R_outer * 2);
            RectangleF circleInner = new RectangleF(cx - R_inner, cy - R_inner, R_inner * 2, R_inner * 2);
            RectangleF circleShifted = new RectangleF(cx - R_outer + scale, cy - R_outer, R_outer * 2, R_outer * 2);

            // Рисование окружностей
            g.DrawEllipse(Pens.Black, circleMain);
            g.DrawEllipse(Pens.Black, circleInner);
            g.DrawEllipse(Pens.Black, circleShifted);

            // Рисование осей
            g.DrawLine(Pens.Black, 0, cy, 500, cy);
            g.DrawLine(Pens.Black, cx, 0, cx, 500);

            // Рисование прямой
            g.DrawLine(new Pen(Color.Black, 2), cx - 300, cy + 300, cx + 300, cy - 300);

            // Закрашенные области
            DrawFilledRegions(g, cx, cy, scale);

            // Рисование подписей
            g.DrawString("X", Font, Brushes.Black, axisXPos);
            g.DrawString("Y", Font, Brushes.Black, axisYPos);
        }

        private void DrawFilledRegions(Graphics g, int cx, int cy, float scale)
        {
            SolidBrush brRight = new SolidBrush(hoverRight ? hoverColor : colorRight);
            SolidBrush brTop = new SolidBrush(hoverTop ? hoverColor : colorTop);

            for (int px = 0; px < Width; px++)
            {
                for (int py = 0; py < Height; py++)
                {
                    float x = (px - cx) / scale;
                    float y = (cy - py) / scale;

                    bool inMain = x * x + y * y <= 4;
                    bool inShifted = (x - 1) * (x - 1) + y * y <= 4;
                    bool inInner = x * x + y * y <= 1;
                    bool belowLine = y <= x;

                    bool rightRegion = x >= 0 && y >= 0 && !inMain && inShifted && !inInner && belowLine;
                    bool topRegion   = y >= 0 && x <= 0 && !inInner && inShifted && inMain;

                    if (rightRegion)
                        g.FillRectangle(brRight, px, py, 1, 1);

                    if (topRegion)
                        g.FillRectangle(brTop, px, py, 1, 1);
                }
            }

            brRight.Dispose();
            brTop.Dispose();
        }

        // Наведение и перетаскивание
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int cx = 250;
            int cy = 250;
            float scale = 60f;

            if (dragX)
            {
                axisXPos = e.Location;
                Invalidate();
                return;
            }

            if (dragY)
            {
                axisYPos = e.Location;
                Invalidate();
                return;
            }

            float x = (e.X - cx) / scale;
            float y = (cy - e.Y) / scale;

            bool inMain = x * x + y * y <= 4;
            bool inShifted = (x - 1) * (x - 1) + y * y <= 4;
            bool inInner = x * x + y * y <= 1;
            bool belowLine = y <= x;

            hoverRight = x >= 0 && y >= 0 && !inMain && inShifted && !inInner && belowLine;
            hoverTop   = y >= 0 && x <= 0 && !inInner && inShifted && inMain;

            Invalidate();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (new Rectangle(axisXPos, new Size(20, 20)).Contains(e.Location))
                dragX = true;

            if (new Rectangle(axisYPos, new Size(20, 20)).Contains(e.Location))
                dragY = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            dragX = false;
            dragY = false;
        }

        // Выбор цвета
        private void btnColor1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorRight = colorDialog1.Color;
                Invalidate();
            }
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                colorTop = colorDialog1.Color;
                Invalidate();
            }
        }

        // Анимация
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            hoverColor = animToggle ? Color.Red : Color.Blue;
            animToggle = !animToggle;
            Invalidate();
        }

        private void btnStartAnim_Click(object sender, EventArgs e)
        {
            animationTimer.Start();
        }

        private void btnStopAnim_Click(object sender, EventArgs e)
        {
            animationTimer.Stop();
        }
    }
}
