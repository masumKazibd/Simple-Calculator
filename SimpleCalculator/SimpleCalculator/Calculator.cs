using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int fNum = Convert.ToInt32(txtFirst.Text);
            int sNum = Convert.ToInt32(txt2nd.Text);

            int res = fNum + sNum;
            labelResult.Text = res.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fNum = Convert.ToInt32(txtFirst.Text);
            int sNum = Convert.ToInt32(txt2nd.Text);

            int res = fNum - sNum;
            labelResult.Text = res.ToString();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int fNum = Convert.ToInt32(txtFirst.Text);
            int sNum = Convert.ToInt32(txt2nd.Text);

            int res = fNum * sNum;
            labelResult.Text = res.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fNum = Convert.ToInt32(txtFirst.Text);
            int sNum = Convert.ToInt32(txt2nd.Text);

            int res = fNum / sNum;
            labelResult.Text = res.ToString();
        }
    }
}
