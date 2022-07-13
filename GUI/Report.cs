using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Repository;

namespace GUI
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        IRecordRepository recordRepository = new RecordRepository();
        ISubCategoryRepository subCategoryRepository = new SubCategoryRepository();
        ICategoryRepository categoryRepository = new CategoryRepository();
        private void Report_Load(object sender, EventArgs e)
        {
            cbTime.SelectedIndex = 0;


            var total = recordRepository.GetAll()
                .Where(r => r.Date.ToString("dd/MM/yyyy") == DateTime.Now.Date.ToString("dd/MM/yyyy"))
                .Where(r => r.UserId == Session.id)
                .Sum(r => r.Money);

        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTime.SelectedIndex == 0)
            {

                var total = recordRepository.GetAll()
               .Where(r => r.Date.ToString("dd/MM/yyyy") == DateTime.Now.Date.ToString("dd/MM/yyyy"))
               .Where(r => r.UserId == Session.id)
               .Sum(r => r.Money);
                txtTotal.Text = total.ToString();
                var records = (from r in recordRepository.GetAll()
                               join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                               join c in categoryRepository.GetAll() on s.CategoryId equals c.CategoryId
                               where r.Date.ToString("dd/MM/yyyy") == DateTime.UtcNow.Date.ToString("dd/MM/yyyy") && r.UserId == Session.id
                               group r by c.Name into a
                               select new
                               {
                                   Category = a.Key,
                                   Total = a.Sum(b => b.Money),
                                   Present = (double)Math.Round((decimal)(100 * a.Sum(b => b.Money)) / total),
                               }).ToList();


                dgvReport.DataSource = records;
            }
            if (cbTime.SelectedIndex == 1)
            {
                var total = recordRepository.GetAll().Where(r => r.Date.Month == DateTime.Now.Month)
                    .Where(r => r.UserId == Session.id)
                    .Sum(r => r.Money);
                txtTotal.Text = total.ToString();
                var records = (from r in recordRepository.GetAll()
                               join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                               join c in categoryRepository.GetAll() on s.CategoryId equals c.CategoryId
                               where r.Date.Month == DateTime.Now.Month && r.UserId == Session.id
                               group r by c.Name into a
                               select new
                               {
                                   Category = a.Key,
                                   Total = a.Sum(b => b.Money),
                                   Present = (double)Math.Round((decimal)(100 * a.Sum(b => b.Money)) / total),
                               }).ToList();


                dgvReport.DataSource = records;
            }
            if (cbTime.SelectedIndex == 2)
            {
                var total = recordRepository.GetAll().Where(r => r.Date.Year == DateTime.Now.Year)
                    .Where(r => r.UserId == Session.id)
                    .Sum(r => r.Money);
                txtTotal.Text = total.ToString();
                var records = (from r in recordRepository.GetAll()
                               join s in subCategoryRepository.GetAll() on r.SubCategoryId equals s.SubCategoryId
                               join c in categoryRepository.GetAll() on s.CategoryId equals c.CategoryId
                               where r.Date.Year == DateTime.Now.Year && r.UserId == Session.id
                               group r by c.Name into a
                               select new
                               {
                                   Category = a.Key,
                                   Total = a.Sum(b => b.Money),
                                   Present = (double)Math.Round((decimal)(100 * a.Sum(b => b.Money)) / total),
                               }).ToList();


                dgvReport.DataSource = records;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
