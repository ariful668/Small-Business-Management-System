using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SmallBusinessManagement.ViewModel;
using SmallBusinessManagement.Model;

namespace SmallBusinessManagement.Repository
{
    public class ReportOnSalesRepository
    {
        public List<SalesReportingView> SearchValue(string Date, string Date2)
        {
            string connectionString = @"Server=DESKTOP-IL4U8GL; Database=SmallBusiness; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM SalesReport WHERE SalesDate BETWEEN '" + Date + "' AND '" + Date2 + "'";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();

            List<SalesReportingView> salesReportingViews = new List<SalesReportingView>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                SalesReportingView _salesReportingView = new SalesReportingView();


                _salesReportingView.SalesDate = Convert.ToString(sqlDataReader["SalesDate"]);
                _salesReportingView.Code = Convert.ToString(sqlDataReader["Code"]);
                _salesReportingView.Product = Convert.ToString(sqlDataReader["Product"]);
                _salesReportingView.Category = Convert.ToString(sqlDataReader["Category"]);

                _salesReportingView.Sold_Qty = Convert.ToInt32(sqlDataReader["Sold_Qty"]);

                _salesReportingView.CP = Convert.ToDouble(sqlDataReader["CP"]);
                _salesReportingView.Sales_price = Convert.ToDouble(sqlDataReader["Sales_Price"]);
                _salesReportingView.Profit = Convert.ToDouble(sqlDataReader["Profit"]);

                salesReportingViews.Add(_salesReportingView);
            }

            sqlConnection.Close();

            return salesReportingViews;
        }
        public List<SalesReportingView> Display(SalesReportingView salesReportingView)
        {
            string connectionString = @"Server=DESKTOP-IL4U8GL; Database=SmallBusiness; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM SalesReport ";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();

            List<SalesReportingView> salesReportingViews = new List<SalesReportingView>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                SalesReportingView _salesReportingView = new SalesReportingView();

                _salesReportingView.SalesDate = Convert.ToString(sqlDataReader["SalesDate"]);
                _salesReportingView.Code = Convert.ToString(sqlDataReader["Code"]);
                _salesReportingView.Product = Convert.ToString(sqlDataReader["Product"]);
                _salesReportingView.Category = Convert.ToString(sqlDataReader["Category"]);

                _salesReportingView.Sold_Qty = Convert.ToInt32(sqlDataReader["Sold_Qty"]);

                _salesReportingView.CP = Convert.ToDouble(sqlDataReader["CP"]);
                _salesReportingView.Sales_price = Convert.ToDouble(sqlDataReader["Sales_Price"]);
                _salesReportingView.Profit = Convert.ToDouble(sqlDataReader["Profit"]);

                salesReportingViews.Add(_salesReportingView);
            }

            sqlConnection.Close();

            return salesReportingViews;
        }
    }
}
