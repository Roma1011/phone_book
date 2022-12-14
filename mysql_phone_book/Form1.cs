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
		}

		private void commentLabel1_Click(object sender, EventArgs e)
		{

		}
		private void new_edit_del_butt(string but_name)
		{
			this.Add_new_butto_up.Enabled = false;
			this.Edit_button_up.Enabled = false;
			this.Delete_button_up.Enabled = false;
			//-----------------------------------
			this.Save_button_up.Enabled = true;
			this.Cancel_button_up.Enabled = true;
			//-----------------------------------
			this.cosutmer_listDataGridView.Enabled = false;
				if(but_name== "del_butt")
				{
					this.groupBox1.Enabled = false;
				}
				else
				{
					this.groupBox1.Enabled = true;
				}
			//----------------------------------
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
		}
		private void Add_new_butto_up_Click(object sender, EventArgs e)
		{
			new_edit_del_butt("new_butt");
			//---------------add new record-------------
			this.cosutmer_listBindingSource.AddNew();
			//------------------------------------------
		}
		private void Save_button_up_Click(object sender, EventArgs e)
		{
			save_cancel_butt();
			//----------------------------------
			this.cosutmer_listBindingSource.EndEdit();
			Int32 r=this.cosutmer_listTableAdapter.Update(this.phone_book_dataset.cosutmer_list);
			if (r > 0)
			{
				MessageBox.Show("Saved!");
			}
			else
				MessageBox.Show("Nothing Saved!");
		}
		private void Edit_button_up_Click(object sender, EventArgs e)
		{
			//---------------------------
			Int32 rc=this.phone_book_dataset.cosutmer_list.Rows.Count;
			if(rc==0)
			{
				MessageBox.Show("Please selct your record to edit!");
				return;
			}
			//---------------------------
			new_edit_del_butt("edit_butt");
		}

		private void Delete_button_up_Click(object sender, EventArgs e)
		{
			//--------------empty row checker--------------------
			Int32 rc = this.phone_book_dataset.cosutmer_list.Rows.Count;
			if (rc == 0)
			{
				MessageBox.Show("Please selct your record to delete!");
				return;
			}
			new_edit_del_butt("del_butt");
			//----------------delete record---------------
			this.cosutmer_listBindingSource.RemoveCurrent();
			//--------------------------------------------
		}

		private void Cancel_button_up_Click(object sender, EventArgs e)
		{
			save_cancel_butt();
			//------------cancel changes---------
			this.phone_book_dataset.cosutmer_list.RejectChanges();
			this.cosutmer_listBindingSource.CancelEdit();
			//-----------------------------------
		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
		{
		}
	}
}
