using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Picker
{
    public partial class Form1 : Form
    {
        int move, movx, movy;

        public Form1()
        {
            InitializeComponent();
            txtRed.Text = "0";
            txtGreen.Text = "0";
            txtBlue.Text = "0";
            pnlMain.BackColor = Color.Black;
        }
        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            move = 1;
            movx = e.X; movy=e.Y;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            move = 0;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (move == 1)
            {
                this.SetDesktopLocation(MousePosition.X-movx,MousePosition.Y-movy);
            }
        }
        private void trackBarRed_ValueChanged(object sender, EventArgs e)
        {
            txtRed.Text = trackBarRed.Value.ToString();
           
            int r, g, b ;
            r = Convert.ToInt32(txtRed.Text);
            g = Convert.ToInt32(txtGreen.Text);
            b = Convert.ToInt32(txtBlue.Text);
            pnlMain.BackColor = Color.FromArgb(r, g, b);
        }

        

        private void trackBarGreen_ValueChanged(object sender, EventArgs e)
        {
           
            txtGreen.Text = trackBarGreen.Value.ToString();
            
            int r, g, b;
            r = Convert.ToInt32(txtRed.Text);
            g = Convert.ToInt32(txtGreen.Text);
            b = Convert.ToInt32(txtBlue.Text);
            pnlMain.BackColor = Color.FromArgb(r, g, b);
        }

        

        private void trackBarBlue_ValueChanged(object sender, EventArgs e)
        {
            
            txtBlue.Text = trackBarBlue.Value.ToString();
            int r, g, b;
            r = Convert.ToInt32(txtRed.Text);
            g = Convert.ToInt32(txtGreen.Text);
            b = Convert.ToInt32(txtBlue.Text);
            pnlMain.BackColor = Color.FromArgb(r, g, b);
        }

        

        private void btnColorPic_Click(object sender, EventArgs e)
        {
          
            int r, g, b;
            r = Convert.ToInt32(txtRed.Text);
            g = Convert.ToInt32(txtGreen.Text);
            b = Convert.ToInt32(txtBlue.Text);

            txtHEX.Text = '#' + string.Format("{0:X2}{1:X2}{2:X2}",r, g, b);
            txtRGB.Text = r+","+g+","+b;


        }

        private void btnCopyHEX_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtHEX.Text);
        }
        private void btnCopyRGB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtRGB.Text);
        }


    }
}
