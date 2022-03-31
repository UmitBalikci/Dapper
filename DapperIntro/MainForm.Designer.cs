﻿
namespace DapperIntro
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategoriYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNewProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAllProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategoriYönetimiToolStripMenuItem,
            this.ürünYönetimiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(700, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategoriYönetimiToolStripMenuItem
            // 
            this.kategoriYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewCategory,
            this.menuItemAllCategories});
            this.kategoriYönetimiToolStripMenuItem.Name = "kategoriYönetimiToolStripMenuItem";
            this.kategoriYönetimiToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.kategoriYönetimiToolStripMenuItem.Text = "Kategori Yönetimi";
            // 
            // menuItemNewCategory
            // 
            this.menuItemNewCategory.Name = "menuItemNewCategory";
            this.menuItemNewCategory.Size = new System.Drawing.Size(158, 22);
            this.menuItemNewCategory.Text = "Yeni Kategori";
            this.menuItemNewCategory.Click += new System.EventHandler(this.menuItemNewCategory_Click);
            // 
            // menuItemAllCategories
            // 
            this.menuItemAllCategories.Name = "menuItemAllCategories";
            this.menuItemAllCategories.Size = new System.Drawing.Size(158, 22);
            this.menuItemAllCategories.Text = "Tüm Kategoriler";
            this.menuItemAllCategories.Click += new System.EventHandler(this.menuItemAllCategories_Click);
            // 
            // ürünYönetimiToolStripMenuItem
            // 
            this.ürünYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNewProduct,
            this.menuItemAllProduct});
            this.ürünYönetimiToolStripMenuItem.Name = "ürünYönetimiToolStripMenuItem";
            this.ürünYönetimiToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.ürünYönetimiToolStripMenuItem.Text = "Ürün Yönetimi";
            // 
            // menuItemNewProduct
            // 
            this.menuItemNewProduct.Name = "menuItemNewProduct";
            this.menuItemNewProduct.Size = new System.Drawing.Size(180, 22);
            this.menuItemNewProduct.Text = "Yeni Ürün";
            this.menuItemNewProduct.Click += new System.EventHandler(this.menuItemNewProduct_Click);
            // 
            // menuItemAllProduct
            // 
            this.menuItemAllProduct.Name = "menuItemAllProduct";
            this.menuItemAllProduct.Size = new System.Drawing.Size(180, 22);
            this.menuItemAllProduct.Text = "Tüm Ürünler";
            this.menuItemAllProduct.Click += new System.EventHandler(this.menuItemAllProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategoriYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewCategory;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllCategories;
        private System.Windows.Forms.ToolStripMenuItem ürünYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemNewProduct;
        private System.Windows.Forms.ToolStripMenuItem menuItemAllProduct;
    }
}