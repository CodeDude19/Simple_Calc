using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void bunifuTileButton9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void bunifuTileButton10_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + ".";
        }
       
        private void bunifuTileButton14_Click(object sender, EventArgs e)
        {

            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
           else if (divideButtonClicked==true)
            {
                total2 = total1/double.Parse(txtDisplay.Text);
            }
            else if (multiplyButtonClicked == true)
            {
                total2 = total1*double.Parse(txtDisplay.Text);

            }
            else if (percentageButtonClicked == true)
            {
                
                 total2 = total1*double.Parse(txtDisplay.Text);
            }

            txtDisplay.Text = total2.ToString();
            total1 = 0;




            



        }
        double total1 = 0;
        double total2 = 0;







        private void bunifuTileButton13_Click(object sender, EventArgs e)
        {
            try
            {
                total1 = total1 + (double.Parse(txtDisplay.Text));
                txtDisplay.Clear();
                minusButtonClicked = false;
                plusButtonClicked = true;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
                percentageButtonClicked = false;
            }
            catch (Exception)
            {
                Form2 a = new Form2();
                a.Show();

            }
        }
            

        private void bunifuTileButton8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void bunifuTileButton7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "6";
        }


        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multiplyButtonClicked = false;
        bool percentageButtonClicked = false;

        private void bunifuTileButton12_Click(object sender, EventArgs e)
        {
            try
            {
                total1 = total1 + (double.Parse(txtDisplay.Text));
                txtDisplay.Clear();
                minusButtonClicked = true;
                plusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
                percentageButtonClicked = false;
            }
            catch (Exception)
            {
                Form2 a = new Form2();
                a.Show();

            }


        }

        private void bunifuTileButton11_Click(object sender, EventArgs e)
        {
            try
            {
                total1 = total1 + (double.Parse(txtDisplay.Text));
                txtDisplay.Clear();
                minusButtonClicked = false;
                plusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = true;
                percentageButtonClicked = false;
            }
            catch (Exception)
            {
                Form2 a = new Form2();
                a.Show();

            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void bunifuTileButton16_Click(object sender, EventArgs e)
        {
           double  plusminus = 0 - double.Parse(txtDisplay.Text);
            txtDisplay.Text = "" + plusminus;
            

        }

        private void bunifuTileButton17_Click(object sender, EventArgs e)
        {
            txtDisplay.Text =  txtDisplay.Text + "0";
        }

        private void bunifuTileButton18_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void bunifuTileButton89_Click(object sender, EventArgs e)
        {
            try
            {
                total1 = total1 + (double.Parse(txtDisplay.Text) );
                txtDisplay.Clear();
                minusButtonClicked = false;
                plusButtonClicked = false;
                divideButtonClicked = true;
                multiplyButtonClicked = false;
                percentageButtonClicked = false;
            }
            catch (Exception)
            {
                Form2 a = new Form2();
                a.Show();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void bunifuTileButton88_Click(object sender, EventArgs e)
        {
            try {
                total1 = total1 + (double.Parse(txtDisplay.Text) /100 );
                txtDisplay.Clear();
                minusButtonClicked = false;
                plusButtonClicked = false;
                divideButtonClicked = false;
                multiplyButtonClicked = false;
                percentageButtonClicked = true;
            }
            catch (Exception)
            {
                Form2 a = new Form2();
                a.Show();

            }
            

           


        }
    }
}
