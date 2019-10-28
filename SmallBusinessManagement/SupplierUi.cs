using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagement.BLL;
using SmallBusinessManagement.Model;


namespace SmallBusinessManagement
{
    public partial class SupplierUi : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        int indexRow;
        public SupplierUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            //Manadatory
            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code can not be Empty!!");
                return;
            }
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name can not be Empty!!");
                return;
            }
            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("Contact can not be Empty!!");
                return;
            }
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a email!!");
                return;
            }
            supplier.code = Convert.ToInt32(codeTextBox.Text);
            supplier.name = nameTextBox.Text;
            supplier.address = addressTextBox.Text;
            supplier.contact = contactTextBox.Text;
            supplier.email = emailTextBox.Text;
            supplier.contactperson = contactPersonTextBox.Text;



            //Unique
            if (_supplierManager.IsCodeExist(supplier))
            {
                MessageBox.Show(nameTextBox.Text + " Code Already Exist!!");
                return;
            }
            if (_supplierManager.IsContactExist(supplier))
            {
                MessageBox.Show(nameTextBox.Text + "Contact Already Exist!!");
                return;
            }
            if (_supplierManager.IsEmailExist(supplier))
            {
                MessageBox.Show(emailTextBox.Text + "Email Alraedy Exist!!");
            }

            //Validity
            if (codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code must be within 4 characters");
            }



            //Add/Insert
            if (_supplierManager.Add(supplier))
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _supplierManager.Display();
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            contactPersonTextBox.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            //Manadatory
            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code can not be Empty!!");
                return;
            }
            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Name can not be Empty!!");
                return;
            }
            if (String.IsNullOrEmpty(contactTextBox.Text))
            {
                MessageBox.Show("Contact can not be Empty!!");
                return;
            }
            if (String.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Please enter a email!!");
                return;
            }
            supplier.code = Convert.ToInt32(codeTextBox.Text);
            supplier.name = nameTextBox.Text;
            supplier.address = addressTextBox.Text;
            supplier.contact = contactTextBox.Text;
            supplier.email = emailTextBox.Text;
            supplier.contactperson = contactPersonTextBox.Text;



            //Unique
            //if (_supplierManager.IsCodeExist(supplier))
            //{
            //    MessageBox.Show(nameTextBox.Text + " Code Already Exist!!");
            //    return;
            //}
            //if (_supplierManager.IsContactExist(supplier))
            //{
            //    MessageBox.Show(nameTextBox.Text + "Contact Already Exist!!");
            //    return;
            //}
            //if (_supplierManager.IsEmailExist(supplier))
            //{
            //    MessageBox.Show(emailTextBox.Text + "Email Alraedy Exist!!");
            //}

            //Validity
            if (codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code must be within 4 characters");
            }



            //Update/Insert
            if (_supplierManager.Update(supplier))
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _supplierManager.Display();
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            contactPersonTextBox.Clear();
        }




        private void searchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _supplierManager.Search(searchTextBox.Text, searchTextBox.Text, searchTextBox.Text);
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void SupplierUi_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _supplierManager.Display();
        }

        private void showDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex;
            DataGridViewRow row = showDataGridView.Rows[indexRow];
            codeTextBox.Text = row.Cells[1].Value.ToString();
            nameTextBox.Text = row.Cells[2].Value.ToString();
            addressTextBox.Text = row.Cells[3].Value.ToString();
            emailTextBox.Text = row.Cells[4].Value.ToString();
            contactTextBox.Text = row.Cells[5].Value.ToString();
            contactPersonTextBox.Text = row.Cells[6].Value.ToString();


        }
    }
}
