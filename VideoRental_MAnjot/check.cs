using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VideoRental_MAnjot
{
    public class check
    {
        //global declaration of the variable 
        SqlConnection conn;
        String conStr = "Data Source=LAPTOP-RFTA97Q7\\SQLEXPRESS01;Initial Catalog=Video_Rental_Manjot;Integrated Security=True";
        SqlCommand cmd;
        SqlDataReader DReader;




        // user define method that is used to get the record from the table
        public int srchCustomerID(int CustomerID)
        {
            DataTable tbl = new DataTable();


            conn = new SqlConnection(conStr);

            conn.Open();
            cmd = new SqlCommand("select * from Rent where CustID="+CustomerID+" and DateReturn='Rent'", conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl.Rows.Count;
        }

        // user define method that is used to get the record from the table
        public int srchMovieID(int MovieID)
        {
            DataTable tbl = new DataTable();


            conn = new SqlConnection(conStr);

            conn.Open();
            cmd = new SqlCommand("select * from Rent where MovieID=" + MovieID + " and DateReturn='Rent'", conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl.Rows.Count;
        }

        public int generateRent(String IssueDate,int Cost) {

            DateTime Current_date = DateTime.Now;

            //convert the old date from string to Date fromat
            DateTime Old_date = Convert.ToDateTime(IssueDate);


            //get the difference in the days fromat
            String diff = (Current_date - Old_date).TotalDays.ToString();


            // calculate the round off value 
            Double Days = Math.Round(Convert.ToDouble(diff));

            //            MessageBox.Show("" + Days);
            // return the total cost of the Video



            int Price = Convert.ToInt32(Days) * Cost;

            return (Price);

        }


    }
}
