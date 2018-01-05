using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMuteSheet
{
    public partial class FormPointBuy : Form
    {
        public FormPointBuy()
        {
            InitializeComponent();
        }

        public int points = 27;

        

        private void FormPointBuy_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
                this.WindowState = FormWindowState.Normal;
            else
            {
                TopMost = true;
                Focus();
                BringToFront();
                TopMost = false;
            }

            if (txtBoxPoints.Text == "-1")
            {
                txtBoxPoints.Text = "27";
                txtStr.Text = "8";
             
            }
        }


        private void btnStrIn_Click(object sender, EventArgs e)
        {
            txtStr.Text = PonitsInc(txtStr.Text);

        }

        

        private void btnStrDe_Click(object sender, EventArgs e)
        {
            txtStr.Text = PointsDec(txtStr.Text);
        }

        private string PointsDec(string input)
        {
            int val = Convert.ToInt32(input);

            switch (val)
            {
                case 8:
                    break;
                case 9:
                    points += 1;
                    break;
                case 10:
                    points += 1;
                    break;
                case 11:
                    points += 1;
                    break;
                case 12:
                    points += 1;
                    break;
                case 13:
                    points += 1;
                    break;
                case 14:
                    points += 2;
                    break;
                case 15:
                    points += 2;
                    break;
                default:
                    return "8";        
            }

            if (points < 0)
            {
                points = 27;
                return "8";
            }

            if (Convert.ToInt32(input) <= 8)
            {
                return "8";
            }

            txtBoxPoints.Text = points.ToString();

            val--;

            string newstring = val.ToString();

            return newstring;      
        }

        private string PonitsInc(string input)
        {
            int val = Convert.ToInt32(input);

            val++;

            //MessageBox.Show(val.ToString());

            

            switch (val)
            {
                case 8:
                    MessageBox.Show(val.ToString());
                    break;
                case 9:
                    points -= 1;
                    break;
                case 10:
                    points -= 1;
                    break;
                case 11:
                    points -= 1;
                    break;
                case 12:
                    points -= 1;
                    break;
                case 13:
                    points -= 1;
                    break;
                case 14:
                    points -= 2;
                    break;
                case 15:
                    points -= 2;
                    break;
                default:
                    return "8";

            }

            if (points < 0)
            {
                points = 27;
                return "8";
            }
            txtBoxPoints.Text = points.ToString();

            

            string newstring = val.ToString();

            return newstring;
        }

    }

    }

