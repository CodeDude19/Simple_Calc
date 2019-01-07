namespace WindowsFormsApplication1
{
    partial class Calculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndivide = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPercentage = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnCE = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnC = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnequals = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnadd = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnminus = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnmultiply = new Bunifu.Framework.UI.BunifuTileButton();
            this.btndot = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn0 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn9 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn8 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 32);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(186, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "−";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(214, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "×";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.btndivide);
            this.panel2.Controls.Add(this.btnPercentage);
            this.panel2.Controls.Add(this.btnCE);
            this.panel2.Controls.Add(this.btnC);
            this.panel2.Controls.Add(this.btnequals);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.btnminus);
            this.panel2.Controls.Add(this.btnmultiply);
            this.panel2.Controls.Add(this.btndot);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 312);
            this.panel2.TabIndex = 1;
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndivide.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndivide.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btndivide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndivide.Font = new System.Drawing.Font("Candara", 27.75F);
            this.btndivide.ForeColor = System.Drawing.Color.White;
            this.btndivide.Image = null;
            this.btndivide.ImagePosition = 36;
            this.btndivide.ImageZoom = 50;
            this.btndivide.LabelPosition = 56;
            this.btndivide.LabelText = "÷";
            this.btndivide.Location = new System.Drawing.Point(184, 1);
            this.btndivide.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(60, 61);
            this.btndivide.TabIndex = 33;
            this.btndivide.Click += new System.EventHandler(this.bunifuTileButton89_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.Color.Silver;
            this.btnPercentage.color = System.Drawing.Color.Silver;
            this.btnPercentage.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btnPercentage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPercentage.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.ForeColor = System.Drawing.Color.Black;
            this.btnPercentage.Image = null;
            this.btnPercentage.ImagePosition = 21;
            this.btnPercentage.ImageZoom = 50;
            this.btnPercentage.LabelPosition = 45;
            this.btnPercentage.LabelText = "%";
            this.btnPercentage.Location = new System.Drawing.Point(123, 1);
            this.btnPercentage.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(60, 61);
            this.btnPercentage.TabIndex = 32;
            this.btnPercentage.Click += new System.EventHandler(this.bunifuTileButton88_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.Silver;
            this.btnCE.color = System.Drawing.Color.Silver;
            this.btnCE.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btnCE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCE.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.ForeColor = System.Drawing.Color.Black;
            this.btnCE.Image = null;
            this.btnCE.ImagePosition = 21;
            this.btnCE.ImageZoom = 50;
            this.btnCE.LabelPosition = 45;
            this.btnCE.LabelText = "+/−";
            this.btnCE.Location = new System.Drawing.Point(62, 1);
            this.btnCE.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(60, 61);
            this.btnCE.TabIndex = 31;
            this.btnCE.Click += new System.EventHandler(this.bunifuTileButton16_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.Silver;
            this.btnC.color = System.Drawing.Color.Silver;
            this.btnC.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Black;
            this.btnC.Image = null;
            this.btnC.ImagePosition = 21;
            this.btnC.ImageZoom = 50;
            this.btnC.LabelPosition = 45;
            this.btnC.LabelText = "C";
            this.btnC.Location = new System.Drawing.Point(1, 1);
            this.btnC.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(60, 61);
            this.btnC.TabIndex = 30;
            this.btnC.Click += new System.EventHandler(this.bunifuTileButton18_Click);
            // 
            // btnequals
            // 
            this.btnequals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnequals.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnequals.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnequals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnequals.Font = new System.Drawing.Font("Candara", 27.75F);
            this.btnequals.ForeColor = System.Drawing.Color.White;
            this.btnequals.Image = null;
            this.btnequals.ImagePosition = 36;
            this.btnequals.ImageZoom = 50;
            this.btnequals.LabelPosition = 56;
            this.btnequals.LabelText = "=";
            this.btnequals.Location = new System.Drawing.Point(184, 249);
            this.btnequals.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnequals.Name = "btnequals";
            this.btnequals.Size = new System.Drawing.Size(60, 62);
            this.btnequals.TabIndex = 29;
            this.btnequals.Click += new System.EventHandler(this.bunifuTileButton14_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnadd.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnadd.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnadd.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.Image = null;
            this.btnadd.ImagePosition = 36;
            this.btnadd.ImageZoom = 50;
            this.btnadd.LabelPosition = 56;
            this.btnadd.LabelText = "+";
            this.btnadd.Location = new System.Drawing.Point(184, 187);
            this.btnadd.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(60, 61);
            this.btnadd.TabIndex = 28;
            this.btnadd.Click += new System.EventHandler(this.bunifuTileButton13_Click);
            // 
            // btnminus
            // 
            this.btnminus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnminus.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnminus.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnminus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnminus.Font = new System.Drawing.Font("Candara", 27.75F);
            this.btnminus.ForeColor = System.Drawing.Color.White;
            this.btnminus.Image = null;
            this.btnminus.ImagePosition = 36;
            this.btnminus.ImageZoom = 50;
            this.btnminus.LabelPosition = 56;
            this.btnminus.LabelText = "−";
            this.btnminus.Location = new System.Drawing.Point(184, 125);
            this.btnminus.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(60, 61);
            this.btnminus.TabIndex = 27;
            this.btnminus.Click += new System.EventHandler(this.bunifuTileButton12_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmultiply.color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnmultiply.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnmultiply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmultiply.Font = new System.Drawing.Font("Candara", 27.75F);
            this.btnmultiply.ForeColor = System.Drawing.Color.White;
            this.btnmultiply.Image = null;
            this.btnmultiply.ImagePosition = 36;
            this.btnmultiply.ImageZoom = 50;
            this.btnmultiply.LabelPosition = 56;
            this.btnmultiply.LabelText = "×";
            this.btnmultiply.Location = new System.Drawing.Point(184, 63);
            this.btnmultiply.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(60, 61);
            this.btnmultiply.TabIndex = 26;
            this.btnmultiply.Click += new System.EventHandler(this.bunifuTileButton11_Click);
            // 
            // btndot
            // 
            this.btndot.BackColor = System.Drawing.Color.Silver;
            this.btndot.color = System.Drawing.Color.Silver;
            this.btndot.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btndot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndot.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndot.ForeColor = System.Drawing.Color.Black;
            this.btndot.Image = null;
            this.btndot.ImagePosition = 21;
            this.btndot.ImageZoom = 50;
            this.btndot.LabelPosition = 45;
            this.btndot.LabelText = ".";
            this.btndot.Location = new System.Drawing.Point(123, 249);
            this.btndot.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(60, 62);
            this.btndot.TabIndex = 25;
            this.btndot.Click += new System.EventHandler(this.bunifuTileButton10_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.Silver;
            this.btn0.color = System.Drawing.Color.Silver;
            this.btn0.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn0.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.Black;
            this.btn0.Image = null;
            this.btn0.ImagePosition = 21;
            this.btn0.ImageZoom = 50;
            this.btn0.LabelPosition = 45;
            this.btn0.LabelText = "0";
            this.btn0.Location = new System.Drawing.Point(1, 249);
            this.btn0.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(121, 62);
            this.btn0.TabIndex = 24;
            this.btn0.Click += new System.EventHandler(this.bunifuTileButton17_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Silver;
            this.btn3.color = System.Drawing.Color.Silver;
            this.btn3.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.Black;
            this.btn3.Image = null;
            this.btn3.ImagePosition = 21;
            this.btn3.ImageZoom = 50;
            this.btn3.LabelPosition = 45;
            this.btn3.LabelText = "3";
            this.btn3.Location = new System.Drawing.Point(123, 187);
            this.btn3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(60, 61);
            this.btn3.TabIndex = 23;
            this.btn3.Click += new System.EventHandler(this.bunifuTileButton8_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Silver;
            this.btn2.color = System.Drawing.Color.Silver;
            this.btn2.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.Black;
            this.btn2.Image = null;
            this.btn2.ImagePosition = 21;
            this.btn2.ImageZoom = 50;
            this.btn2.LabelPosition = 45;
            this.btn2.LabelText = "2";
            this.btn2.Location = new System.Drawing.Point(62, 187);
            this.btn2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(60, 61);
            this.btn2.TabIndex = 22;
            this.btn2.Click += new System.EventHandler(this.bunifuTileButton7_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.Silver;
            this.btn6.color = System.Drawing.Color.Silver;
            this.btn6.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.Black;
            this.btn6.Image = null;
            this.btn6.ImagePosition = 21;
            this.btn6.ImageZoom = 50;
            this.btn6.LabelPosition = 45;
            this.btn6.LabelText = "6";
            this.btn6.Location = new System.Drawing.Point(123, 125);
            this.btn6.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(60, 61);
            this.btn6.TabIndex = 21;
            this.btn6.Click += new System.EventHandler(this.bunifuTileButton6_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.Silver;
            this.btn5.color = System.Drawing.Color.Silver;
            this.btn5.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.Black;
            this.btn5.Image = null;
            this.btn5.ImagePosition = 21;
            this.btn5.ImageZoom = 50;
            this.btn5.LabelPosition = 45;
            this.btn5.LabelText = "5";
            this.btn5.Location = new System.Drawing.Point(62, 125);
            this.btn5.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(60, 61);
            this.btn5.TabIndex = 20;
            this.btn5.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.Silver;
            this.btn4.color = System.Drawing.Color.Silver;
            this.btn4.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.Black;
            this.btn4.Image = null;
            this.btn4.ImagePosition = 21;
            this.btn4.ImageZoom = 50;
            this.btn4.LabelPosition = 45;
            this.btn4.LabelText = "4";
            this.btn4.Location = new System.Drawing.Point(1, 125);
            this.btn4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(60, 61);
            this.btn4.TabIndex = 19;
            this.btn4.Click += new System.EventHandler(this.bunifuTileButton4_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Silver;
            this.btn1.color = System.Drawing.Color.Silver;
            this.btn1.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.Black;
            this.btn1.Image = null;
            this.btn1.ImagePosition = 21;
            this.btn1.ImageZoom = 50;
            this.btn1.LabelPosition = 45;
            this.btn1.LabelText = "1";
            this.btn1.Location = new System.Drawing.Point(1, 187);
            this.btn1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(60, 61);
            this.btn1.TabIndex = 18;
            this.btn1.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.Silver;
            this.btn9.color = System.Drawing.Color.Silver;
            this.btn9.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.Black;
            this.btn9.Image = null;
            this.btn9.ImagePosition = 21;
            this.btn9.ImageZoom = 50;
            this.btn9.LabelPosition = 45;
            this.btn9.LabelText = "9";
            this.btn9.Location = new System.Drawing.Point(123, 63);
            this.btn9.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(60, 61);
            this.btn9.TabIndex = 17;
            this.btn9.Click += new System.EventHandler(this.bunifuTileButton9_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.Silver;
            this.btn8.color = System.Drawing.Color.Silver;
            this.btn8.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.Black;
            this.btn8.Image = null;
            this.btn8.ImagePosition = 21;
            this.btn8.ImageZoom = 50;
            this.btn8.LabelPosition = 45;
            this.btn8.LabelText = "8";
            this.btn8.Location = new System.Drawing.Point(62, 63);
            this.btn8.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(60, 61);
            this.btn8.TabIndex = 16;
            this.btn8.Click += new System.EventHandler(this.bunifuTileButton1_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.Silver;
            this.btn7.color = System.Drawing.Color.Silver;
            this.btn7.colorActive = System.Drawing.Color.LightSeaGreen;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.Black;
            this.btn7.Image = null;
            this.btn7.ImagePosition = 21;
            this.btn7.ImageZoom = 50;
            this.btn7.LabelPosition = 45;
            this.btn7.LabelText = "7";
            this.btn7.Location = new System.Drawing.Point(1, 63);
            this.btn7.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(60, 61);
            this.btn7.TabIndex = 15;
            this.btn7.Click += new System.EventHandler(this.btn1_Click);
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.txtDisplay);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(245, 129);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.Window;
            this.txtDisplay.Location = new System.Drawing.Point(0, 3);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(244, 126);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Tag = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Simple Calc";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 473);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuTileButton btndivide;
        private Bunifu.Framework.UI.BunifuTileButton btnPercentage;
        private Bunifu.Framework.UI.BunifuTileButton btnCE;
        private Bunifu.Framework.UI.BunifuTileButton btnC;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuTileButton btn7;
        private Bunifu.Framework.UI.BunifuTileButton btn8;
        private Bunifu.Framework.UI.BunifuTileButton btn9;
        private Bunifu.Framework.UI.BunifuTileButton btn1;
        private Bunifu.Framework.UI.BunifuTileButton btn4;
        private Bunifu.Framework.UI.BunifuTileButton btn5;
        private Bunifu.Framework.UI.BunifuTileButton btn6;
        private Bunifu.Framework.UI.BunifuTileButton btn2;
        private Bunifu.Framework.UI.BunifuTileButton btn3;
        private Bunifu.Framework.UI.BunifuTileButton btn0;
        private Bunifu.Framework.UI.BunifuTileButton btndot;
        private Bunifu.Framework.UI.BunifuTileButton btnmultiply;
        private Bunifu.Framework.UI.BunifuTileButton btnminus;
        private Bunifu.Framework.UI.BunifuTileButton btnadd;
        private Bunifu.Framework.UI.BunifuTileButton btnequals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label label3;
    }
}

