﻿namespace MainProgram
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Location = new System.Drawing.Point(12, 80);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(131, 12);
            this.labelQuestion.TabIndex = 6;
            this.labelQuestion.Text = "欢迎您使用博锐ERP软件";

            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MainProgram.Properties.Resources.TitleZonebackgroundImage;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 62);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "版本更新说明";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "当前软件版本：V2.5.58";

            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(14, 140);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 90);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "1、所有销售类单据数据录入页面，增加品牌栏目，包含销售订单、销售出库单、领料单、盘亏毁损单、其他出库单\r\n";
            this.richTextBox1.Text += "2、材料变更单套打模板中增加了部分名称和所属部件信息\r\n";
            this.richTextBox1.Text += "3、其他出库单套打模板增加项目编号和生产编号信息\r\n";
            this.richTextBox1.Text += "4、针对盘亏亏损单，当单据为已审核时，在单据右上角显示已审核字样\r\n";
            this.richTextBox1.Text += "5、在各类单据中，需要选择部门时，在新打开的部门信息页面中，默认展开部门信息树节点\r\n";

            // Fo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 253);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "关于博锐软件";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}