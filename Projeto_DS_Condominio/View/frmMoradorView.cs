﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_DS_Condominio.View
{
    public partial class frmMoradorView : Form, IMoradorView
    {
        public frmMoradorView()
        {
            InitializeComponent();
        }

        private static frmMoradorView instance;
        internal static frmMoradorView GetInstance(frmMainView mainView)
        {
            if (instance == null || instance.IsDisposed)
                instance = new frmMoradorView();
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
