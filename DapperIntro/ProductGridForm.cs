using Dapper;
using DapperIntro.DbHelpers;
using DapperIntro.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperIntro
{
    public partial class ProductGridForm : Form
    {
        public ProductGridForm()
        {
            InitializeComponent();
        }

        private void ProductGridForm_Load(object sender, EventArgs e)
        {
            using (var connection = DbConnectionFactory.Create())
            {
                const string sqlText = "SELECT * FROM Products";
                var productList = connection.Query<Product>(sqlText);

                grdProduct.DataSource = productList;
                

            }
        }
    }
}
