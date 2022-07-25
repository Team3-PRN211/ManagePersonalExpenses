using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject.Models;
using DataAccess.Repository;

namespace GUI
{
    public partial class FrmAddRecord : Form
    {
        public FrmAddRecord()
        {

            InitializeComponent();
            dtpDate.Value = DateTime.Now;
        }

        public bool InsertOrUpdate { get; set; }

        public Record record { get; set; }

        ISubCategoryRepository subCategoryRepository = new SubCategoryRepository();
        ITypeRepository typeRepository = new TypeRepository();
        IRecordRepository recordRepository = new RecordRepository();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Record r = new Record
                {
                    Money = nudMoney.Value,
                    Date = dtpDate.Value,
                    SubCategoryId = (int)cbCategory.SelectedValue,
                    TypeId = (int)cbType.SelectedValue,
                    Description = txtDescription.Text,
                    UserId = Session.id
                };
                if (!InsertOrUpdate)
                {
                    recordRepository.Insert(r);
                    dtpDate.Value = DateTime.Now;
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Record has been created Successfully!");
                    this.Close();
                }
                else
                {
                    record.Money = nudMoney.Value;
                    record.Date = dtpDate.Value;
                    record.SubCategoryId = (int)cbCategory.SelectedValue;
                    record.TypeId = (int)cbType.SelectedValue;
                    record.Description = txtDescription.Text;
                    record.UserId = Session.id;
                    recordRepository.Update(record);
                    dtpDate.Value = DateTime.Now;
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Record has been updated Successfully!");
                    Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, !InsertOrUpdate ? "Add a new record" : "Update a record");
            }
        }

        private void FrmAddRecord_Load(object sender, EventArgs e)
        {
            var category = subCategoryRepository.GetAll();
            cbCategory.DataSource = category;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "SubCategoryId";


            var type = typeRepository.GetAll();
            cbType.DataSource = type;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "TypeId";

            if (InsertOrUpdate)
            {
                nudMoney.Value = record.Money;
                dtpDate.Value = record.Date;
                var categoryName = category.First(x => x.SubCategoryId == record.SubCategoryId).Name;
                cbCategory.Text = categoryName;
                var typeName = type.First(x => x.TypeId == record.TypeId).Name;
                cbType.Text = typeName;
                txtDescription.Text = record.Description;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        => Close();
    }
}
