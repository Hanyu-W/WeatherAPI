﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAPI
{
    public partial class frmWeatherAPI : Form
    {
        public frmWeatherAPI()
        {
            InitializeComponent();
        }

        private void frmWeatherAPI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}