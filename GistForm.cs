using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budgetirovanie
{
    public partial class GistForm : Form
    {
        public GistForm()
        {
            InitializeComponent();
        }

        private void GistForm_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
                ActiveXOpenGl.AddData(rand.Next(0, 1000), rand.Next(0, 1000), rand.Next(0, 10));

        }

        private void GistForm_Resize(object sender, EventArgs e)
        {
            ActiveXOpenGl.Location = new Point(0, 0);
            ActiveXOpenGl.Size = ClientSize;
        }

        private void GistForm_Shown(object sender, EventArgs e)
        {
            GistForm_Resize(null, null);
        }

        private void GistForm_MouseWheel(object sender, MouseEventArgs e)
        {
            if(e.Delta != 0 )
                ActiveXOpenGl.zRot += e.Delta/100;
            ActiveXOpenGl.ReDraw();
        }

        private void GistForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
                ActiveXOpenGl.xRot += (float)1.0;
            if (e.KeyCode == Keys.S)
                ActiveXOpenGl.xRot -= (float)1.0;
            if (e.KeyCode == Keys.A)
                ActiveXOpenGl.yRot -= (float)1.0;
            if (e.KeyCode == Keys.D)
                ActiveXOpenGl.yRot -= (float)1.0;
            ActiveXOpenGl.ReDraw();


        }

    }
}
