namespace Lab07_Entity_Framework
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReloadCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddFood = new System.Windows.Forms.Button();
            this.btnReloadFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tvwCategory = new System.Windows.Forms.TreeView();
            this.lvwFood = new System.Windows.Forms.ListView();
            this.clMaSo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh mục";
            // 
            // btnReloadCategory
            // 
            this.btnReloadCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadCategory.Location = new System.Drawing.Point(192, 9);
            this.btnReloadCategory.Name = "btnReloadCategory";
            this.btnReloadCategory.Size = new System.Drawing.Size(41, 28);
            this.btnReloadCategory.TabIndex = 1;
            this.btnReloadCategory.Text = "R";
            this.toolTip1.SetToolTip(this.btnReloadCategory, "Tải lại danh mục");
            this.btnReloadCategory.UseVisualStyleBackColor = true;
            this.btnReloadCategory.Click += new System.EventHandler(this.btnReloadCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(239, 9);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(41, 28);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddCategory, "Thêm danh mục mới");
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.Location = new System.Drawing.Point(910, 9);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(41, 28);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "+";
            this.toolTip1.SetToolTip(this.btnAddFood, "Thêm món ăn mới");
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // btnReloadFood
            // 
            this.btnReloadFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReloadFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReloadFood.Location = new System.Drawing.Point(816, 9);
            this.btnReloadFood.Name = "btnReloadFood";
            this.btnReloadFood.Size = new System.Drawing.Size(41, 28);
            this.btnReloadFood.TabIndex = 3;
            this.btnReloadFood.Text = "R";
            this.toolTip1.SetToolTip(this.btnReloadFood, "Tải lại danh sách món ăn");
            this.btnReloadFood.UseVisualStyleBackColor = true;
            this.btnReloadFood.Click += new System.EventHandler(this.btnReloadFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteFood.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.Location = new System.Drawing.Point(863, 9);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(41, 28);
            this.btnDeleteFood.TabIndex = 5;
            this.btnDeleteFood.Text = "-";
            this.toolTip1.SetToolTip(this.btnDeleteFood, "Xóa món ăn được chọn");
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Thực đơn";
            // 
            // tvwCategory
            // 
            this.tvwCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwCategory.Location = new System.Drawing.Point(12, 43);
            this.tvwCategory.Name = "tvwCategory";
            this.tvwCategory.Size = new System.Drawing.Size(268, 348);
            this.tvwCategory.TabIndex = 7;
            this.tvwCategory.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwCategory_AfterSelect);
            this.tvwCategory.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwCategory_NodeMouseDoubleClick);
            // 
            // lvwFood
            // 
            this.lvwFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwFood.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clMaSo,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvwFood.FullRowSelect = true;
            this.lvwFood.GridLines = true;
            this.lvwFood.HideSelection = false;
            this.lvwFood.Location = new System.Drawing.Point(300, 43);
            this.lvwFood.MultiSelect = false;
            this.lvwFood.Name = "lvwFood";
            this.lvwFood.Size = new System.Drawing.Size(651, 348);
            this.lvwFood.TabIndex = 8;
            this.lvwFood.UseCompatibleStateImageBehavior = false;
            this.lvwFood.View = System.Windows.Forms.View.Details;
            this.lvwFood.DoubleClick += new System.EventHandler(this.lvwFood_DoubleClick);
            // 
            // clMaSo
            // 
            this.clMaSo.Text = "Mã số";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên đồ ăn/Thức uống";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ĐV Tính";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá bán";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nhóm mặt hàng";
            this.columnHeader4.Width = 182;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ghi chú";
            this.columnHeader5.Width = 221;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 403);
            this.Controls.Add(this.lvwFood);
            this.Controls.Add(this.tvwCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.btnReloadFood);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnReloadCategory);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhà hàng";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReloadCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnReloadFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TreeView tvwCategory;
        private System.Windows.Forms.ListView lvwFood;
        private System.Windows.Forms.ColumnHeader clMaSo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

