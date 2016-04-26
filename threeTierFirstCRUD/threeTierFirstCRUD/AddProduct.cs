using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace threeTierFirstCRUD
{
    public partial class AddProduct : Form
    {
        BLLCategory blc = new BLLCategory();
        BLLProduct blb = new BLLProduct();
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            LoadCategory();
            LoadGrid();
           

        }

        private void LoadGrid()
        {
                DataTable dt =blb.LoadGV();
           
            if (dt.Rows.Count > 0)
            {


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells["colProductId"].Value = dt.Rows[i]["ProductId"].ToString();
                    dataGridView1.Rows[i].Cells["ColCategoryId"].Value = dt.Rows[i]["CategoryId"].ToString();
                    dataGridView1.Rows[i].Cells["ColCategoryName"].Value = dt.Rows[i]["CategoryName"].ToString();
                    dataGridView1.Rows[i].Cells["colProductName"].Value = dt.Rows[i]["Product Name"].ToString();
                    dataGridView1.Rows[i].Cells["colUnitPrice"].Value = dt.Rows[i]["Unit Price"].ToString();
                    dataGridView1.Rows[i].Cells["colQuantity"].Value = dt.Rows[i]["Quantity"].ToString();

                }
            }
        }

        private void LoadCategory()
        {
            DataTable dt = blc.GetAllCategory();
            cboCategory.DataSource = dt;
            cboCategory.ValueMember = "CategoryId";
            cboCategory.DisplayMember = "CategoryName";
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
          int i=   blb.CreateProduct(Convert.ToInt32( cboCategory.SelectedValue.ToString()), txtProductName.Text, Convert.ToDecimal(txtUnitprice.Text), Convert.ToInt32(txtQuantity.Text));
          if (i>0)
          {
              MessageBox.Show("Inserted Successfully");
              LoadGrid();
          }
        }
    }
}
