
namespace WinForms_in_sqldb
{
    partial class singlefilter
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
            this.com_select = new System.Windows.Forms.ComboBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pan_name = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pan_age = new System.Windows.Forms.Panel();
            this.num_age = new System.Windows.Forms.NumericUpDown();
            this.lbl_age = new System.Windows.Forms.Label();
            this.pan_gender = new System.Windows.Forms.Panel();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.rad_male = new System.Windows.Forms.RadioButton();
            this.rad_female = new System.Windows.Forms.RadioButton();
            this.pan_city = new System.Windows.Forms.Panel();
            this.com_city = new System.Windows.Forms.ComboBox();
            this.lbl_city = new System.Windows.Forms.Label();
            this.pan_state = new System.Windows.Forms.Panel();
            this.com_state = new System.Windows.Forms.ComboBox();
            this.lbl_state = new System.Windows.Forms.Label();
            this.pan_country = new System.Windows.Forms.Panel();
            this.com_country = new System.Windows.Forms.ComboBox();
            this.lbl_country = new System.Windows.Forms.Label();
            this.pan_phone_no = new System.Windows.Forms.Panel();
            this.txt_phone_no = new System.Windows.Forms.TextBox();
            this.lbl_phone_no = new System.Windows.Forms.Label();
            this.pan_address = new System.Windows.Forms.Panel();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.pan_qualification = new System.Windows.Forms.Panel();
            this.com_qualification = new System.Windows.Forms.ComboBox();
            this.lbl_qualification = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.pan_name.SuspendLayout();
            this.pan_age.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).BeginInit();
            this.pan_gender.SuspendLayout();
            this.pan_city.SuspendLayout();
            this.pan_state.SuspendLayout();
            this.pan_country.SuspendLayout();
            this.pan_phone_no.SuspendLayout();
            this.pan_address.SuspendLayout();
            this.pan_qualification.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // com_select
            // 
            this.com_select.AutoCompleteCustomSource.AddRange(new string[] {
            "name",
            "age",
            "gender",
            "city",
            "state",
            "country",
            "address",
            "phone_no",
            "qualification"});
            this.com_select.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.com_select.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.com_select.FormattingEnabled = true;
            this.com_select.Items.AddRange(new object[] {
            "name",
            "age",
            "gender",
            "city",
            "state",
            "country",
            "address",
            "phone_no",
            "qualification"});
            this.com_select.Location = new System.Drawing.Point(337, 96);
            this.com_select.Name = "com_select";
            this.com_select.Size = new System.Drawing.Size(234, 23);
            this.com_select.TabIndex = 71;
            this.com_select.Click += new System.EventHandler(this.com_select_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_name.Location = new System.Drawing.Point(237, 96);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(59, 19);
            this.lbl_name.TabIndex = 61;
            this.lbl_name.Text = "Select :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(378, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 61;
            this.label1.Text = "Single filter";
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
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(389, 161);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(91, 23);
            this.btn_close.TabIndex = 83;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Location = new System.Drawing.Point(57, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 198);
            this.panel1.TabIndex = 80;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 81;
            this.button1.Text = "Apply Filters";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pan_name
            // 
            this.pan_name.Controls.Add(this.txt_name);
            this.pan_name.Controls.Add(this.label2);
            this.pan_name.Location = new System.Drawing.Point(237, 135);
            this.pan_name.Name = "pan_name";
            this.pan_name.Size = new System.Drawing.Size(339, 43);
            this.pan_name.TabIndex = 119;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(96, 10);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(143, 23);
            this.txt_name.TabIndex = 117;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 116;
            this.label2.Text = "Name:";
            // 
            // pan_age
            // 
            this.pan_age.Controls.Add(this.num_age);
            this.pan_age.Controls.Add(this.lbl_age);
            this.pan_age.Location = new System.Drawing.Point(217, 142);
            this.pan_age.Name = "pan_age";
            this.pan_age.Size = new System.Drawing.Size(354, 33);
            this.pan_age.TabIndex = 118;
            // 
            // num_age
            // 
            this.num_age.Location = new System.Drawing.Point(119, 3);
            this.num_age.Name = "num_age";
            this.num_age.Size = new System.Drawing.Size(178, 23);
            this.num_age.TabIndex = 106;
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
            // pan_gender
            // 
            this.pan_gender.Controls.Add(this.pan_address);
            this.pan_gender.Controls.Add(this.pan_country);
            this.pan_gender.Controls.Add(this.pan_phone_no);
            this.pan_gender.Controls.Add(this.pan_city);
            this.pan_gender.Controls.Add(this.lbl_gender);
            this.pan_gender.Controls.Add(this.rad_male);
            this.pan_gender.Controls.Add(this.rad_female);
            this.pan_gender.Location = new System.Drawing.Point(217, 135);
            this.pan_gender.Name = "pan_gender";
            this.pan_gender.Size = new System.Drawing.Size(356, 45);
            this.pan_gender.TabIndex = 120;
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
            // rad_male
            // 
            this.rad_male.AutoSize = true;
            this.rad_male.Checked = true;
            this.rad_male.Location = new System.Drawing.Point(161, 14);
            this.rad_male.Name = "rad_male";
            this.rad_male.Size = new System.Drawing.Size(51, 19);
            this.rad_male.TabIndex = 107;
            this.rad_male.TabStop = true;
            this.rad_male.Text = "Male";
            this.rad_male.UseVisualStyleBackColor = true;
            // 
            // rad_female
            // 
            this.rad_female.AutoSize = true;
            this.rad_female.Location = new System.Drawing.Point(257, 14);
            this.rad_female.Name = "rad_female";
            this.rad_female.Size = new System.Drawing.Size(63, 19);
            this.rad_female.TabIndex = 108;
            this.rad_female.Text = "Female";
            this.rad_female.UseVisualStyleBackColor = true;
            this.rad_female.CheckedChanged += new System.EventHandler(this.rad_female_CheckedChanged);
            // 
            // pan_city
            // 
            this.pan_city.Controls.Add(this.pan_state);
            this.pan_city.Controls.Add(this.com_city);
            this.pan_city.Controls.Add(this.lbl_city);
            this.pan_city.Location = new System.Drawing.Point(8, 3);
            this.pan_city.Name = "pan_city";
            this.pan_city.Size = new System.Drawing.Size(348, 45);
            this.pan_city.TabIndex = 121;
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
            this.com_city.Location = new System.Drawing.Point(115, 10);
            this.com_city.Name = "com_city";
            this.com_city.Size = new System.Drawing.Size(174, 23);
            this.com_city.TabIndex = 99;
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
            // pan_state
            // 
            this.pan_state.Controls.Add(this.com_state);
            this.pan_state.Controls.Add(this.lbl_state);
            this.pan_state.Location = new System.Drawing.Point(3, 0);
            this.pan_state.Name = "pan_state";
            this.pan_state.Size = new System.Drawing.Size(340, 42);
            this.pan_state.TabIndex = 121;
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
            this.com_state.Location = new System.Drawing.Point(105, 7);
            this.com_state.Name = "com_state";
            this.com_state.Size = new System.Drawing.Size(159, 23);
            this.com_state.TabIndex = 100;
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
            // pan_country
            // 
            this.pan_country.Controls.Add(this.com_country);
            this.pan_country.Controls.Add(this.lbl_country);
            this.pan_country.Location = new System.Drawing.Point(11, 0);
            this.pan_country.Name = "pan_country";
            this.pan_country.Size = new System.Drawing.Size(318, 45);
            this.pan_country.TabIndex = 121;
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
            // pan_phone_no
            // 
            this.pan_phone_no.Controls.Add(this.txt_phone_no);
            this.pan_phone_no.Controls.Add(this.lbl_phone_no);
            this.pan_phone_no.Location = new System.Drawing.Point(8, 2);
            this.pan_phone_no.Name = "pan_phone_no";
            this.pan_phone_no.Size = new System.Drawing.Size(345, 43);
            this.pan_phone_no.TabIndex = 122;
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
            // pan_address
            // 
            this.pan_address.Controls.Add(this.txt_address);
            this.pan_address.Controls.Add(this.lbl_address);
            this.pan_address.Location = new System.Drawing.Point(3, 2);
            this.pan_address.Name = "pan_address";
            this.pan_address.Size = new System.Drawing.Size(345, 58);
            this.pan_address.TabIndex = 121;
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
            // pan_qualification
            // 
            this.pan_qualification.Controls.Add(this.panel3);
            this.pan_qualification.Controls.Add(this.panel2);
            this.pan_qualification.Controls.Add(this.com_qualification);
            this.pan_qualification.Controls.Add(this.lbl_qualification);
            this.pan_qualification.Location = new System.Drawing.Point(208, 133);
            this.pan_qualification.Name = "pan_qualification";
            this.pan_qualification.Size = new System.Drawing.Size(360, 45);
            this.pan_qualification.TabIndex = 121;
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
            this.com_qualification.Size = new System.Drawing.Size(171, 23);
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
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(13, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 43);
            this.panel2.TabIndex = 122;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(143, 23);
            this.textBox1.TabIndex = 117;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(4, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 116;
            this.label3.Text = "Phone no :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(7, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 45);
            this.panel3.TabIndex = 122;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "SSLC",
            "PUC",
            "ITI",
            "DIPLOMA",
            "Bachelor of engineering",
            "Mtech",
            "Btech",
            "MS"});
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SSLC",
            "PUC",
            "ITI",
            "DIPLOMA",
            "Bachelor of engineering",
            "Mtech",
            "Btech",
            "MS"});
            this.comboBox1.Location = new System.Drawing.Point(123, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(142, 23);
            this.comboBox1.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 102;
            this.label4.Text = "Qualification :";
            // 
            // singlefilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.pan_qualification);
            this.Controls.Add(this.pan_gender);
            this.Controls.Add(this.pan_age);
            this.Controls.Add(this.pan_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.com_select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Name = "singlefilter";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.singlefilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pan_name.ResumeLayout(false);
            this.pan_name.PerformLayout();
            this.pan_age.ResumeLayout(false);
            this.pan_age.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_age)).EndInit();
            this.pan_gender.ResumeLayout(false);
            this.pan_gender.PerformLayout();
            this.pan_city.ResumeLayout(false);
            this.pan_city.PerformLayout();
            this.pan_state.ResumeLayout(false);
            this.pan_state.PerformLayout();
            this.pan_country.ResumeLayout(false);
            this.pan_country.PerformLayout();
            this.pan_phone_no.ResumeLayout(false);
            this.pan_phone_no.PerformLayout();
            this.pan_address.ResumeLayout(false);
            this.pan_address.PerformLayout();
            this.pan_qualification.ResumeLayout(false);
            this.pan_qualification.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ComboBox com_select;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btn_delete;
        public System.Windows.Forms.Button btn_close;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pan_name;
        public System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pan_age;
        public System.Windows.Forms.NumericUpDown num_age;
        private System.Windows.Forms.Label lbl_age;
        private System.Windows.Forms.Panel pan_gender;
        private System.Windows.Forms.Label lbl_gender;
        public System.Windows.Forms.RadioButton rad_male;
        public System.Windows.Forms.RadioButton rad_female;
        private System.Windows.Forms.Panel pan_city;
        public System.Windows.Forms.ComboBox com_city;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Panel pan_state;
        public System.Windows.Forms.ComboBox com_state;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Panel pan_country;
        public System.Windows.Forms.ComboBox com_country;
        private System.Windows.Forms.Label lbl_country;
        private System.Windows.Forms.Panel pan_phone_no;
        public System.Windows.Forms.TextBox txt_phone_no;
        private System.Windows.Forms.Label lbl_phone_no;
        private System.Windows.Forms.Panel pan_address;
        public System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Panel pan_qualification;
        public System.Windows.Forms.ComboBox com_qualification;
        private System.Windows.Forms.Label lbl_qualification;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
    }
}