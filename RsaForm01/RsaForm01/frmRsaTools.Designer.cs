
namespace RsaForm01
{
    partial class frmRsaTools
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRsaTools));
            this.btnGetPublicKey = new System.Windows.Forms.Button();
            this.btnEn = new System.Windows.Forms.Button();
            this.btnCi = new System.Windows.Forms.Button();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtEn = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lab_len = new System.Windows.Forms.Label();
            this.lab_resLen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetPublicKey
            // 
            this.btnGetPublicKey.Location = new System.Drawing.Point(682, 225);
            this.btnGetPublicKey.Name = "btnGetPublicKey";
            this.btnGetPublicKey.Size = new System.Drawing.Size(154, 38);
            this.btnGetPublicKey.TabIndex = 0;
            this.btnGetPublicKey.Text = "生成RSA钥匙";
            this.btnGetPublicKey.UseVisualStyleBackColor = true;
            this.btnGetPublicKey.Click += new System.EventHandler(this.btnGetPublicKey_Click);
            // 
            // btnEn
            // 
            this.btnEn.Location = new System.Drawing.Point(515, 509);
            this.btnEn.Name = "btnEn";
            this.btnEn.Size = new System.Drawing.Size(151, 35);
            this.btnEn.TabIndex = 1;
            this.btnEn.Text = "加密";
            this.btnEn.UseVisualStyleBackColor = true;
            this.btnEn.Click += new System.EventHandler(this.btnEn_Click);
            // 
            // btnCi
            // 
            this.btnCi.Location = new System.Drawing.Point(685, 509);
            this.btnCi.Name = "btnCi";
            this.btnCi.Size = new System.Drawing.Size(154, 35);
            this.btnCi.TabIndex = 2;
            this.btnCi.Text = "解密";
            this.btnCi.UseVisualStyleBackColor = true;
            this.btnCi.Click += new System.EventHandler(this.btnCi_Click);
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrivateKey.Location = new System.Drawing.Point(3, 21);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPrivateKey.Size = new System.Drawing.Size(818, 76);
            this.txtPrivateKey.TabIndex = 0;
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPublicKey.Location = new System.Drawing.Point(3, 21);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPublicKey.Size = new System.Drawing.Size(821, 76);
            this.txtPublicKey.TabIndex = 0;
            // 
            // txtEn
            // 
            this.txtEn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEn.Location = new System.Drawing.Point(3, 21);
            this.txtEn.Multiline = true;
            this.txtEn.Name = "txtEn";
            this.txtEn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtEn.Size = new System.Drawing.Size(818, 93);
            this.txtEn.TabIndex = 0;
            this.txtEn.TextChanged += new System.EventHandler(this.txtEn_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Location = new System.Drawing.Point(3, 21);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(818, 86);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEn);
            this.groupBox1.Location = new System.Drawing.Point(12, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "内容：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Location = new System.Drawing.Point(15, 392);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(824, 110);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "结果：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPublicKey);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(827, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "公钥：";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPrivateKey);
            this.groupBox4.Location = new System.Drawing.Point(15, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(824, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "密钥：";
            // 
            // lab_len
            // 
            this.lab_len.AutoSize = true;
            this.lab_len.Location = new System.Drawing.Point(15, 519);
            this.lab_len.Name = "lab_len";
            this.lab_len.Size = new System.Drawing.Size(0, 15);
            this.lab_len.TabIndex = 6;
            // 
            // lab_resLen
            // 
            this.lab_resLen.AutoSize = true;
            this.lab_resLen.Location = new System.Drawing.Point(279, 519);
            this.lab_resLen.Name = "lab_resLen";
            this.lab_resLen.Size = new System.Drawing.Size(0, 15);
            this.lab_resLen.TabIndex = 7;
            // 
            // frmRsaTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 563);
            this.Controls.Add(this.lab_resLen);
            this.Controls.Add(this.lab_len);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCi);
            this.Controls.Add(this.btnEn);
            this.Controls.Add(this.btnGetPublicKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRsaTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetPublicKey;
        private System.Windows.Forms.Button btnEn;
        private System.Windows.Forms.Button btnCi;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtEn;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lab_len;
        private System.Windows.Forms.Label lab_resLen;
    }
}

