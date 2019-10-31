using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagement.Model;
using SmallBusinessManagement.ViewModel;
using SmallBusinessManagement.BLL;

namespace SmallBusinessManagement
{
    public partial class ReportOnSalesUi : Form
    {
        ReportOnSalesManager _reportOnSalesManager = new ReportOnSalesManager();
        public ReportOnSalesUi()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SalesReportingView salerepot = new SalesReportingView();

            if (dateTimePicker1.Text == " ")
            {
                MessageBox.Show("please insert start date");
                return;

            }
            if (dateTimePicker2.Text == " ")
            {
                MessageBox.Show("please insert end date");
                return;

            }
            string Date;
            string Date2;
            Date = dateTimePicker1.Text;
            Date2 = dateTimePicker2.Text;


            showDataGridView.DataSource = _reportOnSalesManager.SearchValue(dateTimePicker1.Text, dateTimePicker2.Text);

        }

        private void ReportOnSalesUi_Load(object sender, EventArgs e)
        {
            SalesReportingView salerepot = new SalesReportingView();
            showDataGridView.DataSource = _reportOnSalesManager.Display(salerepot);
        }
    }
}
