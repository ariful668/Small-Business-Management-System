namespace SmallBusinessManagement
{
    partial class SupplierUi
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
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.contactPersonTextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.contactPersonLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SL,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.contactpersonDataGridViewTextBoxColumn});
            this.showDataGridView.DataSource = this.supplierBindingSource;
            this.showDataGridView.Location = new System.Drawing.Point(67, 337);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(668, 155);
            this.showDataGridView.TabIndex = 40;
            this.showDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellContentClick_1);
            // 
            // SL
            // 
            this.SL.DataPropertyName = "id";
            this.SL.HeaderText = "SL";
            this.SL.Name = "SL";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(470, 297);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 39;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // contactPersonTextBox
            // 
            this.contactPersonTextBox.Location = new System.Drawing.Point(333, 285);
            this.contactPersonTextBox.Name = "contactPersonTextBox";
            this.contactPersonTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactPersonTextBox.TabIndex = 38;
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(333, 241);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactTextBox.TabIndex = 37;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(333, 201);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 36;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(333, 162);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 35;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(333, 125);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 34;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(333, 93);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 33;
            // 
            // contactPersonLabel
            // 
            this.contactPersonLabel.AutoSize = true;
            this.contactPersonLabel.Location = new System.Drawing.Point(235, 292);
            this.contactPersonLabel.Name = "contactPersonLabel";
            this.contactPersonLabel.Size = new System.Drawing.Size(77, 13);
            this.contactPersonLabel.TabIndex = 32;
            this.contactPersonLabel.Text = "ContactPerson";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(235, 248);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(44, 13);
            this.contactLabel.TabIndex = 31;
            this.contactLabel.Text = "Contact";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(235, 208);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(32, 13);
            this.emailLabel.TabIndex = 30;
            this.emailLabel.Text = "Email";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(235, 169);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 29;
            this.addressLabel.Text = "Address";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(235, 128);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 28;
            this.nameLabel.Text = "Name";
            // 
            // codeLabel
            // 
            this.codeLabel.AutoSize = true;
            this.codeLabel.Location = new System.Drawing.Point(235, 93);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(32, 13);
            this.codeLabel.TabIndex = 27;
            this.codeLabel.Text = "Code";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(576, 296);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 42;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(67, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(485, 20);
            this.searchTextBox.TabIndex = 44;
            this.searchTextBox.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 43;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // contactpersonDataGridViewTextBoxColumn
            // 
            this.contactpersonDataGridViewTextBoxColumn.DataPropertyName = "contactperson";
            this.contactpersonDataGridViewTextBoxColumn.HeaderText = "contactperson";
            this.contactpersonDataGridViewTextBoxColumn.Name = "contactpersonDataGridViewTextBoxColumn";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(SmallBusinessManagement.Model.Supplier);
            // 
            // SupplierUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.contactPersonTextBox);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.contactPersonLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.codeLabel);
            this.Name = "SupplierUi";
            this.Text = "Supplier";
            this.Load += new System.EventHandler(this.SupplierUi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox contactPersonTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label contactPersonLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button updateButton;
        public System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button button1;
    }
}