namespace WindowsFormsApp1
{
    partial class Patients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patients));
            this.patient = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PatID = new System.Windows.Forms.TextBox();
            this.City = new System.Windows.Forms.TextBox();
            this.ContactRelation = new System.Windows.Forms.TextBox();
            this.ContactPerson = new System.Windows.Forms.TextBox();
            this.Address1 = new System.Windows.Forms.TextBox();
            this.Street = new System.Windows.Forms.TextBox();
            this.Address2 = new System.Windows.Forms.TextBox();
            this.Country = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.PhoneNum = new System.Windows.Forms.TextBox();
            this.Nationality = new System.Windows.Forms.TextBox();
            this.Birthdate = new System.Windows.Forms.TextBox();
            this.CitizenID = new System.Windows.Forms.TextBox();
            this.FileNumber = new System.Windows.Forms.TextBox();
            this.PatName = new System.Windows.Forms.TextBox();
            this.ContactPhone = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.FirstVIstit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.PatGV = new System.Windows.Forms.DataGridView();
            this.textBox13 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatGV)).BeginInit();
            this.SuspendLayout();
            // 
            // patient
            // 
            this.patient.AutoSize = true;
            this.patient.BackColor = System.Drawing.Color.Transparent;
            this.patient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.patient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.patient.Font = new System.Drawing.Font("Yu Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.patient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.patient.Location = new System.Drawing.Point(42, 9);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(163, 47);
            this.patient.TabIndex = 0;
            this.patient.Text = "Patients";
            this.patient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(74, 271);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PatID
            // 
            this.PatID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatID.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PatID.Location = new System.Drawing.Point(200, 83);
            this.PatID.Multiline = true;
            this.PatID.Name = "PatID";
            this.PatID.Size = new System.Drawing.Size(163, 28);
            this.PatID.TabIndex = 3;
            this.PatID.Text = "PatientID";
            this.PatID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PatID.TextChanged += new System.EventHandler(this.PatID_TextChanged);
            // 
            // City
            // 
            this.City.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.City.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.City.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.City.Location = new System.Drawing.Point(367, 82);
            this.City.Multiline = true;
            this.City.Name = "City";
            this.City.Size = new System.Drawing.Size(163, 32);
            this.City.TabIndex = 4;
            this.City.Text = "City";
            this.City.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContactRelation
            // 
            this.ContactRelation.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ContactRelation.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ContactRelation.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ContactRelation.Location = new System.Drawing.Point(366, 243);
            this.ContactRelation.Multiline = true;
            this.ContactRelation.Name = "ContactRelation";
            this.ContactRelation.Size = new System.Drawing.Size(163, 32);
            this.ContactRelation.TabIndex = 5;
            this.ContactRelation.Text = "ContactRelation";
            this.ContactRelation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContactPerson
            // 
            this.ContactPerson.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ContactPerson.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ContactPerson.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ContactPerson.Location = new System.Drawing.Point(366, 210);
            this.ContactPerson.Multiline = true;
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.Size = new System.Drawing.Size(163, 32);
            this.ContactPerson.TabIndex = 6;
            this.ContactPerson.Text = "ContactPerson";
            this.ContactPerson.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Address1
            // 
            this.Address1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Address1.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.Address1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Address1.Location = new System.Drawing.Point(367, 145);
            this.Address1.Multiline = true;
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(163, 32);
            this.Address1.TabIndex = 7;
            this.Address1.Text = "Address1";
            this.Address1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Street
            // 
            this.Street.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Street.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.Street.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Street.Location = new System.Drawing.Point(367, 115);
            this.Street.Multiline = true;
            this.Street.Name = "Street";
            this.Street.Size = new System.Drawing.Size(163, 32);
            this.Street.TabIndex = 8;
            this.Street.Text = "Street";
            this.Street.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Address2
            // 
            this.Address2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Address2.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.Address2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Address2.Location = new System.Drawing.Point(367, 178);
            this.Address2.Multiline = true;
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(163, 32);
            this.Address2.TabIndex = 9;
            this.Address2.Text = "Address2";
            this.Address2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Country
            // 
            this.Country.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Country.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.Country.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Country.Location = new System.Drawing.Point(201, 378);
            this.Country.Multiline = true;
            this.Country.Name = "Country";
            this.Country.Size = new System.Drawing.Size(163, 32);
            this.Country.TabIndex = 10;
            this.Country.Text = "Country";
            this.Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Email.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.Email.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Email.Location = new System.Drawing.Point(200, 345);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(163, 32);
            this.Email.TabIndex = 11;
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhoneNum
            // 
            this.PhoneNum.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PhoneNum.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.PhoneNum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PhoneNum.Location = new System.Drawing.Point(200, 311);
            this.PhoneNum.Multiline = true;
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(163, 32);
            this.PhoneNum.TabIndex = 12;
            this.PhoneNum.Text = "PhoneNumber";
            this.PhoneNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Nationality
            // 
            this.Nationality.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Nationality.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.Nationality.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Nationality.Location = new System.Drawing.Point(200, 277);
            this.Nationality.Multiline = true;
            this.Nationality.Name = "Nationality";
            this.Nationality.Size = new System.Drawing.Size(163, 32);
            this.Nationality.TabIndex = 13;
            this.Nationality.Text = "Nationality";
            this.Nationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Birthdate
            // 
            this.Birthdate.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Birthdate.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.Birthdate.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Birthdate.Location = new System.Drawing.Point(200, 243);
            this.Birthdate.Multiline = true;
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Size = new System.Drawing.Size(163, 32);
            this.Birthdate.TabIndex = 14;
            this.Birthdate.Text = "Birthdate\r\n";
            this.Birthdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Birthdate.TextChanged += new System.EventHandler(this.textBox12_TextChanged);
            // 
            // CitizenID
            // 
            this.CitizenID.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CitizenID.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.CitizenID.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.CitizenID.Location = new System.Drawing.Point(200, 178);
            this.CitizenID.Multiline = true;
            this.CitizenID.Name = "CitizenID";
            this.CitizenID.Size = new System.Drawing.Size(163, 32);
            this.CitizenID.TabIndex = 16;
            this.CitizenID.Text = "CitizenId";
            this.CitizenID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FileNumber
            // 
            this.FileNumber.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FileNumber.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.FileNumber.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FileNumber.Location = new System.Drawing.Point(200, 145);
            this.FileNumber.Multiline = true;
            this.FileNumber.Name = "FileNumber";
            this.FileNumber.Size = new System.Drawing.Size(163, 32);
            this.FileNumber.TabIndex = 17;
            this.FileNumber.Text = "FileNumber";
            this.FileNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PatName
            // 
            this.PatName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.PatName.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.PatName.Location = new System.Drawing.Point(200, 112);
            this.PatName.Multiline = true;
            this.PatName.Name = "PatName";
            this.PatName.Size = new System.Drawing.Size(163, 32);
            this.PatName.TabIndex = 18;
            this.PatName.Text = "PatientName";
            this.PatName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ContactPhone
            // 
            this.ContactPhone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ContactPhone.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.ContactPhone.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ContactPhone.Location = new System.Drawing.Point(366, 277);
            this.ContactPhone.Multiline = true;
            this.ContactPhone.Name = "ContactPhone";
            this.ContactPhone.Size = new System.Drawing.Size(163, 32);
            this.ContactPhone.TabIndex = 19;
            this.ContactPhone.Text = "ContactPhone";
            this.ContactPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.c.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.c.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.c.Location = new System.Drawing.Point(367, 345);
            this.c.Multiline = true;
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(163, 33);
            this.c.TabIndex = 20;
            this.c.Text = "RecordCreationDate";
            this.c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FirstVIstit
            // 
            this.FirstVIstit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.FirstVIstit.Font = new System.Drawing.Font("Century Schoolbook", 12F);
            this.FirstVIstit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FirstVIstit.Location = new System.Drawing.Point(366, 311);
            this.FirstVIstit.Multiline = true;
            this.FirstVIstit.Name = "FirstVIstit";
            this.FirstVIstit.Size = new System.Drawing.Size(163, 32);
            this.FirstVIstit.TabIndex = 21;
            this.FirstVIstit.Text = "FirstVisitDate";
            this.FirstVIstit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(74, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 22;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(78, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 30);
            this.button2.TabIndex = 23;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(78, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(73, 30);
            this.button4.TabIndex = 25;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gender.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gender.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            " Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(200, 212);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(163, 28);
            this.Gender.TabIndex = 26;
            this.Gender.Text = "Gender";
            // 
            // PatGV
            // 
            this.PatGV.BackgroundColor = System.Drawing.Color.LightGray;
            this.PatGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatGV.Location = new System.Drawing.Point(552, 82);
            this.PatGV.Name = "PatGV";
            this.PatGV.Size = new System.Drawing.Size(512, 339);
            this.PatGV.TabIndex = 27;
            this.PatGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatGV_CellContentClick);
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Window;
            this.textBox13.Font = new System.Drawing.Font("Century", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.textBox13.Location = new System.Drawing.Point(653, 46);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(303, 30);
            this.textBox13.TabIndex = 28;
            this.textBox13.Text = "Patient List";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1086, 422);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.PatGV);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FirstVIstit);
            this.Controls.Add(this.c);
            this.Controls.Add(this.ContactPhone);
            this.Controls.Add(this.PatName);
            this.Controls.Add(this.FileNumber);
            this.Controls.Add(this.CitizenID);
            this.Controls.Add(this.Birthdate);
            this.Controls.Add(this.Nationality);
            this.Controls.Add(this.PhoneNum);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Country);
            this.Controls.Add(this.Address2);
            this.Controls.Add(this.Street);
            this.Controls.Add(this.Address1);
            this.Controls.Add(this.ContactPerson);
            this.Controls.Add(this.ContactRelation);
            this.Controls.Add(this.City);
            this.Controls.Add(this.PatID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.patient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PatGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label patient;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox PatID;
        private System.Windows.Forms.TextBox City;
        private System.Windows.Forms.TextBox ContactRelation;
        private System.Windows.Forms.TextBox ContactPerson;
        private System.Windows.Forms.TextBox Address1;
        private System.Windows.Forms.TextBox Street;
        private System.Windows.Forms.TextBox Address2;
        private System.Windows.Forms.TextBox Country;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox PhoneNum;
        private System.Windows.Forms.TextBox Nationality;
        private System.Windows.Forms.TextBox Birthdate;
        private System.Windows.Forms.TextBox CitizenID;
        private System.Windows.Forms.TextBox FileNumber;
        private System.Windows.Forms.TextBox PatName;
        private System.Windows.Forms.TextBox ContactPhone;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.TextBox FirstVIstit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.DataGridView PatGV;
        private System.Windows.Forms.TextBox textBox13;
    }
}