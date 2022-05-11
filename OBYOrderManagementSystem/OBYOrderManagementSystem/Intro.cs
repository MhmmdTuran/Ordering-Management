using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace OBYOrderManagementSystem
{
    public partial class Intro : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );

        public Intro()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 7, 7));
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        int first_location = pictureBox2.Location.Y;
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 5);
                        if(pictureBox2.Location.Y == 440)
                        {
                            this.pictureBox2.Location = new System.Drawing.Point(217, 440);
                        }
                        break;
                    case 1:
                        pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + 5);
                        break;
                    case 2:
                        pictureBox9.Location = new Point(pictureBox9.Location.X, pictureBox9.Location.Y + 5);
                        break;
                }    
            }
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 4);
                        break;
                    case 1:
                        pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + 4);
                        break;
                    case 2:
                        pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + 4);
                        break;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + 3);
                        break;
                    case 1:
                        pictureBox10.Location = new Point(pictureBox10.Location.X, pictureBox10.Location.Y + 3);
                        break;
                    case 2:
                        pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + 3);
                        break;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

                label1.Text = progressBar1.Value.ToString() + " %";
            }
            else
            {
                timer2.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
