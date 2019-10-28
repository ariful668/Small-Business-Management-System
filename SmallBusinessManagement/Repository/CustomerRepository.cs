using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SmallBusinessManagement.BLL;
using SmallBusinessManagement.Model;

namespace SmallBusinessManagement.Repository
{
    public class CustomerRepository
    {
        public bool Add(Customer customer)
        {
            bool isAdded = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-8RCCAHG; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"INSERT INTO Customers (Code,Name, Address,Email, Contact,Loyality) Values (" + customer.Code + ",'" + customer.Name + "','" + customer.Address + "', '" + customer.Email + "','" + customer.Contact + "'," + customer.Loyality + ")";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();
                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    isAdded = true;
                }

                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {

            }

            return isAdded;

        }

        public bool IsCodeExist(Customer customer)
        {
            bool isExist = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-8RCCAHG; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Customers WHERE Code=" + customer.Code + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isExist = true;
                }


                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {

            }
            return isExist;
        }
        public bool IsContactExist(Customer customer)
        {
            bool isExist = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-8RCCAHG; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Customers WHERE Contact='" + customer.Contact + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isExist = true;
                }


                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {

            }
            return isExist;
        }
        public bool IsEmailExist(Customer customer)
        {
            bool isExist = false;
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-8RCCAHG; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Customers WHERE Code='" + customer.Email + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    isExist = true;
                }


                //Close
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {

            }
            return isExist;
        }

        public bool Update(Customer customer)
        {
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-8RCCAHG; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"UPDATE Customers SET Name= '" + customer.Name + "' , Address = '" + customer.Address + "',Email = '" + customer.Email + "', Contact = '" + customer.Contact + "',Loyality=" + customer.Loyality + " WHERE Code = " + customer.Code + "";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Insert
                int isExecuted = sqlCommand.ExecuteNonQuery();
                if (isExecuted > 0)
                {
                    return true;
                }
                //Close
                sqlConnection.Close();


            }
            catch (Exception exeption)
            {
            }
            return false;
        }

        public DataTable Display()
        {

            //Connection
            string connectionString = @"Server=DESKTOP-8RCCAHG; Database=SmallBusiness; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            string commandString = @"SELECT * FROM Customers";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();

            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //Close
            sqlConnection.Close();

            return dataTable;

        }
        public DataTable Search(string contact, string name, string email)
        {
            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                string connectionString = @"Server=DESKTOP-8RCCAHG; Database=SmallBusiness; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Customers WHERE Name='" + name + "'or Contact='" + contact + "'or Email='" + email + "'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                sqlConnection.Close();

            }
            catch (Exception exeption)
            {

            }

            return dataTable;
        }
    }
}
