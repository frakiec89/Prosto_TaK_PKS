using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tak_Prosto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Start();
            buttonNo.Click += ButtonNo_Click;

            buttonYes.Click += ButtonYes_Click;
            buttonYes.MouseEnter += ButtonYes_Click;
            buttonYes.MouseHover += ButtonYes_Click;



            buttonNo.Click += ButtonNo_Click;
        }

        private void ButtonNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Жаль");
        }

        private void ButtonYes_Click(object sender, EventArgs e)
        {
            GoButton();
        }

        private void GoButton()
        {
            Random random = new Random(buttonYes.Location.X);
            buttonYes.Location = new Point(GetX(random), GetY(random));

            this.Text = "x: " +  buttonYes.Location.X.ToString() + " y: " +  buttonYes.Location.Y.ToString();

            this.Text += " Max x:" + this.Width + " Max y:" + this.Height; 
        }

        private int GetY(Random random)
        {
            var y = random.Next(  this.Height - buttonYes.Height*2  );
            return y; 
        }

        private int GetX(Random random)
        {
            var x =  random.Next(this.Width - buttonYes.Width);
            if (x >= 0)
            {
                return x;
            }
            else
            {
                return 0;
            }
        }

        private void Start()
        {
            this.Text = "Просто так";
            buttonNo.Text = "Нет";
            buttonYes.Text = "ДА";
        }
    }
}
