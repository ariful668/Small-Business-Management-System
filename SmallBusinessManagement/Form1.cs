using SmallBusinessManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = dashboardButton.Height;
            panelLeft.Top = dashboardButton.Top;
        }

        private void SuppliersButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = suppliersButton.Height;
            panelLeft.Top = suppliersButton.Top;

            SupplierUi Check = new SupplierUi();
            Check.Show();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = customersButton.Height;
            panelLeft.Top = customersButton.Top;

            CustomerUi Check = new CustomerUi();
            Check.Show();

        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = productsButton.Height;
            panelLeft.Top = productsButton.Top;

            ProductUi Check = new ProductUi();
            Check.Show();
        }

        private void CategoriesButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = categoriesButton.Height;
            panelLeft.Top = categoriesButton.Top;

            CategoryUi Check = new CategoryUi();
            Check.Show();
        }

        private void PurchaseButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = purchaseButton.Height;
            panelLeft.Top = purchaseButton.Top;
            PurchaseUi Check = new PurchaseUi();
            Check.Show();
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = salesButton.Height;
            panelLeft.Top = salesButton.Top;
            SalesUi Check = new SalesUi();
            Check.Show();
        }

        private void StockButton_Click(object sender, EventArgs e)
        {
            panelLeft.Height = stockButton.Height;
            panelLeft.Top = stockButton.Top;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void PanelLeft_Click(object sender, EventArgs e)
        {

        }

    }
}
