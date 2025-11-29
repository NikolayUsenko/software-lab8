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
            txtA = new TextBox();
            txtP = new TextBox();
            txtK = new TextBox();
            txtB = new TextBox();
            btnChooseColor = new Button();
            comboMode = new ComboBox();
            panelGraf = new Panel();
            btnRedraw = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBoxChooseEquation = new ComboBox();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(48, 87);
            txtA.Margin = new Padding(2);
            txtA.Name = "txtA";
            txtA.Size = new Size(64, 27);
            txtA.TabIndex = 0;
            txtA.Tag = "";
            // 
            // txtP
            // 
            txtP.Location = new Point(159, 87);
            txtP.Margin = new Padding(2);
            txtP.Name = "txtP";
            txtP.Size = new Size(64, 27);
            txtP.TabIndex = 1;
            // 
            // txtK
            // 
            txtK.Location = new Point(48, 117);
            txtK.Margin = new Padding(2);
            txtK.Name = "txtK";
            txtK.Size = new Size(64, 27);
            txtK.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(159, 117);
            txtB.Margin = new Padding(2);
            txtB.Name = "txtB";
            txtB.Size = new Size(64, 27);
            txtB.TabIndex = 3;
            // 
            // btnChooseColor
            // 
            btnChooseColor.Location = new Point(387, 85);
            btnChooseColor.Margin = new Padding(2);
            btnChooseColor.Name = "btnChooseColor";
            btnChooseColor.Size = new Size(90, 27);
            btnChooseColor.TabIndex = 4;
            btnChooseColor.Text = "...";
            btnChooseColor.UseVisualStyleBackColor = true;
            btnChooseColor.Click += btnChooseColor_Click;
            // 
            // comboMode
            // 
            comboMode.FormattingEnabled = true;
            comboMode.Items.AddRange(new object[] { "Линия", "Точки" });
            comboMode.Location = new Point(387, 117);
            comboMode.Margin = new Padding(2);
            comboMode.Name = "comboMode";
            comboMode.Size = new Size(168, 28);
            comboMode.TabIndex = 5;
            comboMode.SelectedIndexChanged += comboMode_SelectedIndexChanged;
            // 
            // panelGraf
            // 
            panelGraf.Location = new Point(10, 174);
            panelGraf.Margin = new Padding(2);
            panelGraf.Name = "panelGraf";
            panelGraf.Size = new Size(545, 526);
            panelGraf.TabIndex = 6;
            panelGraf.Paint += panelGraf_Paint;
            // 
            // btnRedraw
            // 
            btnRedraw.Location = new Point(274, 40);
            btnRedraw.Margin = new Padding(2);
            btnRedraw.Name = "btnRedraw";
            btnRedraw.Size = new Size(280, 27);
            btnRedraw.TabIndex = 7;
            btnRedraw.Text = "Перерисовать";
            btnRedraw.UseVisualStyleBackColor = true;
            btnRedraw.Click += btnRedraw_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 89);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 8;
            label1.Text = "a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 122);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 8;
            label2.Text = "p";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(128, 92);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(16, 20);
            label3.TabIndex = 8;
            label3.Text = "k";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(128, 122);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 8;
            label4.Text = "b";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 86);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 20);
            label5.TabIndex = 8;
            label5.Text = "Цвет графика";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(273, 119);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(112, 20);
            label6.TabIndex = 8;
            label6.Text = "Режим вывода";
            // 
            // comboBoxChooseEquation
            // 
            comboBoxChooseEquation.FormattingEnabled = true;
            comboBoxChooseEquation.Items.AddRange(new object[] { "F = ax ^ (-p) * sin(kx + b)", "F = sin ^ 2x + sin(k*x) + p" });
            comboBoxChooseEquation.Location = new Point(12, 40);
            comboBoxChooseEquation.Name = "comboBoxChooseEquation";
            comboBoxChooseEquation.Size = new Size(257, 28);
            comboBoxChooseEquation.TabIndex = 9;
            comboBoxChooseEquation.SelectedIndexChanged += comboBoxChooseEquation_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 710);
            Controls.Add(comboBoxChooseEquation);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRedraw);
            Controls.Add(panelGraf);
            Controls.Add(comboMode);
            Controls.Add(btnChooseColor);
            Controls.Add(txtB);
            Controls.Add(txtK);
            Controls.Add(txtP);
            Controls.Add(txtA);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtP;
        private TextBox txtK;
        private TextBox txtB;
        private Button btnChooseColor;
        private ComboBox comboMode;
        private Panel panelGraf;
        private Button btnRedraw;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBoxChooseEquation;
    }
}
