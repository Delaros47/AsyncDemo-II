using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private async void Sum(int num1, int num2)
        {
            await Task.Run(() =>
               {
                   Thread.Sleep(10000);
                   MessageBox.Show((num1 + num2).ToString());

               });
        }

        private async void Multiply(int num1, int num2)
        {
            await Task.Run(() =>
            {
                MessageBox.Show((num1 * num2).ToString());
            });
        }

        private async void Generate()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < int.MaxValue; i++)
                {
                    Thread.Sleep(100);
                    lstNumbers.Items.Add(i);
                }
            });
        }

        private async void ChangeColor()
        {
            
            await Task.Run(() =>
            {
                while (true)
                {
                    Random rnd = new Random();
                    Thread.Sleep(500);
                    this.BackColor = Color.FromArgb(rnd.Next(0,256), rnd.Next(0, 256), rnd.Next(0, 256));
                }
            });
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            Sum(int.Parse(txtFirst.Text), int.Parse(txtSecond.Text));

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Multiply(int.Parse(txtFirst.Text), int.Parse(txtSecond.Text));
        }

        private void btnNumbers_Click(object sender, EventArgs e)
        {
            Generate();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ChangeColor();
        }
    }
}
