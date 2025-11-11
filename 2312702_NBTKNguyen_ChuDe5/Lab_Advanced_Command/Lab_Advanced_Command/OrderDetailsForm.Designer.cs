namespace Lab_Advanced_Command
{
    partial class OrderDetailsForm
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
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.FoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.restaurantManagementDataSet = new Lab_Advanced_Command.RestaurantManagementDataSet();
            this.restaurantManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FoodName,
            this.Unit,
            this.Price,
            this.Quantity,
            this.TotalPrice});
            this.dgvDetails.DataSource = this.restaurantManagementDataSetBindingSource;
            this.dgvDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDetails.Location = new System.Drawing.Point(0, 41);
            this.dgvDetails.MultiSelect = false;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.RowHeadersWidth = 51;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(678, 138);
            this.dgvDetails.TabIndex = 19;
            // 
            // FoodName
            // 
            this.FoodName.HeaderText = "FoodName";
            this.FoodName.MinimumWidth = 6;
            this.FoodName.Name = "FoodName";
            this.FoodName.Width = 125;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.MinimumWidth = 6;
            this.Unit.Name = "Unit";
            this.Unit.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // TotalPrice
            // 
            this.TotalPrice.HeaderText = "TotalPrice";
            this.TotalPrice.MinimumWidth = 6;
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Width = 125;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(24, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 20;
            // 
            // restaurantManagementDataSet
            // 
            this.restaurantManagementDataSet.DataSetName = "RestaurantManagementDataSet";
            this.restaurantManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantManagementDataSetBindingSource
            // 
            this.restaurantManagementDataSetBindingSource.DataSource = this.restaurantManagementDataSet;
            this.restaurantManagementDataSetBindingSource.Position = 0;
            // 
            // OrderDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 179);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.dgvDetails);
            this.Name = "OrderDetailsForm";
            this.Text = "Order Details";
            this.Load += new System.EventHandler(this.OrderDetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantManagementDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn FoodName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.BindingSource restaurantManagementDataSetBindingSource;
        private RestaurantManagementDataSet restaurantManagementDataSet;
    }
}