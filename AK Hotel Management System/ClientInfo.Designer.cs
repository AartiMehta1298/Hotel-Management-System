
namespace AK_Hotel_Management_System
{
    partial class ClientInfo
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientInfo));
            this.lblDate = new System.Windows.Forms.Label();
            this.ClientIdlbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClientNamelbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.ClientPhonelbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.Clienctrylbl = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnEdit = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.clientsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClientGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientCountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienttblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.akhotelDataSet = new AK_Hotel_Management_System.akhotelDataSet();
            this.client_tblTableAdapter = new AK_Hotel_Management_System.akhotelDataSetTableAdapters.Client_tblTableAdapter();
            this.btnsearch = new System.Windows.Forms.Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roomButton5 = new Guna.UI2.WinForms.Guna2Button();
            this.reservation2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.staffButton3 = new Guna.UI2.WinForms.Guna2Button();
            this.clintButton2 = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.akhotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(26, 55);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 15);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            // 
            // ClientIdlbl
            // 
            this.ClientIdlbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientIdlbl.DefaultText = "";
            this.ClientIdlbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientIdlbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientIdlbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientIdlbl.DisabledState.Parent = this.ClientIdlbl;
            this.ClientIdlbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientIdlbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientIdlbl.FocusedState.Parent = this.ClientIdlbl;
            this.ClientIdlbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientIdlbl.HoverState.Parent = this.ClientIdlbl;
            this.ClientIdlbl.Location = new System.Drawing.Point(374, 199);
            this.ClientIdlbl.Margin = new System.Windows.Forms.Padding(6);
            this.ClientIdlbl.Name = "ClientIdlbl";
            this.ClientIdlbl.PasswordChar = '\0';
            this.ClientIdlbl.PlaceholderText = "ClientId";
            this.ClientIdlbl.SelectedText = "";
            this.ClientIdlbl.ShadowDecoration.Parent = this.ClientIdlbl;
            this.ClientIdlbl.Size = new System.Drawing.Size(210, 39);
            this.ClientIdlbl.TabIndex = 1;
            this.ClientIdlbl.TextChanged += new System.EventHandler(this.ClientIdlbl_TextChanged);
            // 
            // ClientNamelbl
            // 
            this.ClientNamelbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientNamelbl.DefaultText = "";
            this.ClientNamelbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientNamelbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientNamelbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientNamelbl.DisabledState.Parent = this.ClientNamelbl;
            this.ClientNamelbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientNamelbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientNamelbl.FocusedState.Parent = this.ClientNamelbl;
            this.ClientNamelbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientNamelbl.HoverState.Parent = this.ClientNamelbl;
            this.ClientNamelbl.Location = new System.Drawing.Point(371, 260);
            this.ClientNamelbl.Margin = new System.Windows.Forms.Padding(6);
            this.ClientNamelbl.Name = "ClientNamelbl";
            this.ClientNamelbl.PasswordChar = '\0';
            this.ClientNamelbl.PlaceholderText = "ClientName";
            this.ClientNamelbl.SelectedText = "";
            this.ClientNamelbl.ShadowDecoration.Parent = this.ClientNamelbl;
            this.ClientNamelbl.Size = new System.Drawing.Size(213, 36);
            this.ClientNamelbl.TabIndex = 2;
            this.ClientNamelbl.TextChanged += new System.EventHandler(this.ClientNamelbl_TextChanged);
            // 
            // ClientPhonelbl
            // 
            this.ClientPhonelbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ClientPhonelbl.DefaultText = "";
            this.ClientPhonelbl.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ClientPhonelbl.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ClientPhonelbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientPhonelbl.DisabledState.Parent = this.ClientPhonelbl;
            this.ClientPhonelbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ClientPhonelbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientPhonelbl.FocusedState.Parent = this.ClientPhonelbl;
            this.ClientPhonelbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientPhonelbl.HoverState.Parent = this.ClientPhonelbl;
            this.ClientPhonelbl.Location = new System.Drawing.Point(371, 319);
            this.ClientPhonelbl.Margin = new System.Windows.Forms.Padding(6);
            this.ClientPhonelbl.Name = "ClientPhonelbl";
            this.ClientPhonelbl.PasswordChar = '\0';
            this.ClientPhonelbl.PlaceholderText = "Phone Number";
            this.ClientPhonelbl.SelectedText = "";
            this.ClientPhonelbl.ShadowDecoration.Parent = this.ClientPhonelbl;
            this.ClientPhonelbl.Size = new System.Drawing.Size(213, 35);
            this.ClientPhonelbl.TabIndex = 3;
            this.ClientPhonelbl.TextChanged += new System.EventHandler(this.ClientPhonelbl_TextChanged);
            // 
            // Clienctrylbl
            // 
            this.Clienctrylbl.BackColor = System.Drawing.Color.Transparent;
            this.Clienctrylbl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Clienctrylbl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Clienctrylbl.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Clienctrylbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Clienctrylbl.FocusedState.Parent = this.Clienctrylbl;
            this.Clienctrylbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Clienctrylbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Clienctrylbl.HoverState.Parent = this.Clienctrylbl;
            this.Clienctrylbl.ItemHeight = 30;
            this.Clienctrylbl.Items.AddRange(new object[] {
            "Afghanistan",
            "Albania",
            "Algeria",
            "Andorra",
            "Angola",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Australia",
            "Austria",
            "Austrian Empire",
            "Azerbaijan",
            "",
            "Baden*",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Bavaria*",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin (Dahomey)",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Brazil",
            "Brunei",
            "Brunswick and Lüneburg",
            "Bulgaria",
            "Burkina Faso (Upper Volta)",
            "Burma",
            "Burundi",
            "",
            "Cabo Verde",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cayman Islands, The",
            "Central African Republic",
            "Central American Federation*",
            "Chad",
            "Chile",
            "China",
            "Colombia",
            "Comoros",
            "Congo Free State, The",
            "Costa Rica",
            "Cote d’Ivoire (Ivory Coast)",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czechia",
            "Czechoslovakia",
            "",
            "Democratic Republic of the Congo",
            "Denmark",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Duchy of Parma, The*",
            "",
            "East Germany (German Democratic Republic)",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Eswatini",
            "Ethiopia",
            "",
            "Federal Government of Germany (1848-49)*",
            "Fiji",
            "Finland",
            "France",
            "",
            "Gabon",
            "Gambia, The",
            "Georgia",
            "Germany",
            "Ghana",
            "Grand Duchy of Tuscany, The*",
            "Greece",
            "Grenada",
            "Guatemala",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "",
            "Haiti",
            "Hanover*",
            "Hanseatic Republics*",
            "Hawaii*",
            "Hesse*",
            "Holy See",
            "Honduras",
            "Hungary",
            "",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Israel",
            "Italy",
            "",
            "Jamaica",
            "Japan",
            "Jordan",
            "",
            "Kazakhstan",
            "Kenya",
            "Kingdom of Serbia/Yugoslavia*",
            "Kiribati",
            "Korea",
            "Kosovo",
            "Kuwait",
            "Kyrgyzstan",
            "",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Lew Chew (Loochoo)*",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg"});
            this.Clienctrylbl.ItemsAppearance.Parent = this.Clienctrylbl;
            this.Clienctrylbl.Location = new System.Drawing.Point(407, 380);
            this.Clienctrylbl.Name = "Clienctrylbl";
            this.Clienctrylbl.ShadowDecoration.Parent = this.Clienctrylbl;
            this.Clienctrylbl.Size = new System.Drawing.Size(168, 36);
            this.Clienctrylbl.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdd.BorderColor = System.Drawing.Color.White;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(618, 422);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(114, 33);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(743, 422);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(114, 33);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(872, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(114, 33);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // clientsearch
            // 
            this.clientsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.clientsearch.DefaultText = "";
            this.clientsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.clientsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.clientsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientsearch.DisabledState.Parent = this.clientsearch;
            this.clientsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.clientsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientsearch.FocusedState.Parent = this.clientsearch;
            this.clientsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.clientsearch.HoverState.Parent = this.clientsearch;
            this.clientsearch.Location = new System.Drawing.Point(746, 79);
            this.clientsearch.Name = "clientsearch";
            this.clientsearch.PasswordChar = '\0';
            this.clientsearch.PlaceholderText = "ClientSearch";
            this.clientsearch.SelectedText = "";
            this.clientsearch.ShadowDecoration.Parent = this.clientsearch;
            this.clientsearch.Size = new System.Drawing.Size(200, 36);
            this.clientsearch.TabIndex = 11;
            this.clientsearch.TextChanged += new System.EventHandler(this.clientsearch_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ClientGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientGridView.AutoGenerateColumns = false;
            this.ClientGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClientGridView.BackgroundColor = System.Drawing.Color.White;
            this.ClientGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientGridView.ColumnHeadersHeight = 21;
            this.ClientGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIdDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.clientPhoneDataGridViewTextBoxColumn,
            this.clientCountryDataGridViewTextBoxColumn});
            this.ClientGridView.DataSource = this.clienttblBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClientGridView.EnableHeadersVisualStyles = false;
            this.ClientGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientGridView.Location = new System.Drawing.Point(618, 135);
            this.ClientGridView.Name = "ClientGridView";
            this.ClientGridView.RowHeadersVisible = false;
            this.ClientGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientGridView.Size = new System.Drawing.Size(464, 281);
            this.ClientGridView.TabIndex = 12;
            this.ClientGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Cyan;
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ClientGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ClientGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ClientGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(235)))), ((int)(((byte)(241)))));
            this.ClientGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(211)))));
            this.ClientGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ClientGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClientGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ClientGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ClientGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.ClientGridView.ThemeStyle.ReadOnly = false;
            this.ClientGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.ClientGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ClientGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ClientGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ClientGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ClientGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(210)))), ((int)(((byte)(225)))));
            this.ClientGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ClientGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridView_CellContentClick);
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            this.clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            this.clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // clientPhoneDataGridViewTextBoxColumn
            // 
            this.clientPhoneDataGridViewTextBoxColumn.DataPropertyName = "ClientPhone";
            this.clientPhoneDataGridViewTextBoxColumn.HeaderText = "ClientPhone";
            this.clientPhoneDataGridViewTextBoxColumn.Name = "clientPhoneDataGridViewTextBoxColumn";
            // 
            // clientCountryDataGridViewTextBoxColumn
            // 
            this.clientCountryDataGridViewTextBoxColumn.DataPropertyName = "ClientCountry";
            this.clientCountryDataGridViewTextBoxColumn.HeaderText = "ClientCountry";
            this.clientCountryDataGridViewTextBoxColumn.Name = "clientCountryDataGridViewTextBoxColumn";
            // 
            // clienttblBindingSource
            // 
            this.clienttblBindingSource.DataMember = "Client_tbl";
            this.clienttblBindingSource.DataSource = this.akhotelDataSet;
            // 
            // akhotelDataSet
            // 
            this.akhotelDataSet.DataSetName = "akhotelDataSet";
            this.akhotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // client_tblTableAdapter
            // 
            this.client_tblTableAdapter.ClearBeforeFill = true;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Teal;
            this.btnsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(952, 79);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 36);
            this.btnsearch.TabIndex = 13;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(1033, 80);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(46, 35);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 27;
            this.guna2CirclePictureBox1.TabStop = false;
            this.guna2CirclePictureBox1.Click += new System.EventHandler(this.guna2CirclePictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.roomButton5);
            this.panel2.Controls.Add(this.reservation2Button4);
            this.panel2.Controls.Add(this.staffButton3);
            this.panel2.Controls.Add(this.clintButton2);
            this.panel2.Location = new System.Drawing.Point(1, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 438);
            this.panel2.TabIndex = 46;
            // 
            // roomButton5
            // 
            this.roomButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomButton5.BackgroundImage")));
            this.roomButton5.BorderRadius = 20;
            this.roomButton5.BorderThickness = 1;
            this.roomButton5.CheckedState.Parent = this.roomButton5;
            this.roomButton5.CustomImages.Parent = this.roomButton5;
            this.roomButton5.FillColor = System.Drawing.Color.White;
            this.roomButton5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.roomButton5.ForeColor = System.Drawing.Color.Teal;
            this.roomButton5.HoverState.Parent = this.roomButton5;
            this.roomButton5.Location = new System.Drawing.Point(45, 178);
            this.roomButton5.Name = "roomButton5";
            this.roomButton5.ShadowDecoration.Parent = this.roomButton5;
            this.roomButton5.Size = new System.Drawing.Size(169, 37);
            this.roomButton5.TabIndex = 3;
            this.roomButton5.Text = "Room";
            this.roomButton5.Click += new System.EventHandler(this.roomButton5_Click);
            // 
            // reservation2Button4
            // 
            this.reservation2Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reservation2Button4.BackgroundImage")));
            this.reservation2Button4.BorderRadius = 20;
            this.reservation2Button4.BorderThickness = 1;
            this.reservation2Button4.CheckedState.Parent = this.reservation2Button4;
            this.reservation2Button4.CustomImages.Parent = this.reservation2Button4;
            this.reservation2Button4.FillColor = System.Drawing.Color.White;
            this.reservation2Button4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.reservation2Button4.ForeColor = System.Drawing.Color.Teal;
            this.reservation2Button4.HoverState.Parent = this.reservation2Button4;
            this.reservation2Button4.Location = new System.Drawing.Point(45, 250);
            this.reservation2Button4.Name = "reservation2Button4";
            this.reservation2Button4.ShadowDecoration.Parent = this.reservation2Button4;
            this.reservation2Button4.Size = new System.Drawing.Size(169, 37);
            this.reservation2Button4.TabIndex = 2;
            this.reservation2Button4.Text = "Reservation";
            this.reservation2Button4.Click += new System.EventHandler(this.reservation2Button4_Click);
            // 
            // staffButton3
            // 
            this.staffButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staffButton3.BackgroundImage")));
            this.staffButton3.BorderRadius = 20;
            this.staffButton3.BorderThickness = 1;
            this.staffButton3.CheckedState.Parent = this.staffButton3;
            this.staffButton3.CustomImages.Parent = this.staffButton3;
            this.staffButton3.FillColor = System.Drawing.Color.White;
            this.staffButton3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.staffButton3.ForeColor = System.Drawing.Color.Teal;
            this.staffButton3.HoverState.Parent = this.staffButton3;
            this.staffButton3.Location = new System.Drawing.Point(45, 109);
            this.staffButton3.Name = "staffButton3";
            this.staffButton3.ShadowDecoration.Parent = this.staffButton3;
            this.staffButton3.Size = new System.Drawing.Size(169, 37);
            this.staffButton3.TabIndex = 1;
            this.staffButton3.Text = "Staff";
            this.staffButton3.Click += new System.EventHandler(this.staffButton3_Click);
            // 
            // clintButton2
            // 
            this.clintButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clintButton2.BackgroundImage")));
            this.clintButton2.BorderRadius = 20;
            this.clintButton2.BorderThickness = 1;
            this.clintButton2.CheckedState.Parent = this.clintButton2;
            this.clintButton2.CustomImages.Parent = this.clintButton2;
            this.clintButton2.FillColor = System.Drawing.Color.White;
            this.clintButton2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.clintButton2.ForeColor = System.Drawing.Color.Teal;
            this.clintButton2.HoverState.Parent = this.clintButton2;
            this.clintButton2.Location = new System.Drawing.Point(45, 42);
            this.clintButton2.Name = "clintButton2";
            this.clintButton2.ShadowDecoration.Parent = this.clintButton2;
            this.clintButton2.Size = new System.Drawing.Size(169, 37);
            this.clintButton2.TabIndex = 0;
            this.clintButton2.Text = "Client";
            this.clintButton2.Click += new System.EventHandler(this.clintButton2_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.lblDate);
            this.panel3.Controls.Add(this.guna2HtmlLabel1);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(1, -2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1089, 75);
            this.panel3.TabIndex = 45;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Sitka Display", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(11, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(468, 54);
            this.guna2HtmlLabel1.TabIndex = 9;
            this.guna2HtmlLabel1.Text = "AK Hotel Management System ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button1.BackgroundImage")));
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(978, 35);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(81, 37);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1062, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "x";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumTurquoise;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(265, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 45);
            this.label2.TabIndex = 10;
            this.label2.Text = "Client Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(270, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(305, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Copyright @ 2021. All rights reserved  C# My Design";
            // 
            // ClientInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1094, 485);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.ClientGridView);
            this.Controls.Add(this.clientsearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Clienctrylbl);
            this.Controls.Add(this.ClientPhonelbl);
            this.Controls.Add(this.ClientNamelbl);
            this.Controls.Add(this.ClientIdlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientInfo";
            this.Load += new System.EventHandler(this.ClientInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienttblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.akhotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox ClientIdlbl;
        private Guna.UI2.WinForms.Guna2TextBox ClientNamelbl;
        private Guna.UI2.WinForms.Guna2TextBox ClientPhonelbl;
        private Guna.UI2.WinForms.Guna2ComboBox Clienctrylbl;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2TextBox clientsearch;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2DataGridView ClientGridView;
        private akhotelDataSet akhotelDataSet;
        private System.Windows.Forms.BindingSource clienttblBindingSource;
        private akhotelDataSetTableAdapters.Client_tblTableAdapter client_tblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientCountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnsearch;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button roomButton5;
        private Guna.UI2.WinForms.Guna2Button reservation2Button4;
        private Guna.UI2.WinForms.Guna2Button staffButton3;
        private Guna.UI2.WinForms.Guna2Button clintButton2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}