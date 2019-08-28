using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace VideoRental_MAnjot
{
    public partial class Form1 : Form
    {
        //global declaration of the variable 
        SqlConnection conn;
        String conStr = "Data Source=LAPTOP-RFTA97Q7\\SQLEXPRESS01;Initial Catalog=Video_Rental_Manjot;Integrated Security=True";
        SqlCommand cmd;
        SqlDataReader DReader;
        
        //creating the object of the table
        check instance = new check();

        //these varaible are used to display the record of the table in the relevent boxes
        int videoCountrer = 0, RentCounter = 0, CustomerCounter = 0;

        int videoPrice = 0, VideoCopy = 0;

        //this method is used to add the record in the Table for permanent 
        public void Insert(String query)
        {

            conn = new SqlConnection(conStr);
                                                    conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //this method is used to Delete the record in the Table for permanent 
        public void Delete(String query)
        {

            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }




        //this method is used to Update the record in the Table for permanent 
        public void Update(String query)
        {
            conn = new SqlConnection(conStr);
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }


        // user define method that is used to get the record from the table
        public DataTable Srch(String qry)
        {
            DataTable tbl = new DataTable();


            conn = new SqlConnection(conStr);

            conn.Open();
            cmd = new SqlCommand(qry, conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }
        //this code id used to get  the record from the Table of the Customer

        public DataTable tblCustomer()
        {
            DataTable tbl = new DataTable();


            conn = new SqlConnection(conStr);

            conn.Open();
            cmd = new SqlCommand("select * from Customer", conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }

        //this code id used to get  the record from the Table of the Video

        public DataTable tblVideo()
        {
            DataTable tbl = new DataTable();


            conn = new SqlConnection(conStr);

            conn.Open();
            cmd = new SqlCommand("select * from Video", conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }



        //this code id used to get  the record from the Table of the Rent

        public DataTable tblRent()
        {
            DataTable tbl = new DataTable();


            conn = new SqlConnection(conStr);

            conn.Open();
            cmd = new SqlCommand("select * from Rent", conn);

            DReader = cmd.ExecuteReader();

            tbl.Load(DReader);

            conn.Close();

            return tbl;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            if(TxtName.Text.ToString().Equals("") && Address.Text.ToString().Equals("") && MobileNo.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill Proper Record ");
            }
            else
            {
                //with the help of this code we can store the record of the txtboxes in the database 
                String query = "insert into Customer (Name,MobileNo,Address) values('" + TxtName.Text.ToString() +
                               "','" + MobileNo.Text.ToString() + "','" + Address.Text.ToString() + "')";
                Insert(query);
                //printing the message after saving the record in the table
                MessageBox.Show("Customer Record is Insert in the database");

                TxtName.Text = "";
                MobileNo.Text = "";
                Address.Text = "";
            }
        }

        private void delCustomer_Click(object sender, EventArgs e)
        {
            int chkID = instance.srchCustomerID(Convert.ToInt32(CustomerID.Text.ToString()));
            if (chkID == 0) {
                //this code is used to delete the record of the table 
                String query = "delete from Customer where id=" + Convert.ToInt32(CustomerID.Text.ToString()) + "";
                Delete(query);
                //after deleting the record the message will be print for the confirmation;
                MessageBox.Show("Record is Deleted from the Database of the Customer");

                TxtName.Text = "";
                MobileNo.Text = "";
                Address.Text = "";

            }
            else {
                MessageBox.Show("You already have a Video on rent to can't be delete");
            }

        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            ///this code is used to update the record of the table
            String query = "update customer set Name='" + TxtName.Text.ToString() + "',MobileNo='" + MobileNo.Text.ToString() + "',Address='" + Address.Text.ToString() + "'";
            Update(query);
            MessageBox.Show("Record is Updated from the Database of the Customer");

            TxtName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";

        }

        private void AddVideo_Click(object sender, EventArgs e)
        {
            if (Txttitle.Text.ToString().Equals("") && TxtRatting.Text.ToString().Equals("") &&
                TxtYear.Text.ToString().Equals("") && Txtcost.Text.ToString().Equals("") &&
                TxtCopies.Text.ToString().Equals("") && TxtGenre.Text.ToString().Equals("") &&
                TxtPlot.Text.ToString().Equals(""))
            {
                MessageBox.Show("Fill all Record");

            }
            else
            {
                String query = "insert into Video(Title,Ratting,Year,Cost,Copy,Plot,Genre) values('" +
                               Txttitle.Text.ToString() + "','" + TxtRatting.Text.ToString() + "'," +
                               Convert.ToInt32(TxtYear.Text.ToString()) + "," +
                               Convert.ToInt32(Txtcost.Text.ToString()) + "," +
                               Convert.ToInt32(TxtCopies.Text.ToString()) + ",'" + TxtPlot.Text.ToString() + "','" +
                               TxtGenre.Text.ToString() + "')";
                Insert(query);
                MessageBox.Show("Video Record is Saved in the database");
                Txttitle.Text = "";
                TxtRatting.Text = "";
                TxtYear.Text = "";
                TxtCopies.Text = "";
                Txtcost.Text = "";
                TxtPlot.Text = "";
                TxtGenre.Text = "";

            }
        }

        private void delVideo_Click(object sender, EventArgs e)
        {

            int chk = instance.srchMovieID(Convert.ToInt32(MovieID.Text.ToString()));
            if (chk == 0)
            {
                // this query is used to delete the record of the video from the database
                String query = "delete from Video  where id=" + Convert.ToInt32(MovieID.Text.ToString()) + "";
                Delete(query);
                MessageBox.Show("Record is Deleted");

                Txttitle.Text = "";
                TxtRatting.Text = "";
                TxtYear.Text = "";
                TxtCopies.Text = "";
                Txtcost.Text = "";
                TxtPlot.Text = "";
                TxtGenre.Text = "";

            }
            else {
                MessageBox.Show("Video is already on rent soo return first");
            }

        }

        private void updateVideo_Click(object sender, EventArgs e)
        {
            //this query is used to update the record of the video from the database
            String query = "update Video set Title='" + Txttitle.Text.ToString() + "',Ratting='" + TxtRatting.Text.ToString() + "',Year=" + Convert.ToInt32(TxtYear.Text.ToString()) + ",Cost=" + Convert.ToInt32(Txtcost.Text.ToString()) + ",Copy=" + Convert.ToInt32(TxtCopies.Text.ToString()) + ",plot='" + TxtPlot.Text.ToString() + "',Genre='" + TxtGenre.Text.ToString() + "' where id=" + Convert.ToInt32(MovieID.Text.ToString()) + "";
            Update(query);
            MessageBox.Show("Record is Updated of the Video in the Database");
            Txttitle.Text = "";
            TxtRatting.Text = "";
            TxtYear.Text = "";
            TxtCopies.Text = "";
            Txtcost.Text = "";

            TxtPlot.Text = "";
            TxtGenre.Text = "";

        }

        private void rentalIssueVideo_Click(object sender, EventArgs e)
        {
            if (CustomerID.Text.ToString().Equals("") && MovieID.Text.ToString().Equals(""))
            {
                MessageBox.Show("Select the Movie and Custoemr Record first then You can book a Movie");
            }
            else
            {
                int chk = instance.srchCustomerID(Convert.ToInt32(CustomerID.Text.ToString()));
                if (chk < 2)
                {
                    int copy = instance.srchMovieID(Convert.ToInt32(MovieID.Text.ToString()));
                    if (copy < VideoCopy)
                    {

                        String query = "Insert into Rent (CustID,MovieID,DateIssue,DateReturn) values ('" +
                                       CustomerID.Text.ToString() + "','" + MovieID.Text.ToString() + "','" +
                                       IssueVideo.Text.ToString() + "','Rent')";
                        Insert(query);
                        MessageBox.Show("Movie is Issued on Rent ");
                    }
                    else
                    {
                        MessageBox.Show("All Videos are issued on rent ");
                    }
                }
                else
                {
                    MessageBox.Show("You already have 2 movies on rent ");
                }

                CustomerID.Text = "";
                MovieID.Text = "";

                Txttitle.Text = "";
                TxtRatting.Text = "";
                TxtYear.Text = "";
                TxtCopies.Text = "";
                Txtcost.Text = "";
                TxtPlot.Text = "";
                TxtGenre.Text = "";

                TxtName.Text = "";
                MobileNo.Text = "";
                Address.Text = "";
            }
        }

        private void TxtCopies_KeyPress(object sender, KeyPressEventArgs e)
        {
            //dislay the cost of the price of the video after adding the year of the video
            DateTime dateNow = DateTime.Now;

            int Currentyear = dateNow.Year;

            int diffYear = Currentyear - Convert.ToInt32(TxtYear.Text.ToString());
            // MessageBox.Show(diff.ToString());
            if (diffYear >= 5)
            {
                Txtcost.Text = "2";
            }
            if (diffYear >= 0 && diffYear < 5)
            {
                Txtcost.Text = "5";
            }

        }

        private void rentalVideoDelete_Click(object sender, EventArgs e)
        {
            
            
            ///this code is used to delete the record of the rental video record from the database
            String query = "delete from Rent Where id=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
            Delete(query);
            MessageBox.Show("Rental Video Record is Deleted from the Database");
            CustomerID.Text = "";
            MovieID.Text = "";
            Txttitle.Text = "";
            TxtRatting.Text = "";
            TxtYear.Text = "";
            TxtCopies.Text = "";
            Txtcost.Text = "";
            TxtPlot.Text = "";
            TxtGenre.Text = "";

            TxtName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";

        }

        private void rentalReturnVideo_Click(object sender, EventArgs e)
        {


            int rentAmount = instance.generateRent(IssueVideo.Text.ToString(), videoPrice);

            String query = "update Rent set CustID='" + CustomerID.Text.ToString() + "',MovieID='" + MovieID.Text.ToString() + "',DateIssue='" + IssueVideo.Text.ToString() + "',DateReturn='" + ReturnVideo.Text.ToString() + "' where  id=" + Convert.ToInt32(RentalID.Text.ToString()) + "";
            Update(query);
            MessageBox.Show("VIdeo is Return and Your Charges are $ "+rentAmount);
            CustomerID.Text = "";
            MovieID.Text = "";
            Txttitle.Text = "";
            TxtRatting.Text = "";
            TxtYear.Text = "";
            TxtCopies.Text = "";
            Txtcost.Text = "";
            TxtPlot.Text = "";
            TxtGenre.Text = "";

            TxtName.Text = "";
            MobileNo.Text = "";
            Address.Text = "";

        }

        private void DatabaseTable_DoubleClick(object sender, EventArgs e)
        {
            if (videoCountrer==1) {
                
                MovieID.Text = DatabaseTable.CurrentRow.Cells[0].Value.ToString();
                Txttitle.Text = DatabaseTable.CurrentRow.Cells[1].Value.ToString();
                TxtRatting.Text = DatabaseTable.CurrentRow.Cells[2].Value.ToString();
                TxtYear.Text = DatabaseTable.CurrentRow.Cells[3].Value.ToString();
                Txtcost.Text = DatabaseTable.CurrentRow.Cells[4].Value.ToString();

                videoPrice = Convert.ToInt32(DatabaseTable.CurrentRow.Cells[4].Value.ToString());

                TxtCopies.Text = DatabaseTable.CurrentRow.Cells[5].Value.ToString();
                VideoCopy = Convert.ToInt32(DatabaseTable.CurrentRow.Cells[5].Value.ToString());

                TxtPlot.Text = DatabaseTable.CurrentRow.Cells[6].Value.ToString();
                TxtGenre.Text = DatabaseTable.CurrentRow.Cells[7].Value.ToString();


                videoCountrer = 0;
            }
            if (RentCounter == 1) {
                  RentalID.Text=DatabaseTable.CurrentRow.Cells[0].Value.ToString();
                CustomerID.Text = DatabaseTable.CurrentRow.Cells[1].Value.ToString();
                MovieID.Text = DatabaseTable.CurrentRow.Cells[2].Value.ToString();
                IssueVideo.Text = DatabaseTable.CurrentRow.Cells[3].Value.ToString();



                RentCounter = 0;
            }
            if (CustomerCounter==1) {

                CustomerID.Text = DatabaseTable.CurrentRow.Cells[0].Value.ToString();
                TxtName.Text = DatabaseTable.CurrentRow.Cells[1].Value.ToString();

                MobileNo.Text = DatabaseTable.CurrentRow.Cells[2].Value.ToString();
                Address.Text = DatabaseTable.CurrentRow.Cells[3].Value.ToString();



                CustomerCounter = 0;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //this method is used to print  the id of the movie which is send most on rent 
           String query = "";
            int countVideo = 0, countID = 0;
            String Name = "";
            DataTable tbl = new DataTable();
            DataTable tbl1 = new DataTable();

            query = "select * from Video ";
            tbl =Srch(query);
            for (int y = 0; y < tbl.Rows.Count; y++)
            {
                String query1 = "select * from Rent where MovieID='" + tbl.Rows[y]["id"].ToString() + "'";
                tbl1 = Srch(query1);
                if (tbl1.Rows.Count > 0)
                {
                    if (tbl1.Rows.Count > countVideo)
                    {
                        countVideo = tbl.Rows.Count;
                        countID = Convert.ToInt32(tbl.Rows[y]["id"].ToString());
                        Name = tbl.Rows[y]["Title"].ToString();
                    }
                }


            }
            MessageBox.Show("Top Rated  Movie Id is=" + countID+" Title of the Movie is="+Name);
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //this method is used to print  the id of the movie which is send most on rent 
            String query = "";
            int countVideo = 0, countID = 0;
            String Name = "";
            DataTable tbl = new DataTable();
            DataTable tbl1 = new DataTable();

            query = "select * from Customer";
            tbl = Srch(query);
            for (int y = 0; y < tbl.Rows.Count; y++)
            {
                String query1 = "select * from Rent where CustID='" + tbl.Rows[y]["id"].ToString() + "'";
                tbl1 = Srch(query1);
                if (tbl1.Rows.Count > 0)
                {
                    if (tbl1.Rows.Count > countVideo)
                    {
                        countVideo = tbl.Rows.Count;
                        countID = Convert.ToInt32(tbl.Rows[y]["id"].ToString());
                        Name = tbl.Rows[y]["Name"].ToString();

                    }
                }


            }
            MessageBox.Show("Top Ranked Customer Id is=" + countID +" Name is="+Name);
        }

        private void lblVideo_Click(object sender, EventArgs e)
        {
            videoCountrer = 1;
            ///this code is sued to get the data from the database and pass to the data grid view using the tblVideo Method
            DatabaseTable.DataSource = tblVideo();
            CustomerCounter = 0;
            RentCounter = 0;
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            CustomerCounter = 1;
            videoCountrer = 0;
            RentCounter = 0;

            ///this code is sued to get the data from the database and pass to the data grid view using the tblCustomer Method
            DatabaseTable.DataSource = tblCustomer();
        }

        private void lblRent_Click(object sender, EventArgs e)
        {
            RentCounter = 1;
            videoCountrer = 0;
            CustomerCounter = 0;

            ///this code is sued to get the data from the database and pass to the data grid view using the tblRent Method
            DatabaseTable.DataSource = tblRent();
        }
    }
}
