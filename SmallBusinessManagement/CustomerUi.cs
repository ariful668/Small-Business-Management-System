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
using System.Data.SqlClient;
using System.Configuration;


namespace SmallBusinessManagement
{
    public partial class CustomerUi : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        int indexRow;
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

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
            customer.Code = Convert.ToInt32(codeTextBox.Text);
            customer.Name = nameTextBox.Text;
            customer.Address = addressTextBox.Text;
            customer.Contact = contactTextBox.Text;
            customer.Email = emailTextBox.Text;
            customer.Loyality = Convert.ToInt32(loyalityPointTextBox.Text);



            //Unique
            if (_customerManager.IsCodeExist(customer))
            {
                MessageBox.Show(nameTextBox.Text + " Code Already Exist!!");
                return;
            }
            if (_customerManager.IsContactExist(customer))
            {
                MessageBox.Show(nameTextBox.Text + "Contact Already Exist!!");
                return;
            }
            if (_customerManager.IsEmailExist(customer))
            {
                MessageBox.Show(emailTextBox.Text + "Email Alraedy Exist!!");
            }

            //Validity
            if (codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code must be within 4 characters");
            }



            //Add/Insert
            if (_customerManager.Add(customer))
            {
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _customerManager.Display();
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            loyalityPointTextBox.Clear();
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

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
            customer.Code = Convert.ToInt32(codeTextBox.Text);
            customer.Name = nameTextBox.Text;
            customer.Address = addressTextBox.Text;
            customer.Contact = contactTextBox.Text;
            customer.Email = emailTextBox.Text;
            customer.Loyality = Convert.ToInt32(loyalityPointTextBox.Text);



            //Unique
            //if (_customerManager.IsCodeExist(customer))
            //{
            //    MessageBox.Show(nameTextBox.Text + " Code Already Exist!!");
            //    return;
            //}
            //if (_customerManager.IsContactExist(customer))
            //{
            //    MessageBox.Show(nameTextBox.Text + "Contact Already Exist!!");
            //    return;
            //}
            //if (_customerManager.IsEmailExist(customer))
            //{
            //    MessageBox.Show(emailTextBox.Text + "Email Alraedy Exist!!");
            //}

            //Validity
            if (codeTextBox.Text.Length != 4)
            {
                MessageBox.Show("Code must be within 4 characters");
            }



            //Update/Insert
            if (_customerManager.Update(customer))
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Not Updated");
            }
            //showDataGridView.DataSource = dataTable;
            showDataGridView.DataSource = _customerManager.Display();
            codeTextBox.Clear();
            nameTextBox.Clear();
            addressTextBox.Clear();
            emailTextBox.Clear();
            contactTextBox.Clear();
            loyalityPointTextBox.Clear();
        }

        private void CustomerUi_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManager.Display();
        }

        private void ShowDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManager.Search(searchTextBox.Text, searchTextBox.Text, searchTextBox.Text);
        }

        private void ShowDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = showDataGridView.Rows[indexRow];
            codeTextBox.Text = row.Cells[1].Value.ToString();
            nameTextBox.Text = row.Cells[2].Value.ToString();
            addressTextBox.Text = row.Cells[3].Value.ToString();
            emailTextBox.Text = row.Cells[4].Value.ToString();
            contactTextBox.Text = row.Cells[5].Value.ToString();
            loyalityPointTextBox.Text = row.Cells[6].Value.ToString();
        }

        
    }
}
