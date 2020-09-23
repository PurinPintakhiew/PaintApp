using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintBRU
{
    public partial class Paint : Form
    {
        int x, y,w,h;
        char shape;
        byte R, G, B;
        Bitmap bmp;
        Graphics g;
        bool drag;
        double size;
        Point LastP;

        public Paint()
        {
            InitializeComponent();
            Pict.Image = new Bitmap(Pict.Width,Pict.Height);
            bmp = new Bitmap(Pict.Image);
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);

        }
        private void Pict_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            if((e.Button & MouseButtons.Left) == MouseButtons.Left) {
                LastP = e.Location;
            }
            drag = true;
        }

        private void tsbRect_Click(object sender, EventArgs e)
        {
            shape = 'r';
        }

        private void tsbCircle_Click(object sender, EventArgs e)
        {
            shape = 'c';
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            shape = 'e';
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (DlgSave.ShowDialog() == DialogResult.OK)
            {
                bmp.Save(DlgSave.FileName,ImageFormat.Bmp);

            }
        }

        private void newPenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Dawd_Click(object sender, EventArgs e)
        {
            shape = 'd';
        }

        private void Pict_MouseMove(object sender, MouseEventArgs e)
        {
            // Graphics g = Pict.CreateGraphics();
            if (drag)
            {
               Pict.CreateGraphics().FillRectangle(new SolidBrush(Color.White), x, y, w, h);
                switch (shape)
                {
                    case 'd':
                        if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                        {
                            size = Convert.ToDouble(txtSize.Text);
                            Pict.CreateGraphics().DrawLine(new Pen(Color.FromArgb(R, G, B)), LastP, e.Location);
                            g.DrawLine(new Pen(Color.FromArgb(R, G, B), (float)size), LastP, e.Location);
                            LastP = e.Location;
                        }
                        break;
                    case 'e':
                        if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                        {
                            size = Convert.ToDouble(txtSize.Text);
                            g.DrawEllipse(new Pen(Color.White, (float)size), x, y, Convert.ToInt32(size), Convert.ToInt32(size));
                            x = e.X;
                            y = e.Y;
                        }
                        break;
                }
            }
        }

        private void tsbColor_Click(object sender, EventArgs e)
        {
            ColorDialog s = new ColorDialog();
            //s.ShowDialog();
            if (s.ShowDialog() == DialogResult.OK)
            {
                R = s.Color.R;
                G = s.Color.G;
                B = s.Color.B;
            }
           
            SC.BackColor = Color.FromArgb(R, G, B);
            
        }

        private void Pict_MouseUp(object sender, MouseEventArgs e)
        {
            w = Math.Abs(e.X - x);
            if (e.X < x) x = e.X;
            h = Math.Abs(e.Y - y);
            if(e.Y < y) y = e.Y;
            //Graphics g = Pict.CreateGraphics();
            
            size = Convert.ToDouble(txtSize.Text);

            switch (shape)
                {
                    case 'r':
                        Pict.CreateGraphics().DrawRectangle(new Pen(Color.FromArgb(R, G, B)), x, y, w, h);
                        g.DrawRectangle(new Pen(Color.FromArgb(R, G, B), (float)size), x, y, w, h);

                        
                        break;
                    case 'c':
                        Pict.CreateGraphics().DrawEllipse(new Pen(Color.FromArgb(R, G, B)), x, y, w, h);
                        g.DrawEllipse(new Pen(Color.FromArgb(R, G, B), (float)size), x, y, w, h);
                    break;
                }
            drag = false;
           //g.Dispose();
        }

        private void Pict_Paint(object sender, PaintEventArgs e)
        {
            Pict.Show();
            
        }
  

    }
}
