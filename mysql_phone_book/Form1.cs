using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mysql_phone_book
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cosutmer_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.cosutmer_listBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.phone_book_dataset);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'phone_book_dataset.cosutmer_list' table. You can move, or remove it, as needed.
			this.cosutmer_listTableAdapter.Fill(this.phone_book_dataset.cosutmer_list);
			//---------------------------------------------------------
			this.Save_button_up.Enabled = false;
			this.Cancel_button_up.Enabled = false;
			//---------------------------------------------------------
			this.cosutmer_listDataGridView.Enabled = true;
			this.groupBox1.Enabled = false;
			//---------------------------------------------------------
			this.cosutmer_listBindingNavigator.Enabled = true;
		}

		private void commentLabel1_Click(object sender, EventArgs e)
		{

		}
		private void new_edit_del_butt()
		{
			this.Add_new_butto_up.Enabled = false;
			this.Edit_button_up.Enabled = false;
			this.Delete_button_up.Enabled = false;
			//-----------------------------------
			this.Save_button_up.Enabled = true;
			this.Cancel_button_up.Enabled = true;
			//-----------------------------------
			this.cosutmer_listDataGridView.Enabled = false;
			this.groupBox1.Enabled = true;
			//----------------------------------
			this.cosutmer_listBindingNavigator.Enabled = false;
		}
		private void save_cancel_butt()
		{
			//-----------------------------------
			this.Save_button_up.Enabled = false;
			this.Cancel_button_up.Enabled = false;
			//-----------------------------------
			this.Add_new_butto_up.Enabled = true;
			this.Edit_button_up.Enabled = true;
			this.Delete_button_up.Enabled = true;
			//-----------------------------------
			this.cosutmer_listDataGridView.Enabled = true;
			this.groupBox1.Enabled = false;
			//-----------------------------------
			this.cosutmer_listBindingNavigator.Enabled = true;
		}
		private void Add_new_butto_up_Click(object sender, EventArgs e)
		{
			new_edit_del_butt();
		}
		private void Save_button_up_Click(object sender, EventArgs e)
		{
			save_cancel_butt();
		}
		private void Edit_button_up_Click(object sender, EventArgs e)
		{
			new_edit_del_butt();
		}

		private void Delete_button_up_Click(object sender, EventArgs e)
		{
			new_edit_del_butt();
		}

		private void Cancel_button_up_Click(object sender, EventArgs e)
		{
			save_cancel_butt();
		}
	}
}
