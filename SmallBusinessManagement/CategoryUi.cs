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
using System.Text.RegularExpressions;

namespace SmallBusinessManagement
{
    public partial class CategoryUi : Form
    {
        CategoryManager _categoryManager = new CategoryManager();
        Category category = new Category();
        int id;
        public CategoryUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            category.Code =codeTextBox.Text;
            category.Name = nameTextBox.Text;

            if (saveButton.Text == "Update")
            {
                if (_categoryManager.IsUpdateCategory(category))
                {
                    MessageBox.Show("Category Updated Successfully");
                    //Edit();
                    List<Category> categories = _categoryManager.DisplayCategory();
                    showDataGridView.DataSource = categories;
                    saveButton.Text = "Save";
                    SL();
                    Clear();
                    return;
                }
                else
                {
                    MessageBox.Show("Category Not Updated, Check details");
                    return;
                }
            }

            if (category.Code =="")
            {
                MessageBox.Show("Code Filed is Required");
                codeTextBox.Clear();
                return;
            }
            else if (!CheckIfNumeric(category.Code))
            {
                MessageBox.Show("Please enter numeric code.");
                codeTextBox.Clear();
                return;
            }
            else if (category.Code.Length != 4)
            {
                MessageBox.Show("Code filed is required 4 digit length");
                codeTextBox.Clear();
                return;
            }
            else if (_categoryManager.IsExistCode(category))
            {
                MessageBox.Show("Code is already exist");
                codeTextBox.Clear();
                return;
            }

            if (category.Name == "")
            {
                MessageBox.Show("Name Filed is Required");
                return;
            }
            else if (CheckIfNumeric(category.Name))
            {
                MessageBox.Show("Required Name in this field.");
                nameTextBox.Clear();
                return;
            }
            else if (_categoryManager.IsExistName(category))
            {
                MessageBox.Show("Name is already exist");
                nameTextBox.Clear();
                return;
            }

            if (_categoryManager.AddCategory(category))
            {
                MessageBox.Show("Category Added Successfully");
                //Edit();
                List<Category> categories = _categoryManager.DisplayCategory();
                showDataGridView.DataSource = categories;
                //saveButton.Text = "Update";
                SL();
                Clear();
            }
            else
            {
                MessageBox.Show("Category Not Added");
            }
        }

        private void Edit()
        {
            DataGridViewLinkColumn Editlink = new DataGridViewLinkColumn();
            Editlink.UseColumnTextForLinkValue = true;
            Editlink.HeaderText = "Action";
            Editlink.DataPropertyName = "lnkColumn";
            Editlink.LinkBehavior = LinkBehavior.SystemDefault;
            Editlink.Text = "Edit";
            showDataGridView.Columns.Add(Editlink);
        }
        public void Clear()
        {
            codeTextBox.Text = "";
            nameTextBox.Text = "";
            
        }

        public bool CheckIfNumeric(string input)
        {
            return input.IsNumeric();
        }
        public void SL()
        {
            int i = 1;
            foreach (DataGridViewRow rows in showDataGridView.Rows)
            {
                rows.Cells[0].Value = i;
                i++;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            List<Category> categories = _categoryManager.DisplayCategory();
            showDataGridView.DataSource = categories;
            SL();
            saveButton.Text = "Save";
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.CurrentRow.Index != -1)
            {
                saveButton.Text = "Update";
                id = Convert.ToInt32(showDataGridView.CurrentRow.Cells[1].Value.ToString());
                codeTextBox.Text = showDataGridView.CurrentRow.Cells[2].Value.ToString();
                nameTextBox.Text = showDataGridView.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            category.Code = codeTextBox.Text;
            category.Name = nameTextBox.Text;
            if (_categoryManager.DeleteCategory(category))
            {
                MessageBox.Show("Category Deleted Successfully..");
                Clear();
                List<Category> categories = _categoryManager.DisplayCategory();
                showDataGridView.DataSource = categories;
                SL();
                saveButton.Text = "Save";
            }
            else
            {
                MessageBox.Show("Category Not Deleted..");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            string criteria = searchTextBox.Text;
            if (criteria == "")
            {
                MessageBox.Show("To searching field is required..");
            }

            //Edit();
            List<Category> categories = _categoryManager.SearchCategory(criteria);
            showDataGridView.DataSource = categories;
            SL();
        }

        private void ShowDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void CategoryUi_Load(object sender, EventArgs e)
        {
            List<Category> categories = _categoryManager.DisplayCategory();
            showDataGridView.DataSource = categories;
        }
    }
   
}
public static class StringExtensions
{
    public static bool IsNumeric(this string input)
    {
        return Regex.IsMatch(input, @"^\d+$");
    }
}
