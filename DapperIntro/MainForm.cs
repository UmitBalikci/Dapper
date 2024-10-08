﻿using DapperIntro.DbHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperIntro
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuItemAllCategories_Click(object sender, EventArgs e)
        {
            var categoryGridForm = new CategoryGridForm();
            categoryGridForm.Owner = this;
            categoryGridForm.Show();
        }

        private void menuItemNewCategory_Click(object sender, EventArgs e)
        {
            var categoryCreateForm = new CategoryCreateForm();
            categoryCreateForm.Owner = this;
            categoryCreateForm.FormClosed += CategoryCreateForm_FormClosed;
            categoryCreateForm.Show();
        }

        private void CategoryCreateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void menuItemAllProduct_Click(object sender, EventArgs e)
        {
            var productGridForm = new ProductGridForm();
            productGridForm.Owner = this;
            productGridForm.Show();
            
        }

        private void menuItemNewProduct_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreateForm();
            productCreateForm.Owner = this;
            productCreateForm.Show();

        }
    }
}
