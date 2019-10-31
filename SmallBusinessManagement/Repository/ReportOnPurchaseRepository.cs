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
    public class ReportOnPurchaseRepository
    {
        public List<PurchaseReportingView> SearchValue(string Date, string Date2)
        {
            string connectionString = @"Server=DESKTOP-IL4U8GL; Database=SmallBusiness; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM PurchaseReport WHERE PurchaseDate BETWEEN '" + Date + "' AND '" + Date2 + "'";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();

            List<PurchaseReportingView> purchaseReportingViews = new List<PurchaseReportingView>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                PurchaseReportingView _purchaseReportingView = new PurchaseReportingView();


               _purchaseReportingView.PurchaseDate = Convert.ToString(sqlDataReader["PurchaseDate"]);
                _purchaseReportingView.Code = Convert.ToString(sqlDataReader["Code"]);
                _purchaseReportingView.Product = Convert.ToString(sqlDataReader["Product"]);
               _purchaseReportingView.Category = Convert.ToString(sqlDataReader["Category"]);

                _purchaseReportingView.AvailableQuantiy = Convert.ToInt32(sqlDataReader["AvailableQuantiy"]);

                _purchaseReportingView.CP = Convert.ToDouble(sqlDataReader["CP"]);
                _purchaseReportingView.Salesprice = Convert.ToDouble(sqlDataReader["SalesPrice"]);
               _purchaseReportingView.Profit = Convert.ToDouble(sqlDataReader["Profit"]);

                purchaseReportingViews.Add(_purchaseReportingView);
            }

            sqlConnection.Close();

            return purchaseReportingViews;
        }
        public List<PurchaseReportingView> Display(PurchaseReportingView purchaseReportingView)
        {
            string connectionString = @"Server=DESKTOP-IL4U8GL; Database=SmallBusiness; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string CommandString = @"SELECT * FROM PurchaseReport";

            SqlCommand sqlCommand = new SqlCommand(CommandString, sqlConnection);
            sqlConnection.Open();

            List<PurchaseReportingView> purchaseReportingViews = new List<PurchaseReportingView>();

            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
               PurchaseReportingView _purchaseReportingView = new PurchaseReportingView();

                _purchaseReportingView.PurchaseDate = Convert.ToString(sqlDataReader["PurchaseDate"]);
                _purchaseReportingView.Code = Convert.ToString(sqlDataReader["Code"]);
                _purchaseReportingView.Product = Convert.ToString(sqlDataReader["Product"]);
                _purchaseReportingView.Category = Convert.ToString(sqlDataReader["Category"]);

                _purchaseReportingView.AvailableQuantiy = Convert.ToInt32(sqlDataReader["AvailableQuantiy"]);

                _purchaseReportingView.CP = Convert.ToDouble(sqlDataReader["CP"]);
                _purchaseReportingView.Salesprice = Convert.ToDouble(sqlDataReader["SalesPrice"]);
                _purchaseReportingView.Profit = Convert.ToDouble(sqlDataReader["Profit"]);

                purchaseReportingViews.Add(_purchaseReportingView);


            }

            sqlConnection.Close();

            return purchaseReportingViews;
        }

    }
}
