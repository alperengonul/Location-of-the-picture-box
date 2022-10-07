using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace location_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x, y;
        
        int kontrol = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (pictureBox3.Location.X )
            {
                x = x + 10;
            }
           
          //  y ;
           // pictureBox3.Left += 10;
            // pictureBox3.Top += 1;

            if (pictureBox3.Location.X == 800)
            {
              //  y = y - 10;
                x -= 10;
                pictureBox3.Location = new Point(x, y);
            }
            pictureBox3.Location = new Point(x,y);
            label1.Text = Convert.ToString(x);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            x = pictureBox3.Location.X;
            y = pictureBox3.Location.Y;

            label1.Text = Convert.ToString(x) ; 

            timer1.Start();
        }
    }
}
