﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoggingWriteJsonWinFrmQ1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CreateLogger();
        }
        
        public void CreateLogger()
        {
            Logger1 lg = new Logger1();
            lg.CreateLogger();
        }
    }
}
