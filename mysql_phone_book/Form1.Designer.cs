
namespace mysql_phone_book
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label first_nameLabel;
			System.Windows.Forms.Label last_nameLabel;
			System.Windows.Forms.Label ageLabel;
			System.Windows.Forms.Label date_of_birthLabel;
			System.Windows.Forms.Label debitLabel;
			System.Windows.Forms.Label call_numberLabel;
			System.Windows.Forms.Label land_lineLabel;
			System.Windows.Forms.Label emailLabel;
			System.Windows.Forms.Label addresLabel;
			System.Windows.Forms.Label commentLabel;
			System.Windows.Forms.Label commentLabel1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.cosutmer_listDataGridView = new System.Windows.Forms.DataGridView();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.first_nameTextBox = new System.Windows.Forms.TextBox();
			this.last_nameTextBox = new System.Windows.Forms.TextBox();
			this.ageTextBox = new System.Windows.Forms.TextBox();
			this.date_of_birthTextBox = new System.Windows.Forms.TextBox();
			this.debitTextBox = new System.Windows.Forms.TextBox();
			this.call_numberTextBox = new System.Windows.Forms.TextBox();
			this.land_lineTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.addresTextBox = new System.Windows.Forms.TextBox();
			this.commentTextBox = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.commentTextBox1 = new System.Windows.Forms.TextBox();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.Add_new_butto_up = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.Edit_button_up = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.Delete_button_up = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.Save_button_up = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.Cancel_button_up = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cosutmer_listBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.phone_book_dataset = new mysql_phone_book.Data_set.phone_book_dataset();
			this.cosutmer_listTableAdapter = new mysql_phone_book.Data_set.phone_book_datasetTableAdapters.cosutmer_listTableAdapter();
			this.tableAdapterManager = new mysql_phone_book.Data_set.phone_book_datasetTableAdapters.TableAdapterManager();
			this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			idLabel = new System.Windows.Forms.Label();
			first_nameLabel = new System.Windows.Forms.Label();
			last_nameLabel = new System.Windows.Forms.Label();
			ageLabel = new System.Windows.Forms.Label();
			date_of_birthLabel = new System.Windows.Forms.Label();
			debitLabel = new System.Windows.Forms.Label();
			call_numberLabel = new System.Windows.Forms.Label();
			land_lineLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			addresLabel = new System.Windows.Forms.Label();
			commentLabel = new System.Windows.Forms.Label();
			commentLabel1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.cosutmer_listDataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cosutmer_listBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.phone_book_dataset)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
			this.bindingNavigator1.SuspendLayout();
			this.SuspendLayout();
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Location = new System.Drawing.Point(216, 14);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(20, 15);
			idLabel.TabIndex = 2;
			idLabel.Text = "id:";
			// 
			// first_nameLabel
			// 
			first_nameLabel.AutoSize = true;
			first_nameLabel.Location = new System.Drawing.Point(216, 41);
			first_nameLabel.Name = "first_nameLabel";
			first_nameLabel.Size = new System.Drawing.Size(64, 15);
			first_nameLabel.TabIndex = 4;
			first_nameLabel.Text = "first name:";
			// 
			// last_nameLabel
			// 
			last_nameLabel.AutoSize = true;
			last_nameLabel.Location = new System.Drawing.Point(216, 68);
			last_nameLabel.Name = "last_nameLabel";
			last_nameLabel.Size = new System.Drawing.Size(64, 15);
			last_nameLabel.TabIndex = 6;
			last_nameLabel.Text = "last name:";
			// 
			// ageLabel
			// 
			ageLabel.AutoSize = true;
			ageLabel.Location = new System.Drawing.Point(216, 95);
			ageLabel.Name = "ageLabel";
			ageLabel.Size = new System.Drawing.Size(31, 15);
			ageLabel.TabIndex = 8;
			ageLabel.Text = "age:";
			// 
			// date_of_birthLabel
			// 
			date_of_birthLabel.AutoSize = true;
			date_of_birthLabel.Location = new System.Drawing.Point(216, 122);
			date_of_birthLabel.Name = "date_of_birthLabel";
			date_of_birthLabel.Size = new System.Drawing.Size(74, 15);
			date_of_birthLabel.TabIndex = 10;
			date_of_birthLabel.Text = "date of birth:";
			// 
			// debitLabel
			// 
			debitLabel.AutoSize = true;
			debitLabel.Location = new System.Drawing.Point(216, 149);
			debitLabel.Name = "debitLabel";
			debitLabel.Size = new System.Drawing.Size(37, 15);
			debitLabel.TabIndex = 12;
			debitLabel.Text = "debit:";
			// 
			// call_numberLabel
			// 
			call_numberLabel.AutoSize = true;
			call_numberLabel.Location = new System.Drawing.Point(216, 176);
			call_numberLabel.Name = "call_numberLabel";
			call_numberLabel.Size = new System.Drawing.Size(75, 15);
			call_numberLabel.TabIndex = 14;
			call_numberLabel.Text = "call number:";
			// 
			// land_lineLabel
			// 
			land_lineLabel.AutoSize = true;
			land_lineLabel.Location = new System.Drawing.Point(216, 203);
			land_lineLabel.Name = "land_lineLabel";
			land_lineLabel.Size = new System.Drawing.Size(57, 15);
			land_lineLabel.TabIndex = 16;
			land_lineLabel.Text = "land line:";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Location = new System.Drawing.Point(216, 230);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(41, 15);
			emailLabel.TabIndex = 18;
			emailLabel.Text = "email:";
			// 
			// addresLabel
			// 
			addresLabel.AutoSize = true;
			addresLabel.Location = new System.Drawing.Point(216, 257);
			addresLabel.Name = "addresLabel";
			addresLabel.Size = new System.Drawing.Size(48, 15);
			addresLabel.TabIndex = 20;
			addresLabel.Text = "addres:";
			// 
			// commentLabel
			// 
			commentLabel.AutoSize = true;
			commentLabel.Location = new System.Drawing.Point(216, 335);
			commentLabel.Name = "commentLabel";
			commentLabel.Size = new System.Drawing.Size(62, 15);
			commentLabel.TabIndex = 22;
			commentLabel.Text = "comment:";
			// 
			// commentLabel1
			// 
			commentLabel1.AutoSize = true;
			commentLabel1.Location = new System.Drawing.Point(216, 285);
			commentLabel1.Name = "commentLabel1";
			commentLabel1.Size = new System.Drawing.Size(62, 15);
			commentLabel1.TabIndex = 23;
			commentLabel1.Text = "comment:";
			commentLabel1.Click += new System.EventHandler(this.commentLabel1_Click);
			// 
			// cosutmer_listDataGridView
			// 
			this.cosutmer_listDataGridView.AllowUserToAddRows = false;
			this.cosutmer_listDataGridView.AllowUserToDeleteRows = false;
			this.cosutmer_listDataGridView.AllowUserToResizeColumns = false;
			this.cosutmer_listDataGridView.AllowUserToResizeRows = false;
			this.cosutmer_listDataGridView.AutoGenerateColumns = false;
			this.cosutmer_listDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cosutmer_listDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
			this.cosutmer_listDataGridView.DataSource = this.cosutmer_listBindingSource;
			this.cosutmer_listDataGridView.Location = new System.Drawing.Point(9, 377);
			this.cosutmer_listDataGridView.Name = "cosutmer_listDataGridView";
			this.cosutmer_listDataGridView.ReadOnly = true;
			this.cosutmer_listDataGridView.Size = new System.Drawing.Size(795, 236);
			this.cosutmer_listDataGridView.TabIndex = 1;
			// 
			// idTextBox
			// 
			this.idTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "id", true));
			this.idTextBox.Location = new System.Drawing.Point(297, 11);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.ReadOnly = true;
			this.idTextBox.Size = new System.Drawing.Size(187, 21);
			this.idTextBox.TabIndex = 3;
			// 
			// first_nameTextBox
			// 
			this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "first_name", true));
			this.first_nameTextBox.Location = new System.Drawing.Point(297, 38);
			this.first_nameTextBox.Name = "first_nameTextBox";
			this.first_nameTextBox.Size = new System.Drawing.Size(187, 21);
			this.first_nameTextBox.TabIndex = 5;
			// 
			// last_nameTextBox
			// 
			this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "last_name", true));
			this.last_nameTextBox.Location = new System.Drawing.Point(297, 65);
			this.last_nameTextBox.Name = "last_nameTextBox";
			this.last_nameTextBox.Size = new System.Drawing.Size(187, 21);
			this.last_nameTextBox.TabIndex = 7;
			// 
			// ageTextBox
			// 
			this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "age", true));
			this.ageTextBox.Location = new System.Drawing.Point(297, 92);
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(187, 21);
			this.ageTextBox.TabIndex = 9;
			// 
			// date_of_birthTextBox
			// 
			this.date_of_birthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "date_of_birth", true));
			this.date_of_birthTextBox.Location = new System.Drawing.Point(297, 119);
			this.date_of_birthTextBox.Name = "date_of_birthTextBox";
			this.date_of_birthTextBox.Size = new System.Drawing.Size(187, 21);
			this.date_of_birthTextBox.TabIndex = 11;
			// 
			// debitTextBox
			// 
			this.debitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "debit", true));
			this.debitTextBox.Location = new System.Drawing.Point(297, 146);
			this.debitTextBox.Name = "debitTextBox";
			this.debitTextBox.Size = new System.Drawing.Size(187, 21);
			this.debitTextBox.TabIndex = 13;
			// 
			// call_numberTextBox
			// 
			this.call_numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "call_number", true));
			this.call_numberTextBox.Location = new System.Drawing.Point(297, 173);
			this.call_numberTextBox.Name = "call_numberTextBox";
			this.call_numberTextBox.Size = new System.Drawing.Size(187, 21);
			this.call_numberTextBox.TabIndex = 15;
			// 
			// land_lineTextBox
			// 
			this.land_lineTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "land_line", true));
			this.land_lineTextBox.Location = new System.Drawing.Point(297, 200);
			this.land_lineTextBox.Name = "land_lineTextBox";
			this.land_lineTextBox.Size = new System.Drawing.Size(187, 21);
			this.land_lineTextBox.TabIndex = 17;
			// 
			// emailTextBox
			// 
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "email", true));
			this.emailTextBox.Location = new System.Drawing.Point(297, 227);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(187, 21);
			this.emailTextBox.TabIndex = 19;
			// 
			// addresTextBox
			// 
			this.addresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "addres", true));
			this.addresTextBox.Location = new System.Drawing.Point(297, 254);
			this.addresTextBox.Name = "addresTextBox";
			this.addresTextBox.Size = new System.Drawing.Size(187, 21);
			this.addresTextBox.TabIndex = 21;
			// 
			// commentTextBox
			// 
			this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "comment", true));
			this.commentTextBox.Location = new System.Drawing.Point(297, 332);
			this.commentTextBox.Name = "commentTextBox";
			this.commentTextBox.Size = new System.Drawing.Size(187, 21);
			this.commentTextBox.TabIndex = 23;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(commentLabel1);
			this.groupBox1.Controls.Add(this.commentTextBox1);
			this.groupBox1.Controls.Add(this.first_nameTextBox);
			this.groupBox1.Controls.Add(idLabel);
			this.groupBox1.Controls.Add(this.commentTextBox);
			this.groupBox1.Controls.Add(this.idTextBox);
			this.groupBox1.Controls.Add(commentLabel);
			this.groupBox1.Controls.Add(first_nameLabel);
			this.groupBox1.Controls.Add(this.addresTextBox);
			this.groupBox1.Controls.Add(addresLabel);
			this.groupBox1.Controls.Add(last_nameLabel);
			this.groupBox1.Controls.Add(this.emailTextBox);
			this.groupBox1.Controls.Add(this.last_nameTextBox);
			this.groupBox1.Controls.Add(emailLabel);
			this.groupBox1.Controls.Add(ageLabel);
			this.groupBox1.Controls.Add(this.land_lineTextBox);
			this.groupBox1.Controls.Add(this.ageTextBox);
			this.groupBox1.Controls.Add(land_lineLabel);
			this.groupBox1.Controls.Add(date_of_birthLabel);
			this.groupBox1.Controls.Add(this.call_numberTextBox);
			this.groupBox1.Controls.Add(this.date_of_birthTextBox);
			this.groupBox1.Controls.Add(call_numberLabel);
			this.groupBox1.Controls.Add(debitLabel);
			this.groupBox1.Controls.Add(this.debitTextBox);
			this.groupBox1.Location = new System.Drawing.Point(9, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(795, 373);
			this.groupBox1.TabIndex = 24;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Register and edited window";
			// 
			// commentTextBox1
			// 
			this.commentTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cosutmer_listBindingSource, "comment", true));
			this.commentTextBox1.Location = new System.Drawing.Point(297, 282);
			this.commentTextBox1.Name = "commentTextBox1";
			this.commentTextBox1.Size = new System.Drawing.Size(187, 21);
			this.commentTextBox1.TabIndex = 24;
			// 
			// toolStrip1
			// 
			this.toolStrip1.AutoSize = false;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Add_new_butto_up,
            this.toolStripSeparator4,
            this.Edit_button_up,
            this.toolStripSeparator5,
            this.Delete_button_up,
            this.toolStripSeparator6,
            this.Save_button_up,
            this.toolStripSeparator7,
            this.Cancel_button_up,
            this.toolStripSeparator8});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(814, 47);
			this.toolStrip1.TabIndex = 25;
			this.toolStrip1.Text = "toolStrip1";
			this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
			// 
			// Add_new_butto_up
			// 
			this.Add_new_butto_up.Image = global::mysql_phone_book.Properties.Resources._1646001_add_create_new_plus_icon__1_;
			this.Add_new_butto_up.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Add_new_butto_up.Name = "Add_new_butto_up";
			this.Add_new_butto_up.Size = new System.Drawing.Size(76, 44);
			this.Add_new_butto_up.Text = "Add New";
			this.Add_new_butto_up.Click += new System.EventHandler(this.Add_new_butto_up_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 47);
			// 
			// Edit_button_up
			// 
			this.Edit_button_up.Image = global::mysql_phone_book.Properties.Resources._3855617_edit_pencil_write_mode_icon;
			this.Edit_button_up.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Edit_button_up.Name = "Edit_button_up";
			this.Edit_button_up.Size = new System.Drawing.Size(47, 44);
			this.Edit_button_up.Text = "Edit";
			this.Edit_button_up.Click += new System.EventHandler(this.Edit_button_up_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 47);
			// 
			// Delete_button_up
			// 
			this.Delete_button_up.Image = global::mysql_phone_book.Properties.Resources._9004715_cross_delete_remove_cancel_icon;
			this.Delete_button_up.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Delete_button_up.Name = "Delete_button_up";
			this.Delete_button_up.Size = new System.Drawing.Size(60, 44);
			this.Delete_button_up.Text = "Delete";
			this.Delete_button_up.Click += new System.EventHandler(this.Delete_button_up_Click);
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 47);
			// 
			// Save_button_up
			// 
			this.Save_button_up.Enabled = false;
			this.Save_button_up.Image = global::mysql_phone_book.Properties.Resources._285657_floppy_guardar_save_icon;
			this.Save_button_up.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Save_button_up.Name = "Save_button_up";
			this.Save_button_up.Size = new System.Drawing.Size(51, 44);
			this.Save_button_up.Text = "Save";
			this.Save_button_up.Click += new System.EventHandler(this.Save_button_up_Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 47);
			// 
			// Cancel_button_up
			// 
			this.Cancel_button_up.Enabled = false;
			this.Cancel_button_up.Image = global::mysql_phone_book.Properties.Resources._3909341_cancel_delete_document_file_files_icon;
			this.Cancel_button_up.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.Cancel_button_up.Name = "Cancel_button_up";
			this.Cancel_button_up.Size = new System.Drawing.Size(63, 44);
			this.Cancel_button_up.Text = "Cancel";
			this.Cancel_button_up.Click += new System.EventHandler(this.Cancel_button_up_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(6, 47);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "first_name";
			this.dataGridViewTextBoxColumn2.HeaderText = "first_name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "last_name";
			this.dataGridViewTextBoxColumn3.HeaderText = "last_name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "age";
			this.dataGridViewTextBoxColumn4.HeaderText = "age";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "date_of_birth";
			this.dataGridViewTextBoxColumn5.HeaderText = "date_of_birth";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "debit";
			this.dataGridViewTextBoxColumn6.HeaderText = "debit";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "call_number";
			this.dataGridViewTextBoxColumn7.HeaderText = "call_number";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "land_line";
			this.dataGridViewTextBoxColumn8.HeaderText = "land_line";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "email";
			this.dataGridViewTextBoxColumn9.HeaderText = "email";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "addres";
			this.dataGridViewTextBoxColumn10.HeaderText = "addres";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "comment";
			this.dataGridViewTextBoxColumn11.HeaderText = "comment";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// cosutmer_listBindingSource
			// 
			this.cosutmer_listBindingSource.DataMember = "cosutmer_list";
			this.cosutmer_listBindingSource.DataSource = this.phone_book_dataset;
			// 
			// phone_book_dataset
			// 
			this.phone_book_dataset.DataSetName = "phone_book_dataset";
			this.phone_book_dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cosutmer_listTableAdapter
			// 
			this.cosutmer_listTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.cosutmer_listTableAdapter = this.cosutmer_listTableAdapter;
			this.tableAdapterManager.UpdateOrder = mysql_phone_book.Data_set.phone_book_datasetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// bindingNavigator1
			// 
			this.bindingNavigator1.AddNewItem = null;
			this.bindingNavigator1.BindingSource = this.cosutmer_listBindingSource;
			this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
			this.bindingNavigator1.DeleteItem = null;
			this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
			this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
			this.bindingNavigator1.Location = new System.Drawing.Point(353, 10);
			this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.bindingNavigator1.Name = "bindingNavigator1";
			this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
			this.bindingNavigator1.Size = new System.Drawing.Size(463, 25);
			this.bindingNavigator1.TabIndex = 26;
			this.bindingNavigator1.Text = "bindingNavigator1";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(80, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(105, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(83, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(78, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(814, 614);
			this.Controls.Add(this.bindingNavigator1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.cosutmer_listDataGridView);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phone Book";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.cosutmer_listDataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cosutmer_listBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.phone_book_dataset)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
			this.bindingNavigator1.ResumeLayout(false);
			this.bindingNavigator1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Data_set.phone_book_dataset phone_book_dataset;
		private System.Windows.Forms.BindingSource cosutmer_listBindingSource;
		private Data_set.phone_book_datasetTableAdapters.cosutmer_listTableAdapter cosutmer_listTableAdapter;
		private Data_set.phone_book_datasetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView cosutmer_listDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox first_nameTextBox;
		private System.Windows.Forms.TextBox last_nameTextBox;
		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.TextBox date_of_birthTextBox;
		private System.Windows.Forms.TextBox debitTextBox;
		private System.Windows.Forms.TextBox call_numberTextBox;
		private System.Windows.Forms.TextBox land_lineTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox addresTextBox;
		private System.Windows.Forms.TextBox commentTextBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox commentTextBox1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton Add_new_butto_up;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton Edit_button_up;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripButton Delete_button_up;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripButton Save_button_up;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton Cancel_button_up;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.BindingNavigator bindingNavigator1;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
	}
}

