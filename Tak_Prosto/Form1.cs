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
        List<Button> buttons = new List<Button>();

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
            var buton =  buttons.Single(x => x.GetHashCode() == sender.GetHashCode());

            GoButton(buton);
        }

        private void GoButton( Button button )
        {


            var newButton = new Button
            {
                Location = new System.Drawing.Point(337, 249),
                Size = new System.Drawing.Size(75, 23),
                Text = "ДА",
                UseVisualStyleBackColor = true,
                BackColor = NewColor( button.BackColor)
            };

            newButton.MouseEnter += ButtonYes_Click;
            newButton.MouseHover += ButtonYes_Click;
            newButton.Location = GetPoint(button.Location.X);
            button.Location = GetPoint(newButton.Location.Y);

            this.Controls.Add(newButton);
            
            buttons.Add(newButton);


        }

        private Color NewColor(Color backColor)
        {
            Random random = new Random(backColor.R);
            if ( random.Next (2) == 1 )
            {
                return Color.Azure;
            }
            else { return Color.Red; }
        }

        private Point GetPoint( int x )
        {
            Random random = new Random(x);
            return new Point(GetX(random), GetY(random));

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

             buttons.Add(buttonYes);
        }
    }
}
