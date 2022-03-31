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
    public partial class ProductCreateForm : Form
    {
        public ProductCreateForm()
        {
            InitializeComponent();
        }

        private void ProductCreateForm_Load(object sender, EventArgs e)
        {
            FillCategoryComboBox();
            FillSuplierComboBox();
        }

        private void FillSuplierComboBox()
        {
            using (var connection = DbConnectionFactory.Create())
            {
                const string sqlText = "select * from Suppliers";
                var supplier = connection.Query<Supplier>(sqlText);
                cmbSupplierName.DataSource = supplier;
                cmbSupplierName.DisplayMember = "CompanyName";
                cmbSupplierName.ValueMember = "SupplierID";
            }
        }

        private void FillCategoryComboBox()
        {
            using (var connection = DbConnectionFactory.Create())
            {
                const string sqlText = "select * from Categories";
                var categoryy = connection.Query<Category>(sqlText);
                cmbCategoryName.DataSource = categoryy;
                cmbCategoryName.DisplayMember = "CategoryName";
                cmbCategoryName.ValueMember = "CategoryID";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var product = new Product()
            {
                ProductName = txtProductName.Text.Trim(),
                CategoryID = (int)cmbCategoryName.SelectedValue,
                SupplierID = (int)cmbSupplierName.SelectedValue,
                QuantityPerUnit = txtQuantityPerUnit.Text.Trim(),
                UnitPrice = numUnitPrice.Value,
                UnitsInStock = (short)numUnitsInStock.Value,
                UnitsOnOrder = (short)numUnitsOnOrder.Value,
                ReorderLevel = (short)numReorderLevel.Value,
                Discontinued = chkPasif.Checked

            };
            const string sqlText = @"
INSERT INTO 
Products (ProductName, CategoryID, SupplierID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
VALUES (@productName, @categoryID,
@supplierID,
@quantityPerUnit,
@unitPrice, 
@unitsInStock,
@unitsOnOrder,
@reorderLevel,
@discontinued
)";

            

            using (var connection = DbConnectionFactory.Create())
            {
                
                try
                {
                    var parameters = new
                    {
                        productName = product.ProductName,
                        categoryID = product.CategoryID,
                        supplierID = product.SupplierID,
                        quantityPerUnit = product.QuantityPerUnit,
                        unitPrice = product.UnitPrice,
                        unitsInStock = product.UnitsInStock,
                        unitsOnOrder = product.UnitsOnOrder,
                        reorderLevel = product.ReorderLevel,
                        discontinued = product.Discontinued
                    };
                    connection.Execute(sqlText, parameters);
                    MessageBox.Show("Ademciğimmmm");
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Hata\n" + ex.Message);
                }

            }
        }
    }
}
