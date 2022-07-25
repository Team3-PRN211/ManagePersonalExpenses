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
    public partial class FrmRecords : Form
    {
        IRecordRepository recordRepository = new RecordRepository();
        ISubCategoryRepository subCategoryRepository = new SubCategoryRepository();
        ITypeRepository typeRepository = new TypeRepository();
        int count = 0;
        
        public Record record { get; set; }
        public FrmRecords()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var records = (from r in recordRepository.GetAll()
                           join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                           join t in typeRepository.GetAll() on r.TypeId equals t.TypeId
                           where r.UserId == Session.id
                           select new {
                               r.RecordId,
                               r.Money,
                               r.Date,
                               SubCategory = s.Name,
                               Type = t.Name,
                               r.Description,
                               
                           }).ToList();

            
            dgvRecord.DataSource = records;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddRecord frmAddRecord = new FrmAddRecord()

            {
                Text = "Add Record",
                InsertOrUpdate = false,

            };
            if (frmAddRecord.ShowDialog().Equals(DialogResult.OK))
            {
                LoadData();
                
            }
        }

        private void dgvRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int id = (int)dgvRecord.CurrentRow.Cells["RecordId"].Value;
            Record a = recordRepository.GetRecordById(id);
            FrmAddRecord frmAddRecord = new FrmAddRecord
            {
                Text = "Update Record",
                InsertOrUpdate = true,
                record = a
            };
            if (frmAddRecord.ShowDialog().Equals(DialogResult.OK))
            {
                LoadData();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id =(int) dgvRecord.CurrentRow.Cells["RecordId"].Value;
                Record record = recordRepository.GetRecordById(id);
                DialogResult dialogResult = MessageBox.Show("Do you want to delete Record: ", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    recordRepository.Delete(record);
                    MessageBox.Show("Record has been deleted successfully!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete");
            }
        }

        

        
        private void FrmRecords_Load(object sender, EventArgs e)
        {
            LoadData();
            var category = subCategoryRepository.GetAll();
            cbCategory.DataSource = category;
            cbCategory.DisplayMember = "Name";
            cbCategory.ValueMember = "SubCategoryId";

            var type = typeRepository.GetAll();
            cbType.DataSource = type;
            cbType.DisplayMember = "Name";
            cbType.ValueMember = "TypeId";

            cbMoney.SelectedIndex = 0;
            cbDate.SelectedIndex = 0;
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
			if (count < 3)
			{
                count++;
                return;
			}
            
            var records = (from r in recordRepository.GetAll()
                           join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                           join t in typeRepository.GetAll() on r.TypeId equals t.TypeId
                           where r.SubCategoryId == (int)cbCategory.SelectedValue &&  r.UserId == Session.id
                           select new
                           {
                               r.RecordId,
                               r.Money,
                               r.Date,
                               Category = s.Name,
                               Type = t.Name,
                               r.Description
                           }).ToList();

            dgvRecord.DataSource = records;
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (count < 6)
            {
                count++;
                return;
            }



            var records = (from r in recordRepository.GetAll()
                           join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                           join t in typeRepository.GetAll() on r.TypeId equals t.TypeId
                           where r.TypeId == (int) cbType.SelectedValue && r.UserId == Session.id
                           select new
                           {
                               r.RecordId,
                               r.Money,
                               r.Date,
                               Category = s.Name,
                               Type = t.Name,
                               r.Description
                           }).ToList();


            dgvRecord.DataSource = records;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var records = (from r in recordRepository.GetAll()
                           join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                           join t in typeRepository.GetAll() on r.TypeId equals t.TypeId
                           where s.Name.ToLower().Contains(txtSearch.Text.ToLower()) && r.UserId == Session.id
                           select new
                           {
                               r.RecordId,
                               r.Money,
                               r.Date,
                               Category = s.Name,
                               Type = t.Name,
                               r.Description
                           }).ToList();


            dgvRecord.DataSource = records;
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            var records = (from r in recordRepository.GetAll()
                           join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                           join t in typeRepository.GetAll() on r.TypeId equals t.TypeId
                           where r.Date >=  dtpStartTime.Value && r.Date <= dtpEndTime.Value && r.UserId == Session.id
                           select new
                           {
                               r.RecordId,
                               r.Money,
                               r.Date,
                               Category = s.Name,
                               Type = t.Name,
                               r.Description
                           }).ToList();


            dgvRecord.DataSource = records;
        }

        private void dgvRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMoney_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMoney_SelectedValueChanged(object sender, EventArgs e)

        {
            if (count < 7)
            {
                count++;
                return;
            }

            if (cbMoney.SelectedIndex == 0)
            {
                var records = (from r in recordRepository.GetAll()
                               join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                               join t in typeRepository.GetAll() on r.TypeId equals t.TypeId
                               where r.UserId == Session.id
                               orderby r.Money ascending
                               select new
                               {
                                   r.RecordId,
                                   r.Money,
                                   r.Date,
                                   Category = s.Name,
                                   Type = t.Name,
                                   r.Description
                               }).ToList();
                dgvRecord.DataSource = records;
            }
            else
            {
                var records = (from r in recordRepository.GetAll()
                               join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                               join t in typeRepository.GetAll() on r.TypeId equals t.TypeId
                               where r.UserId == Session.id
                               orderby r.Money descending
                               select new
                               {
                                   r.RecordId,
                                   r.Money,
                                   r.Date,
                                   Category = s.Name,
                                   Type = t.Name,
                                   r.Description
                               }).ToList();
                dgvRecord.DataSource = records;
            }
            


            
        }

        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (count < 8)
            {
                count++;
                return;
            }

            if (cbDate.SelectedIndex == 0)
            {
                var records = (from r in recordRepository.GetAll()
                               join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                               join t in typeRepository.GetAll() on r.TypeId equals t.TypeId
                               where r.UserId == Session.id
                               orderby r.Date ascending
                               select new
                               {
                                   r.RecordId,
                                   r.Money,
                                   r.Date,
                                   Category = s.Name,
                                   Type = t.Name,
                                   r.Description
                               }).ToList();
                dgvRecord.DataSource = records;
            }
            else
            {
                var records = (from r in recordRepository.GetAll()
                               join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                               join t in typeRepository.GetAll() on r.TypeId equals t.TypeId
                               where r.UserId == Session.id
                               orderby r.Date descending
                               select new
                               {
                                   r.RecordId,
                                   r.Money,
                                   r.Date,
                                   Category = s.Name,
                                   Type = t.Name,
                                   r.Description
                               }).ToList();
                dgvRecord.DataSource = records;
            }
        }
    }
}
