// Author: Andreas Lau, 34095187
// Date: 22/02/2022
// Purpose: Form that allows the user to select events to add into the map (FormMain).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1
{
    public partial class FormEvent : Form
    {
        private Coord location;

        public FormEvent(Coord loc)
        {
            InitializeComponent();

            location = loc;
        }

        private void facebookPicturebox_Click(object sender, EventArgs e)
        {
            FacebookForm ev = new FacebookForm(location);
            ev.ShowDialog();            
        }

        private void twitterPicturebox_Click(object sender, EventArgs e)
        {
            TweetForm ev = new TweetForm(location);
            ev.ShowDialog();
        }

        private void imagePicturebox_Click(object sender, EventArgs e)
        {
            ImageForm ev = new ImageForm(location);
            ev.ShowDialog();
        }

        private void videoPicturebox_Click(object sender, EventArgs e)
        {
            VideoForm ev = new VideoForm(location);
            ev.ShowDialog();
        }

        private void personPicturebox_Click(object sender, EventArgs e)
        {
            PersonForm ev = new PersonForm(location);
            ev.ShowDialog();
        }
    }
}
