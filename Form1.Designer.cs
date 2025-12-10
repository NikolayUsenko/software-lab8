namespace software_lab8
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnColor1 = new Button();
            btnColor2 = new Button();
            btnStartAnim = new Button();
            btnStopAnim = new Button();
            colorDialog1 = new ColorDialog();
            animationTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            //
            // btnColor1
            //
            btnColor1.Location = new System.Drawing.Point(520, 30);
            btnColor1.Size = new System.Drawing.Size(160, 30);
            btnColor1.Text = "Цвет области 1";
            btnColor1.Click += btnColor1_Click;
            //
            // btnColor2
            //
            btnColor2.Location = new System.Drawing.Point(520, 70);
            btnColor2.Size = new System.Drawing.Size(160, 30);
            btnColor2.Text = "Цвет области 2";
            btnColor2.Click += btnColor2_Click;
            //
            // btnStartAnim
            //
            btnStartAnim.Location = new System.Drawing.Point(520, 120);
            btnStartAnim.Size = new System.Drawing.Size(160, 30);
            btnStartAnim.Text = "Старт анимации";
            btnStartAnim.Click += btnStartAnim_Click;
            //
            // btnStopAnim
            //
            btnStopAnim.Location = new System.Drawing.Point(520, 160);
            btnStopAnim.Size = new System.Drawing.Size(160, 30);
            btnStopAnim.Text = "Стоп анимации";
            btnStopAnim.Click += this.btnStopAnim_Click;
            //
            // animationTimer
            //
            animationTimer.Interval = 300;
            animationTimer.Tick += AnimationTimer_Tick;
            //
            // Form1
            //
            ClientSize = new System.Drawing.Size(750, 550);
            Text = "Индиидуальное задание #1";
            Controls.Add(btnColor1);
            Controls.Add(btnColor2);
            Controls.Add(btnStartAnim);
            Controls.Add(btnStopAnim);
            DoubleBuffered = true;
            MouseMove += Form1_MouseMove;
            MouseDown += Form1_MouseDown;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnStartAnim;
        private System.Windows.Forms.Button btnStopAnim;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer animationTimer;
    }
}
