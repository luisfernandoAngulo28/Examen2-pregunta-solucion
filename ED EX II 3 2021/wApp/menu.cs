﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace wApp
{
    public partial class menu : Form
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new menu());
          
        }

        public menu()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void cmdColaC_Click(object sender, EventArgs e)
        {
            FListaS forListaS = new FListaS();
            forListaS.Show();
        }

      
        //private void cmdPilaM_Click(object sender, EventArgs e)
        //{
            
        //}

 
       
     
    }
}
