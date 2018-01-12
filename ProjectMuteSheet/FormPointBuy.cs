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

        
        Points p = new Points();


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
                txtDex.Text = "8";
             
            }
        }


        private void btnStrIn_Click(object sender, EventArgs e)
        {
            txtStr.Text = p.PointsInc(txtStr.Text, txtBoxPoints);

        }

        private void btnStrDe_Click(object sender, EventArgs e)
        {
            txtStr.Text = p.PointsDec(txtStr.Text, txtBoxPoints);
        }

        private void btnDexIn_Click(object sender, EventArgs e)
        {
            txtDex.Text = p.PointsInc(txtDex.Text, txtBoxPoints);
        }

        private void btnDexDe_Click(object sender, EventArgs e)
        {
            txtDex.Text = p.PointsDec(txtDex.Text, txtBoxPoints);
        }

        private void btnConIn_Click(object sender, EventArgs e)
        {
            txtCon.Text = p.PointsInc(txtCon.Text, txtBoxPoints);
        }

        private void btnConDe_Click(object sender, EventArgs e)
        {
            txtCon.Text = p.PointsDec(txtCon.Text, txtBoxPoints);
        }

        private void btnIntIn_Click(object sender, EventArgs e)
        {
            txtInt.Text = p.PointsInc(txtInt.Text, txtBoxPoints);
        }

        private void btnIntDe_Click(object sender, EventArgs e)
        {
            txtInt.Text = p.PointsDec(txtInt.Text, txtBoxPoints);
        }

        private void btnWisIn_Click(object sender, EventArgs e)
        {
            txtWis.Text = p.PointsInc(txtWis.Text, txtBoxPoints);
        }

        private void btnWisDe_Click(object sender, EventArgs e)
        {
            txtWis.Text = p.PointsDec(txtWis.Text, txtBoxPoints);
        }

        private void btnChaIn_Click(object sender, EventArgs e)
        {
            txtCha.Text = p.PointsInc(txtCha.Text, txtBoxPoints);
        }

        private void btnChaDe_Click(object sender, EventArgs e)
        {
            txtCha.Text = p.PointsDec(txtCha.Text, txtBoxPoints);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            p.Reset(txtStr, txtDex, txtCon, txtInt, txtWis, txtCha, txtBoxPoints);
        }

        private void btnAckScore_Click(object sender, EventArgs e)
        {
           

        }
    }

    }

