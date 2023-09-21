using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace RsaForm01
{
    public partial class frmRsaTools : Form
    {
        public frmRsaTools()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 获取公钥
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGetPublicKey_Click(object sender, EventArgs e)
        {
            try
            {
                string[] keys = RsaTools.createRsaKey();

                this.txtPublicKey.Text = keys[0];
                this.txtPrivateKey.Text = keys[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示");
            }
        }
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEn_Click(object sender, EventArgs e)
        {
            try
            {
                 this.txtResult.Text = RsaTools.EncrytByPublic(this.txtPublicKey.Text,this.txtEn.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示");
            }

        }
        /// <summary>
        /// 解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCi_Click(object sender, EventArgs e)
        {
            try
            {
                this.txtResult.Text = RsaTools.DecryptByPrivate(this.txtPrivateKey.Text,this.txtEn.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "系统提示");
            }
        }

        private void txtEn_TextChanged(object sender, EventArgs e)
        {
            this.lab_len.Text = "内容长度："+this.txtEn.Text.Length.ToString();
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
            this.lab_resLen.Text = "结果长度：" + this.txtResult.Text.Length.ToString();
        }
    }
}
