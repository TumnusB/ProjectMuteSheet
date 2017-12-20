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
                numUDStr.Value = 8;
                numUDDex.Value = 8;
                numUDCon.Value = 8;
                numUDInt.Value = 8;
                numUDWis.Value = 8;
                numUDCha.Value = 8;
            }
        }

        private void numUDStr_ValueChanged(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(numUDStr.Value);
            switch (val)
            {
                case 8:
                    break;
                case 9:
                        points -= 1;
                    break;
                case 10:
                    points -= 2;
                    break;
                case 11:
                    points -= 3;
                    break;
                case 12:
                    points -= 4;
                    break;
                case 13:
                    points -= 5;
                    break;
                case 14:
                    points -= 7;
                    break;
                case 15:
                    points -= 9;
                    break;
                default:
                    numUDStr.Value = 8;
                    break;
            }

            if (points < 0)
            {
                points = 27;
                //txtBoxPoints.Text = "27";
                numUDStr.Value = 8;
            }

            txtBoxPoints.Text = points.ToString();
        }

        private void numUDDex_ValueChanged(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(numUDDex.Value);
            switch (val)
            {
                case 8:
                    break;
                case 9:
                    points -= 1;
                    break;
                case 10:
                    points -= 2;
                    break;
                case 11:
                    points -= 3;
                    break;
                case 12:
                    points -= 4;
                    break;
                case 13:
                    points -= 5;
                    break;
                case 14:
                    points -= 7;
                    break;
                case 15:
                    points -= 9;
                    break;
                default:
                    numUDDex.Value = 8;
                    break;
            }

            if (points < 0)
            {
                points = 27;
                //txtBoxPoints.Text = "27";
                numUDDex.Value = 8;
            }

            txtBoxPoints.Text = points.ToString();
        }
    }
    }

