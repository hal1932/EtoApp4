﻿using System;
using System.Collections.Generic;
using Eto.Forms;
using Eto.Drawing;
using Eto.Serialization.Xaml;

namespace EtoApp4
{
    public class MainForm : Form
    {
        public MainForm()
        {
            XamlReader.Load(this);
        }

        protected void HandleClickMe(object sender, EventArgs e)
        {
            MessageBox.Show("I was clicked!");
        }

        protected void HandleQuit(object sender, EventArgs e)
        {
            Application.Instance.Quit();
        }
    }
}
