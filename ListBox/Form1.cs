using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        String OrgStr = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text;
            this.txtList.Focus();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            CheckText();

        }

        private void CheckText()
        {
            if (this.txtList.Text != "")
            {
                this.lbView.Items.Add(this.txtList.Text);
                this.txtList.Text = "";
            }
            else
            {
                MessageBox.Show("항목을 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.txtList.Focus();
        }

        private void TxtList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                CheckText();
                e.Handled = true;  //입력할 때 소리 안남
            }
        }

        private void LbView_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.lbView.Text;
            //ListBox에 있는 값 클릭시 label에 결과 : ~~ 
        }
    }
}
