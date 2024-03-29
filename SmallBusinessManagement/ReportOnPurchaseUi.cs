﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagement.Model;
using SmallBusinessManagement.BLL;


namespace SmallBusinessManagement
{
    public partial class ReportOnPurchaseUi : Form
    {
        ReportOnPurchaseManager _reportOnPurchaseManager = new ReportOnPurchaseManager();
        
        public ReportOnPurchaseUi()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();

            purchase.Date1 = startDateTimePicker.Value;
            purchase.Date2 = endDateTimePicker.Value;

            showDataGridView.DataSource = _reportOnPurchaseManager.Search(purchase);
            
        }
    }
}
