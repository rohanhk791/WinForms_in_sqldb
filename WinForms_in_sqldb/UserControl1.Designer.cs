
namespace WinForms_in_sqldb
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.com_country = new System.Windows.Forms.ComboBox();
            this.com_state = new System.Windows.Forms.ComboBox();
            this.com_city = new System.Windows.Forms.ComboBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.com_qualification = new System.Windows.Forms.ComboBox();
            this.lbl_qualification = new System.Windows.Forms.Label();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.num_age = new System.Windows.Forms.NumericUpDown();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.lbl_age = new System.Windows.Forms.Label();
            this.pan_age = new System.Windows.Forms.Panel();
            this.pan_gender = new System.Windows.Forms.Panel();
            this.pan_city = new System.Windows.Forms.Panel();
            this.pan_state = new System.Windows.Forms.Panel();
            this.pan_country = new System.Windows.Forms.Panel();
            this.pan_qualification = new System.Windows.Forms.Panel();
            this.pan_phone_no = new System.Windows.Forms.Panel();
            this.txt_phone_no = new System.Windows.Forms.TextBox();
            this.lbl_phone_no = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.pan_address = new System.Windows.Forms.Panel();
            this.pan_name = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pan_griddata = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).BeginInit();
            this.pan_age.SuspendLayout();
            this.pan_gender.SuspendLayout();
            this.pan_city.SuspendLayout();
            this.pan_state.SuspendLayout();
            this.pan_country.SuspendLayout();
            this.pan_qualification.SuspendLayout();
            this.pan_phone_no.SuspendLayout();
            this.pan_address.SuspendLayout();
            this.pan_name.SuspendLayout();
            this.pan_griddata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // com_country
            // 
            this.com_country.AutoCompleteCustomSource.AddRange(new string[] {
            "India"});
            this.com_country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.com_country.FormattingEnabled = true;
            this.com_country.Items.AddRange(new object[] {
            "India",
            "USA",
            "UK",
            "England",
            "Rome",
            "Germany",
            "Italy",
            "Spain"});
            this.com_country.Location = new System.Drawing.Point(114, 12);
            this.com_country.Name = "com_country";
            this.com_country.Size = new System.Drawing.Size(142, 23);
            this.com_country.TabIndex = 101;
            // 
            // com_state
            // 
            this.com_state.AutoCompleteCustomSource.AddRange(new string[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttarakhand",
            "Uttar Pradesh",
            "West Bengal",
            "Andaman and Nicobar Islands",
            "Chandigarh",
            "Dadra and Nagar Haveli",
            "Daman and Diu",
            "Delhi",
            "Lakshadweep",
            "Puducherry"});
            this.com_state.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_state.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.com_state.FormattingEnabled = true;
            this.com_state.Items.AddRange(new object[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jammu and Kashmir",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharashtra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajasthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttarakhand",
            "Uttar Pradesh",
            "West Bengal",
            "Andaman and Nicobar Islands",
            "Chandigarh",
            "Dadra and Nagar Haveli",
            "Daman and Diu",
            "Delhi",
            "Lakshadweep",
            "Puducherry"});
            this.com_state.Location = new System.Drawing.Point(98, 7);
            this.com_state.Name = "com_state";
            this.com_state.Size = new System.Drawing.Size(142, 23);
            this.com_state.TabIndex = 100;
            // 
            // com_city
            // 
            this.com_city.AutoCompleteCustomSource.AddRange(new string[] {
            "Bagalkot",
            "Ballari ",
            "Belagavi ",
            "Bengaluru  Rural",
            "Bengaluru Urban",
            "Bidar",
            "Chamarajanagar",
            "Chikballapur",
            "Chikkamagaluru ",
            "Chitradurga",
            "Dakshina Kannada",
            "Davangere",
            "Dharwad",
            "Gadag",
            "Hassan",
            "Haveri",
            "Kalaburagi ",
            "Kodagu",
            "Kolar",
            "Koppal",
            "Mandya",
            "Mysuru ",
            "Raichur",
            "Ramanagara",
            "Shivamogga ",
            "Tumakuru",
            "Udupi",
            "Karwar",
            "Vijayapura",
            "Yadgir"});
            this.com_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.com_city.FormattingEnabled = true;
            this.com_city.Items.AddRange(new object[] {
            "Bagalkot",
            "Ballari (Bellary)",
            "Belagavi (Belgaum)",
            "Bengaluru (Bangalore) Rural",
            "Bengaluru (Bangalore) Urban",
            "Bidar",
            "Chamarajanagar",
            "Chikballapur",
            "Chikkamagaluru (Chikmagalur)",
            "Chitradurga",
            "Dakshina Kannada",
            "Davangere",
            "Dharwad",
            "Gadag",
            "Hassan",
            "Haveri",
            "Kalaburagi (Gulbarga)",
            "Kodagu",
            "Kolar",
            "Koppal",
            "Mandya",
            "Mysuru (Mysore)",
            "Raichur",
            "Ramanagara",
            "Shivamogga (Shimoga)",
            "Tumakuru (Tumkur)",
            "Udupi",
            "Uttara Kannada (Karwar)",
            "Vijayapura (Bijapur)",
            "Yadgir"});
            this.com_city.Location = new System.Drawing.Point(88, 10);
            this.com_city.Name = "com_city";
            this.com_city.Size = new System.Drawing.Size(143, 23);
            this.com_city.TabIndex = 99;
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_country.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_country.Location = new System.Drawing.Point(8, 16);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(72, 19);
            this.lbl_country.TabIndex = 98;
            this.lbl_country.Text = "Country :";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_state.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_state.Location = new System.Drawing.Point(11, 7);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(53, 19);
            this.lbl_state.TabIndex = 97;
            this.lbl_state.Text = "State :";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_city.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_city.Location = new System.Drawing.Point(18, 14);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(46, 19);
            this.lbl_city.TabIndex = 96;
            this.lbl_city.Text = "City :";
            // 
            // com_qualification
            // 
            this.com_qualification.AutoCompleteCustomSource.AddRange(new string[] {
            "SSLC",
            "PUC",
            "ITI",
            "DIPLOMA",
            "Bachelor of engineering",
            "Mtech",
            "Btech",
            "MS"});
            this.com_qualification.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_qualification.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.com_qualification.FormattingEnabled = true;
            this.com_qualification.Items.AddRange(new object[] {
            "SSLC",
            "PUC",
            "ITI",
            "DIPLOMA",
            "Bachelor of engineering",
            "Mtech",
            "Btech",
            "MS"});
            this.com_qualification.Location = new System.Drawing.Point(123, 14);
            this.com_qualification.Name = "com_qualification";
            this.com_qualification.Size = new System.Drawing.Size(142, 23);
            this.com_qualification.TabIndex = 103;
            // 
            // lbl_qualification
            // 
            this.lbl_qualification.AutoSize = true;
            this.lbl_qualification.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_qualification.Location = new System.Drawing.Point(7, 14);
            this.lbl_qualification.Name = "lbl_qualification";
            this.lbl_qualification.Size = new System.Drawing.Size(103, 19);
            this.lbl_qualification.TabIndex = 102;
            this.lbl_qualification.Text = "Qualification :";
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Location = new System.Drawing.Point(157, 13);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(63, 19);
            this.rad_female.TabIndex = 108;
            this.rad_female.Text = "Female";
            this.rad_female.UseVisualStyleBackColor = true;
            // 
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Checked = true;
            this.rad_male.Location = new System.Drawing.Point(100, 13);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(51, 19);
            this.rad_male.TabIndex = 107;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "Male";
            this.rad_male.UseVisualStyleBackColor = true;
            this.rad_male.CheckedChanged += new System.EventHandler(this.rad_male_CheckedChanged);
            // 
            // num_age
            // 
            this.num_age.Location = new System.Drawing.Point(119, 3);
            this.num_age.Name = "num_age";
            this.num_age.Size = new System.Drawing.Size(50, 23);
            this.num_age.TabIndex = 106;
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_gender.Location = new System.Drawing.Point(17, 13);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(68, 19);
            this.lbl_gender.TabIndex = 105;
            this.lbl_gender.Text = "Gender :";
            // 
            // lbl_age
            // 
            this.lbl_age.AutoSize = true;
            this.lbl_age.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_age.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_age.Location = new System.Drawing.Point(40, 7);
            this.lbl_age.Name = "lbl_age";
            this.lbl_age.Size = new System.Drawing.Size(45, 19);
            this.lbl_age.TabIndex = 104;
            this.lbl_age.Text = "Age :";
            // 
            // pan_age
            // 
            this.pan_age.Controls.Add(this.num_age);
            this.pan_age.Controls.Add(this.lbl_age);
            this.pan_age.Location = new System.Drawing.Point(31, 25);
            this.pan_age.Name = "pan_age";
            this.pan_age.Size = new System.Drawing.Size(231, 33);
            this.pan_age.TabIndex = 109;
            // 
            // pan_gender
            // 
            this.pan_gender.Controls.Add(this.lbl_gender);
            this.pan_gender.Controls.Add(this.rad_male);
            this.pan_gender.Controls.Add(this.rad_female);
            this.pan_gender.Location = new System.Drawing.Point(31, 79);
            this.pan_gender.Name = "pan_gender";
            this.pan_gender.Size = new System.Drawing.Size(231, 45);
            this.pan_gender.TabIndex = 110;
            // 
            // pan_city
            // 
            this.pan_city.Controls.Add(this.com_city);
            this.pan_city.Controls.Add(this.lbl_city);
            this.pan_city.Location = new System.Drawing.Point(31, 144);
            this.pan_city.Name = "pan_city";
            this.pan_city.Size = new System.Drawing.Size(243, 45);
            this.pan_city.TabIndex = 111;
            // 
            // pan_state
            // 
            this.pan_state.Controls.Add(this.com_state);
            this.pan_state.Controls.Add(this.lbl_state);
            this.pan_state.Location = new System.Drawing.Point(343, 25);
            this.pan_state.Name = "pan_state";
            this.pan_state.Size = new System.Drawing.Size(259, 42);
            this.pan_state.TabIndex = 112;
            // 
            // pan_country
            // 
            this.pan_country.Controls.Add(this.com_country);
            this.pan_country.Controls.Add(this.lbl_country);
            this.pan_country.Location = new System.Drawing.Point(343, 79);
            this.pan_country.Name = "pan_country";
            this.pan_country.Size = new System.Drawing.Size(259, 45);
            this.pan_country.TabIndex = 113;
            // 
            // pan_qualification
            // 
            this.pan_qualification.Controls.Add(this.com_qualification);
            this.pan_qualification.Controls.Add(this.lbl_qualification);
            this.pan_qualification.Location = new System.Drawing.Point(343, 144);
            this.pan_qualification.Name = "pan_qualification";
            this.pan_qualification.Size = new System.Drawing.Size(268, 45);
            this.pan_qualification.TabIndex = 114;
            // 
            // pan_phone_no
            // 
            this.pan_phone_no.Controls.Add(this.txt_phone_no);
            this.pan_phone_no.Controls.Add(this.lbl_phone_no);
            this.pan_phone_no.Location = new System.Drawing.Point(31, 213);
            this.pan_phone_no.Name = "pan_phone_no";
            this.pan_phone_no.Size = new System.Drawing.Size(271, 43);
            this.pan_phone_no.TabIndex = 115;
            // 
            // txt_phone_no
            // 
            this.txt_phone_no.Location = new System.Drawing.Point(119, 7);
            this.txt_phone_no.Name = "txt_phone_no";
            this.txt_phone_no.Size = new System.Drawing.Size(143, 23);
            this.txt_phone_no.TabIndex = 117;
            // 
            // lbl_phone_no
            // 
            this.lbl_phone_no.AutoSize = true;
            this.lbl_phone_no.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_phone_no.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_phone_no.Location = new System.Drawing.Point(4, 7);
            this.lbl_phone_no.Name = "lbl_phone_no";
            this.lbl_phone_no.Size = new System.Drawing.Size(79, 19);
            this.lbl_phone_no.TabIndex = 116;
            this.lbl_phone_no.Text = "Phone no :";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(110, 11);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(158, 25);
            this.txt_address.TabIndex = 117;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_address.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_address.Location = new System.Drawing.Point(7, 11);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(73, 19);
            this.lbl_address.TabIndex = 116;
            this.lbl_address.Text = "Address :";
            // 
            // pan_address
            // 
            this.pan_address.Controls.Add(this.txt_address);
            this.pan_address.Controls.Add(this.lbl_address);
            this.pan_address.Location = new System.Drawing.Point(343, 213);
            this.pan_address.Name = "pan_address";
            this.pan_address.Size = new System.Drawing.Size(303, 58);
            this.pan_address.TabIndex = 118;
            // 
            // pan_name
            // 
            this.pan_name.Controls.Add(this.txt_name);
            this.pan_name.Controls.Add(this.label1);
            this.pan_name.Location = new System.Drawing.Point(35, 272);
            this.pan_name.Name = "pan_name";
            this.pan_name.Size = new System.Drawing.Size(271, 43);
            this.pan_name.TabIndex = 118;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(96, 10);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(143, 23);
            this.txt_name.TabIndex = 117;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 116;
            this.label1.Text = "Name:";
            // 
            // pan_griddata
            // 
            this.pan_griddata.Controls.Add(this.dataGridView2);
            this.pan_griddata.Controls.Add(this.btn_close);
            this.pan_griddata.Controls.Add(this.btn_delete);
            this.pan_griddata.Location = new System.Drawing.Point(14, 352);
            this.pan_griddata.Name = "pan_griddata";
            this.pan_griddata.Size = new System.Drawing.Size(707, 198);
            this.pan_griddata.TabIndex = 119;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkbox});
            this.dataGridView2.Location = new System.Drawing.Point(15, 13);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(665, 133);
            this.dataGridView2.TabIndex = 82;
            // 
            // checkbox
            // 
            this.checkbox.HeaderText = "Select";
            this.checkbox.Name = "checkbox";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(389, 161);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(91, 23);
            this.btn_close.TabIndex = 83;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(239, 161);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(94, 23);
            this.btn_delete.TabIndex = 82;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pan_griddata);
            this.Controls.Add(this.pan_name);
            this.Controls.Add(this.pan_address);
            this.Controls.Add(this.pan_phone_no);
            this.Controls.Add(this.pan_qualification);
            this.Controls.Add(this.pan_country);
            this.Controls.Add(this.pan_state);
            this.Controls.Add(this.pan_city);
            this.Controls.Add(this.pan_gender);
            this.Controls.Add(this.pan_age);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(738, 607);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).EndInit();
            this.pan_age.ResumeLayout(false);
            this.pan_age.PerformLayout();
            this.pan_gender.ResumeLayout(false);
            this.pan_gender.PerformLayout();
            this.pan_city.ResumeLayout(false);
            this.pan_city.PerformLayout();
            this.pan_state.ResumeLayout(false);
            this.pan_state.PerformLayout();
            this.pan_country.ResumeLayout(false);
            this.pan_country.PerformLayout();
            this.pan_qualification.ResumeLayout(false);
            this.pan_qualification.PerformLayout();
            this.pan_phone_no.ResumeLayout(false);
            this.pan_phone_no.PerformLayout();
            this.pan_address.ResumeLayout(false);
            this.pan_address.PerformLayout();
            this.pan_name.ResumeLayout(false);
            this.pan_name.PerformLayout();
            this.pan_griddata.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox com_country;
        public System.Windows.Forms.ComboBox com_state;
        public System.Windows.Forms.ComboBox com_city;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label lbl_city;
        public System.Windows.Forms.ComboBox com_qualification;
        private System.Windows.Forms.Label lbl_qualification;
        public System.Windows.Forms.RadioButton rad_female;
        public System.Windows.Forms.RadioButton rad_male;
        public System.Windows.Forms.NumericUpDown num_age;
        private System.Windows.Forms.Label lbl_gender;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Panel pan_age;
        private System.Windows.Forms.Panel pan_gender;
        private System.Windows.Forms.Panel pan_city;
        private System.Windows.Forms.Panel pan_state;
        private System.Windows.Forms.Panel pan_country;
        private System.Windows.Forms.Panel pan_qualification;
        private System.Windows.Forms.Panel pan_phone_no;
        public System.Windows.Forms.TextBox txt_phone_no;
        private System.Windows.Forms.Label lbl_phone_no;
        public System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Panel pan_address;
        private System.Windows.Forms.Panel pan_name;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_griddata;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        public System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.Button btn_delete;
    }
}
