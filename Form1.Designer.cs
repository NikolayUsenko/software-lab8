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
            MainTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // MainTimer
            // 
            MainTimer.Enabled = true;
            MainTimer.Interval = 25;
            MainTimer.Tick += MainTimer_Tick;
            // 
            // Form1
            // 
            ClientSize = new Size(751, 486);
            Name = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Paint += Form1_Paint;
            ResumeLayout(false);

            #endregion

        }
        private System.Windows.Forms.Timer MainTimer;
    }
}
