using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp4
{

    public partial class Form1 : Form
    {
        public static int[] gen = new int[22];
        public static int[] genchek = new int[22];
        public static int z = 0;
        public static int l = 0;
        public static int n = 0;
        public static int d = 3;
        public static int m = 200;
        public static int b = 120;
        public static System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.muze);
        public void _pause(int value)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            while (sw.ElapsedMilliseconds < value)
                Application.DoEvents();

        }


        public Form1()
        {
            InitializeComponent();
           
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.muze);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            genchek[z] = 3;
            z++;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            genchek[z] = 1;
            z++;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            genchek[z] = 2;
            z++;
        }

        public void pictureBox7_Click(object sender, EventArgs e)
        {


            Random rnd = new Random();
            int x;


            for (x = 0; x < d; x++)
                gen[x] = rnd.Next(1, 6);
            d = d - 2;
            label4.Text = "уровень " + d;
            d = d + 2;
            foreach (int y in gen)
            {



                if (y == 1)
                {
                    this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.transbar;

                }
                else
                {

                }






                if (y == 2)
                {
                    this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.transbar;
                }
                else { }



                if (y == 3)
                {
                    this.pictureBox3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.transbar;
                }
                else { }
                if (y == 4)
                {
                    this.pictureBox4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.transbar;
                }
                else { }
                if (y == 5)
                {
                    this.pictureBox5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.transbar;
                }
                else { }
                if (y == 6)
                {
                    this.pictureBox6.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.transbar;
                }
                else { }
                _pause(1000);

                this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
                this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
                this.pictureBox3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
                this.pictureBox4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
                this.pictureBox5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
                this.pictureBox6.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
                _pause(1000);
            }

        }




        private void button4_Click()
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        public void timer1_Tick(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            n = d + 1;
           
            System.Media.SoundPlayer sp = new System.Media.SoundPlayer(Properties.Resources.muze);
            if (gen.SequenceEqual(genchek)&&(d == z))
            {
                this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
                this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
                this.pictureBox3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
                this.pictureBox4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
                this.pictureBox5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
                this.pictureBox6.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
                label2.Text = "победил"; z = 0;
                _pause(1500);

                d = d - 1;
                label4.Refresh();
                label4.Text = "уровень " + d;
                d = d + 2;
                if (d == 22) { d = d - 1;
                    label2.Update();
                    label2.Text = "100% победа ты ебучий гений";
                }
                else { }

            }
            else {
                this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.zloybar;
                this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.zloybar;
                this.pictureBox3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.zloybar;
                this.pictureBox4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.zloybar;
                this.pictureBox5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.zloybar;
                this.pictureBox6.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.zloybar;
                label2.Text = "проиграл"; z = 0;
                for (int i = 0; i < 20; i++)
                {
                    gen[l] = 0;
                    genchek[l] = 0;
                    l++;
                }
                l = 0;
                d = d - 2;
                label4.Refresh();

                label4.Text = "уровень " + d;
                d = d + 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            d = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            d = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            d = 12;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            genchek[z] = 6;
            z++;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            genchek[z] = 5;
            z++;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            genchek[z] = 4;
            z++;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            sp.Stop();
            this.Close();

        }

        private void button13_Click(object sender, EventArgs e)
        {
            sp.Play();

        }

        private void PictureBox1_click(object sender, EventArgs e)
        {
            genchek[z] = 1;
            z++;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
            _pause(250);
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
        }

        private void PictureBox2_click(object sender, EventArgs e)
        {
            genchek[z] = 2;
            z++;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
            _pause(250);
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
        }

        private void PictureBox3_click(object sender, EventArgs e)
        {
            genchek[z] = 3;
            z++;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
            _pause(250);
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
        }

        private void PictureBox4_click(object sender, EventArgs e)
        {
            genchek[z] = 4;
            z++;
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
            _pause(250);
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
        }

        private void PictureBox5_click(object sender, EventArgs e)
        {
            genchek[z] = 5;
            z++;
            this.pictureBox5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
            _pause(250);
            this.pictureBox5.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
        }

        private void PictureBox6_click(object sender, EventArgs e)
        {
            genchek[z] = 6;
            z++;
            this.pictureBox6.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.schasbar;
            _pause(250);
            this.pictureBox6.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.normbar;
        }

        private void pb12_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox12.Size = new Size(m, b);
        }

        private void pb12_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox12.Size = new Size(m, b);
        }

        private void pb1_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox1.Size = new Size(m, b);
        }

        private void pb1_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox1.Size = new Size(m, b);
        }

        private void pb2_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox2.Size = new Size(m, b);
        }

        private void pb2_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox2.Size = new Size(m, b);
        }

        private void pb3_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox3.Size = new Size(m, b);
        }

        private void pb3_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox3.Size = new Size(m, b);
        }

        private void pb4_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox4.Size = new Size(m, b);
        }

        private void pb4_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox4.Size = new Size(m, b);
        }

        private void pb5_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox5.Size = new Size(m, b);
        }

        private void pb5_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox5.Size = new Size(m, b);
        }

        private void pb6_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox6.Size = new Size(m, b);
        }

        private void pb6_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox6.Size = new Size(m, b);
        }

        private void pb7_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox7.Size = new Size(m, b);
        }

        private void pb7_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox7.Size = new Size(m, b);
        }
        private void pb8_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox8.Size = new Size(m, b);
        }

        private void pb8_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox8.Size = new Size(m, b);
        }

        private void pb11_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox11.Size = new Size(m, b);
        }

        private void pb11_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox11.Size = new Size(m, b);
        }

        private void pb9_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox9.Size = new Size(m, b);
        }

        private void pb9_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox9.Size = new Size(m, b);
        }

        private void pb10_me(object sender, EventArgs e)
        {
            m = m + 20;
            b = b + 20;
            pictureBox10.Size = new Size(m, b);
        }

        private void pb10_ml(object sender, EventArgs e)
        {
            m = m - 20;
            b = b - 20;
            pictureBox10.Size = new Size(m, b);
        }

        private void button13_Click(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

       
    }
}
