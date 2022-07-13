namespace GUI
{
    partial class FrmAddSubcategory
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.managePersonalExpensesContextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.managePersonalExpensesContextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.managePersonalExpensesContextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.managePersonalExpensesContextBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(107, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(107, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(443, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CategoryName";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(272, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Insert";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(532, 271);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(241, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(125, 27);
            this.txtName.TabIndex = 6;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(241, 188);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(125, 27);
            this.txtDes.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "Add  Subcategory";
            // 
            // cbCate
            // 
            this.cbCate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(619, 94);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(151, 28);
            this.cbCate.TabIndex = 10;
            this.cbCate.SelectedIndexChanged += new System.EventHandler(this.cbCate_SelectedIndexChanged);
            // 
            // managePersonalExpensesContextBindingSource
            // 
            this.managePersonalExpensesContextBindingSource.DataSource = typeof(BusinessObject.Models.ManagePersonalExpensesContext);
            // 
            // managePersonalExpensesContextBindingSource1
            // 
            this.managePersonalExpensesContextBindingSource1.DataSource = typeof(BusinessObject.Models.ManagePersonalExpensesContext);
            // 
            // FrmAddSubcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 428);
            this.Controls.Add(this.cbCate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FrmAddSubcategory";
            this.Text = "FrmAddSubcategory";
            this.Load += new System.EventHandler(this.FrmAddSubcategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.managePersonalExpensesContextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.managePersonalExpensesContextBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.BindingSource managePersonalExpensesContextBindingSource;
        private System.Windows.Forms.BindingSource managePersonalExpensesContextBindingSource1;
    }
}