namespace VideoRental_MAnjot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.delCustomer = new System.Windows.Forms.Button();
            this.updateCustomer = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.TextBox();
            this.MobileNo = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.MovieID = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.ReturnVideo = new System.Windows.Forms.DateTimePicker();
            this.IssueVideo = new System.Windows.Forms.DateTimePicker();
            this.rentalVideoDelete = new System.Windows.Forms.Button();
            this.rentalReturnVideo = new System.Windows.Forms.Button();
            this.rentalIssueVideo = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.delVideo = new System.Windows.Forms.Button();
            this.updateVideo = new System.Windows.Forms.Button();
            this.AddVideo = new System.Windows.Forms.Button();
            this.TxtGenre = new System.Windows.Forms.TextBox();
            this.TxtPlot = new System.Windows.Forms.TextBox();
            this.TxtCopies = new System.Windows.Forms.TextBox();
            this.Txtcost = new System.Windows.Forms.TextBox();
            this.TxtYear = new System.Windows.Forms.TextBox();
            this.TxtRatting = new System.Windows.Forms.TextBox();
            this.Txttitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.RentalID = new System.Windows.Forms.TextBox();
            this.DatabaseTable = new System.Windows.Forms.DataGridView();
            this.lblVideo = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblRent = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(102, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 36);
            this.label1.TabIndex = 76;
            this.label1.Text = "Customer Zone";
            // 
            // delCustomer
            // 
            this.delCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delCustomer.Location = new System.Drawing.Point(34, 300);
            this.delCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delCustomer.Name = "delCustomer";
            this.delCustomer.Size = new System.Drawing.Size(411, 57);
            this.delCustomer.TabIndex = 75;
            this.delCustomer.Text = "Delete";
            this.delCustomer.UseVisualStyleBackColor = true;
            this.delCustomer.Click += new System.EventHandler(this.delCustomer_Click);
            // 
            // updateCustomer
            // 
            this.updateCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustomer.Location = new System.Drawing.Point(214, 242);
            this.updateCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateCustomer.Name = "updateCustomer";
            this.updateCustomer.Size = new System.Drawing.Size(231, 49);
            this.updateCustomer.TabIndex = 74;
            this.updateCustomer.Text = "Update";
            this.updateCustomer.UseVisualStyleBackColor = true;
            this.updateCustomer.Click += new System.EventHandler(this.updateCustomer_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomer.Location = new System.Drawing.Point(32, 242);
            this.addCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(152, 49);
            this.addCustomer.TabIndex = 71;
            this.addCustomer.Text = "Add";
            this.addCustomer.UseVisualStyleBackColor = true;
            this.addCustomer.Click += new System.EventHandler(this.addCustomer_Click);
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Location = new System.Drawing.Point(214, 174);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(229, 44);
            this.Address.TabIndex = 73;
            // 
            // MobileNo
            // 
            this.MobileNo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileNo.Location = new System.Drawing.Point(214, 114);
            this.MobileNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MobileNo.Name = "MobileNo";
            this.MobileNo.Size = new System.Drawing.Size(229, 44);
            this.MobileNo.TabIndex = 72;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(214, 55);
            this.TxtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(229, 44);
            this.TxtName.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(26, 177);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 36);
            this.label8.TabIndex = 68;
            this.label8.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 120);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 36);
            this.label9.TabIndex = 67;
            this.label9.Text = "Mobile No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(26, 55);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 36);
            this.label11.TabIndex = 65;
            this.label11.Text = " Name";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(996, 14);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(187, 36);
            this.label17.TabIndex = 88;
            this.label17.Text = "Rental Zone";
            // 
            // MovieID
            // 
            this.MovieID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MovieID.Location = new System.Drawing.Point(1134, 126);
            this.MovieID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MovieID.Name = "MovieID";
            this.MovieID.Size = new System.Drawing.Size(229, 44);
            this.MovieID.TabIndex = 87;
            // 
            // CustomerID
            // 
            this.CustomerID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerID.Location = new System.Drawing.Point(1134, 55);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(229, 44);
            this.CustomerID.TabIndex = 86;
            // 
            // ReturnVideo
            // 
            this.ReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnVideo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ReturnVideo.Location = new System.Drawing.Point(1134, 249);
            this.ReturnVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReturnVideo.Name = "ReturnVideo";
            this.ReturnVideo.Size = new System.Drawing.Size(229, 44);
            this.ReturnVideo.TabIndex = 85;
            // 
            // IssueVideo
            // 
            this.IssueVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IssueVideo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.IssueVideo.Location = new System.Drawing.Point(1134, 192);
            this.IssueVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IssueVideo.Name = "IssueVideo";
            this.IssueVideo.Size = new System.Drawing.Size(229, 44);
            this.IssueVideo.TabIndex = 84;
            // 
            // rentalVideoDelete
            // 
            this.rentalVideoDelete.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalVideoDelete.Location = new System.Drawing.Point(934, 369);
            this.rentalVideoDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rentalVideoDelete.Name = "rentalVideoDelete";
            this.rentalVideoDelete.Size = new System.Drawing.Size(411, 57);
            this.rentalVideoDelete.TabIndex = 83;
            this.rentalVideoDelete.Text = "Delete";
            this.rentalVideoDelete.UseVisualStyleBackColor = true;
            this.rentalVideoDelete.Click += new System.EventHandler(this.rentalVideoDelete_Click);
            // 
            // rentalReturnVideo
            // 
            this.rentalReturnVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalReturnVideo.Location = new System.Drawing.Point(1114, 311);
            this.rentalReturnVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rentalReturnVideo.Name = "rentalReturnVideo";
            this.rentalReturnVideo.Size = new System.Drawing.Size(231, 49);
            this.rentalReturnVideo.TabIndex = 82;
            this.rentalReturnVideo.Text = "Return";
            this.rentalReturnVideo.UseVisualStyleBackColor = true;
            this.rentalReturnVideo.Click += new System.EventHandler(this.rentalReturnVideo_Click);
            // 
            // rentalIssueVideo
            // 
            this.rentalIssueVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalIssueVideo.Location = new System.Drawing.Point(932, 311);
            this.rentalIssueVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rentalIssueVideo.Name = "rentalIssueVideo";
            this.rentalIssueVideo.Size = new System.Drawing.Size(152, 49);
            this.rentalIssueVideo.TabIndex = 81;
            this.rentalIssueVideo.Text = "Issue";
            this.rentalIssueVideo.UseVisualStyleBackColor = true;
            this.rentalIssueVideo.Click += new System.EventHandler(this.rentalIssueVideo_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(912, 246);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 36);
            this.label12.TabIndex = 80;
            this.label12.Text = "Date of Return ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(912, 189);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(202, 36);
            this.label13.TabIndex = 79;
            this.label13.Text = "Date of Issue";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(926, 131);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(139, 36);
            this.label14.TabIndex = 78;
            this.label14.Text = "Movie ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(926, 68);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 36);
            this.label15.TabIndex = 77;
            this.label15.Text = "Customer ID";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(578, 14);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(174, 36);
            this.label18.TabIndex = 106;
            this.label18.Text = "Video Zone";
            // 
            // delVideo
            // 
            this.delVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delVideo.Location = new System.Drawing.Point(748, 500);
            this.delVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delVideo.Name = "delVideo";
            this.delVideo.Size = new System.Drawing.Size(128, 49);
            this.delVideo.TabIndex = 105;
            this.delVideo.Text = "Delete";
            this.delVideo.UseVisualStyleBackColor = true;
            this.delVideo.Click += new System.EventHandler(this.delVideo_Click);
            // 
            // updateVideo
            // 
            this.updateVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateVideo.Location = new System.Drawing.Point(612, 500);
            this.updateVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.updateVideo.Name = "updateVideo";
            this.updateVideo.Size = new System.Drawing.Size(128, 49);
            this.updateVideo.TabIndex = 104;
            this.updateVideo.Text = "Update";
            this.updateVideo.UseVisualStyleBackColor = true;
            this.updateVideo.Click += new System.EventHandler(this.updateVideo_Click);
            // 
            // AddVideo
            // 
            this.AddVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddVideo.Location = new System.Drawing.Point(476, 500);
            this.AddVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddVideo.Name = "AddVideo";
            this.AddVideo.Size = new System.Drawing.Size(128, 49);
            this.AddVideo.TabIndex = 103;
            this.AddVideo.Text = "Add";
            this.AddVideo.UseVisualStyleBackColor = true;
            this.AddVideo.Click += new System.EventHandler(this.AddVideo_Click);
            // 
            // TxtGenre
            // 
            this.TxtGenre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtGenre.Location = new System.Drawing.Point(652, 414);
            this.TxtGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGenre.Name = "TxtGenre";
            this.TxtGenre.Size = new System.Drawing.Size(229, 44);
            this.TxtGenre.TabIndex = 102;
            // 
            // TxtPlot
            // 
            this.TxtPlot.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPlot.Location = new System.Drawing.Point(652, 358);
            this.TxtPlot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPlot.Name = "TxtPlot";
            this.TxtPlot.Size = new System.Drawing.Size(229, 44);
            this.TxtPlot.TabIndex = 101;
            // 
            // TxtCopies
            // 
            this.TxtCopies.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCopies.Location = new System.Drawing.Point(652, 300);
            this.TxtCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtCopies.Name = "TxtCopies";
            this.TxtCopies.Size = new System.Drawing.Size(229, 44);
            this.TxtCopies.TabIndex = 100;
            this.TxtCopies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCopies_KeyPress);
            // 
            // Txtcost
            // 
            this.Txtcost.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtcost.Location = new System.Drawing.Point(652, 245);
            this.Txtcost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txtcost.Name = "Txtcost";
            this.Txtcost.ReadOnly = true;
            this.Txtcost.Size = new System.Drawing.Size(229, 44);
            this.Txtcost.TabIndex = 99;
            // 
            // TxtYear
            // 
            this.TxtYear.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtYear.Location = new System.Drawing.Point(652, 186);
            this.TxtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtYear.Name = "TxtYear";
            this.TxtYear.Size = new System.Drawing.Size(229, 44);
            this.TxtYear.TabIndex = 98;
            // 
            // TxtRatting
            // 
            this.TxtRatting.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRatting.Location = new System.Drawing.Point(652, 128);
            this.TxtRatting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtRatting.Name = "TxtRatting";
            this.TxtRatting.Size = new System.Drawing.Size(229, 44);
            this.TxtRatting.TabIndex = 97;
            // 
            // Txttitle
            // 
            this.Txttitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txttitle.Location = new System.Drawing.Point(652, 69);
            this.Txttitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txttitle.Name = "Txttitle";
            this.Txttitle.Size = new System.Drawing.Size(229, 44);
            this.Txttitle.TabIndex = 96;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(501, 428);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 36);
            this.label7.TabIndex = 95;
            this.label7.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(501, 368);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 36);
            this.label6.TabIndex = 94;
            this.label6.Text = "Plot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(502, 312);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 36);
            this.label5.TabIndex = 93;
            this.label5.Text = "Copies";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(501, 248);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 36);
            this.label4.TabIndex = 92;
            this.label4.Text = "Cost";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(501, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 36);
            this.label3.TabIndex = 91;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(501, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 36);
            this.label2.TabIndex = 90;
            this.label2.Text = "Ratting";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(501, 69);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 36);
            this.label16.TabIndex = 89;
            this.label16.Text = "Title";
            // 
            // RentalID
            // 
            this.RentalID.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RentalID.Location = new System.Drawing.Point(1374, 57);
            this.RentalID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RentalID.Name = "RentalID";
            this.RentalID.Size = new System.Drawing.Size(229, 44);
            this.RentalID.TabIndex = 107;
            this.RentalID.Visible = false;
            // 
            // DatabaseTable
            // 
            this.DatabaseTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatabaseTable.Location = new System.Drawing.Point(32, 598);
            this.DatabaseTable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DatabaseTable.Name = "DatabaseTable";
            this.DatabaseTable.RowHeadersWidth = 62;
            this.DatabaseTable.Size = new System.Drawing.Size(1490, 391);
            this.DatabaseTable.TabIndex = 108;
            this.DatabaseTable.DoubleClick += new System.EventHandler(this.DatabaseTable_DoubleClick);
            // 
            // lblVideo
            // 
            this.lblVideo.AutoSize = true;
            this.lblVideo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVideo.ForeColor = System.Drawing.Color.White;
            this.lblVideo.Location = new System.Drawing.Point(28, 557);
            this.lblVideo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVideo.Name = "lblVideo";
            this.lblVideo.Size = new System.Drawing.Size(93, 36);
            this.lblVideo.TabIndex = 109;
            this.lblVideo.Text = "Video";
            this.lblVideo.Click += new System.EventHandler(this.lblVideo_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.White;
            this.lblCustomer.Location = new System.Drawing.Point(132, 557);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(153, 36);
            this.lblCustomer.TabIndex = 110;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // lblRent
            // 
            this.lblRent.AutoSize = true;
            this.lblRent.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRent.ForeColor = System.Drawing.Color.White;
            this.lblRent.Location = new System.Drawing.Point(296, 557);
            this.lblRent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRent.Name = "lblRent";
            this.lblRent.Size = new System.Drawing.Size(82, 36);
            this.lblRent.TabIndex = 111;
            this.lblRent.Text = "Rent";
            this.lblRent.Click += new System.EventHandler(this.lblRent_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(932, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 57);
            this.button1.TabIndex = 112;
            this.button1.Text = "Top Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(932, 512);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(411, 57);
            this.button2.TabIndex = 113;
            this.button2.Text = "Top Customer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1588, 1008);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRent);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.lblVideo);
            this.Controls.Add(this.DatabaseTable);
            this.Controls.Add(this.RentalID);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.delVideo);
            this.Controls.Add(this.updateVideo);
            this.Controls.Add(this.AddVideo);
            this.Controls.Add(this.TxtGenre);
            this.Controls.Add(this.TxtPlot);
            this.Controls.Add(this.TxtCopies);
            this.Controls.Add(this.Txtcost);
            this.Controls.Add(this.TxtYear);
            this.Controls.Add(this.TxtRatting);
            this.Controls.Add(this.Txttitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.MovieID);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.ReturnVideo);
            this.Controls.Add(this.IssueVideo);
            this.Controls.Add(this.rentalVideoDelete);
            this.Controls.Add(this.rentalReturnVideo);
            this.Controls.Add(this.rentalIssueVideo);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delCustomer);
            this.Controls.Add(this.updateCustomer);
            this.Controls.Add(this.addCustomer);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.MobileNo);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button delCustomer;
        private System.Windows.Forms.Button updateCustomer;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.TextBox MobileNo;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox MovieID;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.DateTimePicker ReturnVideo;
        private System.Windows.Forms.DateTimePicker IssueVideo;
        private System.Windows.Forms.Button rentalVideoDelete;
        private System.Windows.Forms.Button rentalReturnVideo;
        private System.Windows.Forms.Button rentalIssueVideo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button delVideo;
        private System.Windows.Forms.Button updateVideo;
        private System.Windows.Forms.Button AddVideo;
        private System.Windows.Forms.TextBox TxtGenre;
        private System.Windows.Forms.TextBox TxtPlot;
        private System.Windows.Forms.TextBox TxtCopies;
        private System.Windows.Forms.TextBox Txtcost;
        private System.Windows.Forms.TextBox TxtYear;
        private System.Windows.Forms.TextBox TxtRatting;
        private System.Windows.Forms.TextBox Txttitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox RentalID;
        private System.Windows.Forms.DataGridView DatabaseTable;
        private System.Windows.Forms.Label lblVideo;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblRent;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

