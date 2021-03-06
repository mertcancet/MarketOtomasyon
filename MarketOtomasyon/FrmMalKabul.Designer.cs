﻿namespace MarketOtomasyon
{
    partial class FrmMalKabul
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
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.nuPackageQuantity = new System.Windows.Forms.NumericUpDown();
            this.nuQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtBarcodePackage = new System.Windows.Forms.TextBox();
            this.txtBarcodeProduct = new System.Windows.Forms.TextBox();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.btnMalKabul = new System.Windows.Forms.Button();
            this.tvProduct = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.lstOrderDetails = new System.Windows.Forms.ListBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nuPackageQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCategory
            // 
            this.txtCategory.Enabled = false;
            this.txtCategory.Location = new System.Drawing.Point(85, 141);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(120, 20);
            this.txtCategory.TabIndex = 0;
            // 
            // txtProduct
            // 
            this.txtProduct.Enabled = false;
            this.txtProduct.Location = new System.Drawing.Point(84, 167);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(120, 20);
            this.txtProduct.TabIndex = 1;
            // 
            // nuPackageQuantity
            // 
            this.nuPackageQuantity.Location = new System.Drawing.Point(84, 194);
            this.nuPackageQuantity.Name = "nuPackageQuantity";
            this.nuPackageQuantity.Size = new System.Drawing.Size(120, 20);
            this.nuPackageQuantity.TabIndex = 2;
            // 
            // nuQuantity
            // 
            this.nuQuantity.Location = new System.Drawing.Point(84, 220);
            this.nuQuantity.Name = "nuQuantity";
            this.nuQuantity.Size = new System.Drawing.Size(120, 20);
            this.nuQuantity.TabIndex = 3;
            // 
            // txtBarcodePackage
            // 
            this.txtBarcodePackage.Location = new System.Drawing.Point(84, 115);
            this.txtBarcodePackage.Name = "txtBarcodePackage";
            this.txtBarcodePackage.Size = new System.Drawing.Size(120, 20);
            this.txtBarcodePackage.TabIndex = 4;
            this.txtBarcodePackage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcodePackage_KeyDown);
            // 
            // txtBarcodeProduct
            // 
            this.txtBarcodeProduct.Location = new System.Drawing.Point(85, 89);
            this.txtBarcodeProduct.Name = "txtBarcodeProduct";
            this.txtBarcodeProduct.Size = new System.Drawing.Size(120, 20);
            this.txtBarcodeProduct.TabIndex = 5;
            this.txtBarcodeProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarcodeProduct_KeyDown);
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(84, 246);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(120, 20);
            this.txtBuyPrice.TabIndex = 6;
            // 
            // btnMalKabul
            // 
            this.btnMalKabul.Location = new System.Drawing.Point(482, 220);
            this.btnMalKabul.Name = "btnMalKabul";
            this.btnMalKabul.Size = new System.Drawing.Size(93, 46);
            this.btnMalKabul.TabIndex = 7;
            this.btnMalKabul.Text = "Mal Kabul";
            this.btnMalKabul.UseVisualStyleBackColor = true;
            this.btnMalKabul.Click += new System.EventHandler(this.btnMalKabul_Click);
            // 
            // tvProduct
            // 
            this.tvProduct.Location = new System.Drawing.Point(581, 12);
            this.tvProduct.Name = "tvProduct";
            this.tvProduct.Size = new System.Drawing.Size(146, 254);
            this.tvProduct.TabIndex = 8;
            this.tvProduct.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvProduct_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Koli Barkod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün Barkod";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ürün Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Koli İçi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Adet";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Alış Fiyatı";
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(217, 220);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(93, 46);
            this.btnSepeteEkle.TabIndex = 16;
            this.btnSepeteEkle.Text = "Sipariş Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // lstOrderDetails
            // 
            this.lstOrderDetails.FormattingEnabled = true;
            this.lstOrderDetails.Location = new System.Drawing.Point(217, 89);
            this.lstOrderDetails.Name = "lstOrderDetails";
            this.lstOrderDetails.Size = new System.Drawing.Size(358, 108);
            this.lstOrderDetails.TabIndex = 17;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(6, 11);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(114, 23);
            this.btnCreateOrder.TabIndex = 18;
            this.btnCreateOrder.Text = "Sipariş oluştur";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(143, 12);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbOrder.TabIndex = 19;
            // 
            // FrmMalKabul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 300);
            this.Controls.Add(this.cmbOrder);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.lstOrderDetails);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvProduct);
            this.Controls.Add(this.btnMalKabul);
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.txtBarcodeProduct);
            this.Controls.Add(this.txtBarcodePackage);
            this.Controls.Add(this.nuQuantity);
            this.Controls.Add(this.nuPackageQuantity);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtCategory);
            this.Name = "FrmMalKabul";
            this.Text = "MalKabul";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMalKabul_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuPackageQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.NumericUpDown nuPackageQuantity;
        private System.Windows.Forms.NumericUpDown nuQuantity;
        private System.Windows.Forms.TextBox txtBarcodePackage;
        private System.Windows.Forms.TextBox txtBarcodeProduct;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Button btnMalKabul;
        private System.Windows.Forms.TreeView tvProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ListBox lstOrderDetails;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.ComboBox cmbOrder;
    }
}