namespace Lab_Basic_Command
{
    partial class FoodForm
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
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.clID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFoodCategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.restaurantManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantManagementDataSet = new Lab_Basic_Command.RestaurantManagementDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFood
            // 
            this.dgvFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFood.AutoGenerateColumns = false;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clID,
            this.clName,
            this.clUnit,
            this.clFoodCategoryID,
            this.clPrice,
            this.clNotes});
            this.dgvFood.DataSource = this.restaurantManagementDataSetBindingSource;
            this.dgvFood.Location = new System.Drawing.Point(0, 0);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 24;
            this.dgvFood.Size = new System.Drawing.Size(800, 184);
            this.dgvFood.TabIndex = 0;
            // 
            // clID
            // 
            this.clID.DataPropertyName = "ID";
            this.clID.HeaderText = "Mã món";
            this.clID.MinimumWidth = 6;
            this.clID.Name = "clID";
            this.clID.Width = 125;
            // 
            // clName
            // 
            this.clName.DataPropertyName = "Name";
            this.clName.HeaderText = "Tên món";
            this.clName.MinimumWidth = 6;
            this.clName.Name = "clName";
            this.clName.Width = 125;
            // 
            // clUnit
            // 
            this.clUnit.DataPropertyName = "Unit";
            this.clUnit.HeaderText = "Đơn vị tính";
            this.clUnit.MinimumWidth = 6;
            this.clUnit.Name = "clUnit";
            this.clUnit.Width = 125;
            // 
            // clFoodCategoryID
            // 
            this.clFoodCategoryID.DataPropertyName = "FoodCategoryID";
            this.clFoodCategoryID.HeaderText = "Mã nhóm";
            this.clFoodCategoryID.MinimumWidth = 6;
            this.clFoodCategoryID.Name = "clFoodCategoryID";
            this.clFoodCategoryID.Width = 125;
            // 
            // clPrice
            // 
            this.clPrice.DataPropertyName = "Price";
            this.clPrice.HeaderText = "Đơn giá";
            this.clPrice.MinimumWidth = 6;
            this.clPrice.Name = "clPrice";
            this.clPrice.Width = 125;
            // 
            // clNotes
            // 
            this.clNotes.DataPropertyName = "Notes";
            this.clNotes.HeaderText = "Ghi chú";
            this.clNotes.MinimumWidth = 6;
            this.clNotes.Name = "clNotes";
            this.clNotes.Width = 125;
            // 
            // restaurantManagementDataSetBindingSource
            // 
            this.restaurantManagementDataSetBindingSource.DataSource = this.restaurantManagementDataSet;
            this.restaurantManagementDataSetBindingSource.Position = 0;
            // 
            // restaurantManagementDataSet
            // 
            this.restaurantManagementDataSet.DataSetName = "RestaurantManagementDataSet";
            this.restaurantManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(140, 201);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(519, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 43);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 266);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvFood);
            this.Name = "FoodForm";
            this.Text = "Danh sách món ăn";
            this.Load += new System.EventHandler(this.FoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFood;
        private System.Windows.Forms.DataGridViewTextBoxColumn clID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFoodCategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNotes;
        private System.Windows.Forms.BindingSource restaurantManagementDataSetBindingSource;
        private RestaurantManagementDataSet restaurantManagementDataSet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}