﻿using System;
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
    public partial class Login : Form

    {
        Form1 frm = new Form1();
        BLLUser bll = new BLLUser();
        public Login()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable dt = bll.CheckUserLogin(txtName.Text, txtEmail.Text, cboUsertype.Text);
            if (dt.Rows.Count>0) { 
                MessageBox.Show("Login Successful");
                this.Hide();
                frm.Show();
            }
            else
	{
                 MessageBox.Show("Invalid username and password");
	}
           
            
            }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        }
    }
