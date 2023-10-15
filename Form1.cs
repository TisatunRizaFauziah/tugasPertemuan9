using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tugasPertemuan9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double hasil;
        char lambangOperator;
        bool operatorDitekan;

        private void fokus()
        {
            txtinput.Focus();
            txtinput.Select(txtinput.Text.Length, 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtinput.Text = "0";
            txthasil.Text = " ";
            hasil = 0;
            lambangOperator = ' ';
            fokus();
            
        }

        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btnA = (Button)sender;
            if(txtinput.Text == "0")
            {
                txtinput.Clear();
            }
            if(lambangOperator== '=')
            {
                txtinput.Clear();
                lambangOperator = ' ';
                hasil = 0;
            }
            txtinput.Text = txtinput.Text + btnA.Text;
            operatorDitekan = false;
            fokus();
        }

        private void btnKoma_Click(object sender, EventArgs e)
        {
            if (txtinput.Text.Contains(',') == false)
            {
                txtinput.Text = txtinput.Text + " , ";
            }
            if (lambangOperator == '=')
            {
                hasil = 0;
                lambangOperator = ' ';
                operatorDitekan = false;
            }
            fokus();
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            txtinput.Text=(Convert.ToDouble(txtinput.Text)*-1).ToString();
            fokus();
        }

        private void Clearkan()
        {
            txtinput.Text = "0";
            txthasil.Text = " ";
            hasil = 0;
            lambangOperator = ' ';
            operatorDitekan = false;
        }
        private void btnc_Click(object sender, EventArgs e)
        {
            Clearkan();
            fokus();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtinput.Text = "0";
            if(lambangOperator == '=')
            {
                hasil = 0;
                lambangOperator = ' ';
                operatorDitekan = false;
            }
            fokus();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            txtinput.Text = txtinput.Text.Remove(txtinput.Text.Length -1);
            if(txtinput.Text == ""||txtinput.Text == "-")
            {
                txtinput.Text = "0";
            }
            if(lambangOperator == '=')
            {
                hasil = 0;
                lambangOperator = ' ';
                operatorDitekan = false;
            }
            fokus() ;
        }

      

        private void btnOperator_Click_1(object sender, EventArgs e)
        {
            Button btnOP = (Button)sender;
            if (lambangOperator == '=')
            {
                lambangOperator = ' ';
            }
            if (hasil == 0)
            {
                hasil = Convert.ToDouble(txtinput.Text);
            }
            else
            {
                if (lambangOperator == '+')
                {
                    hasil = hasil + Convert.ToDouble(txtinput.Text);
                }
                else if (lambangOperator == '-')
                {
                    hasil = hasil - Convert.ToDouble(txtinput.Text);
                }
                else if (lambangOperator == ':')
                {
                    hasil = hasil / Convert.ToDouble(txtinput.Text);
                }
                else if (lambangOperator == 'X')
                {
                    hasil = hasil * Convert.ToDouble(txtinput.Text);
                }
            }
            if(btnOP.Text == "=")
            {
                txthasil.Text = "";
                txtinput.Text = hasil.ToString();
            }
            else
            {
                txthasil.Text = hasil.ToString() + btnOP.Text;
                txtinput.Text = "0";
            }
            lambangOperator = Convert.ToChar(btnOP.Text);
            txthasil.Text = hasil.ToString() + btnOP.Text;
            txtinput.Text = "0";

            fokus();
        }

       
    }
}
