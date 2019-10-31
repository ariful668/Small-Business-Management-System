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
    public class SupplierRepository
    {
        string connectionString = @"Server = DESKTOP-IL4U8GL; Database = SmallBusiness;
                Integrated Security = true";

        public bool Add(Supplier supplier)
        {
            bool isAdded = false;
            try
            {
                //Connection

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"INSERT INTO Suppliers (Code,Name, Address,Email, Contact,ContactPerson) Values ('" + supplier.code + "','" + supplier.name + "','" + supplier.address + "', '"+supplier.email+"','" + supplier.contact + "','" + supplier.contactperson + "')";
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

        public bool IsCodeExist(Supplier supplier)
        {
            bool isExist = false;
            try
            {
                //Connection
               
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Suppliers WHERE Code='" + supplier.code + "'";
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
        public bool IsContactExist(Supplier supplier)
        {
            bool isExist = false;
            try
            {
                //Connection
                
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Suppliers WHERE Contact='" + supplier.contact + "'";
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
        public bool IsEmailExist(Supplier supplier)
        {
            bool isExist = false;
            try
            {
                //Connection
                
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Suppliers WHERE Code='" + supplier.email + "'";
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

        public bool Update(Supplier supplier)
        {
            try
            {
                //Connection

                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"UPDATE Suppliers SET Name= '" + supplier.name + "' , Address = '" + supplier.address + "',Email = '" + supplier.email + "', Contact = '" + supplier.contact + "',ContactPerson='" + supplier.contactperson + "' WHERE Code = " + supplier.code + "";
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
           
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            string commandString = @"SELECT * FROM Suppliers";
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
        public DataTable Search(string contact,string name,string email)
        {
            DataTable dataTable = new DataTable();
            try
            {
                //Connection
                
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                //Command 
                string commandString = @"SELECT * FROM Suppliers WHERE Name='"+name+"'Or Contact='"+contact+"'Or Email='"+email+"'";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                //Open
                sqlConnection.Open();

                //Show
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                //DataTable dataTable = new DataTe);
                sqlConnection.Close();

                sqlDataAdapter.Fill(dataTable);
            }
            catch (Exception exeption)
            {

            }

            return dataTable;
        }
    }
}
