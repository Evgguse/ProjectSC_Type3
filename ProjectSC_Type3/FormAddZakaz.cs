using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace ProjectSC_Type3
{
    public partial class FormAddZakaz : MetroFramework.Forms.MetroForm
    {
        BDprojectsc db = new BDprojectsc();
        public int index;
        public string cPrepod;
        public string cPredmet;
        public string cTime;
        public int idprep;
        public int idkurs;

        public FormAddZakaz()
        {
            InitializeComponent();
        }

        private void FormAddZakaz_Activated(object sender, EventArgs e)
        {
 
        }

        private void cbKurs_SelectedIndexChanged(object sender, EventArgs e)
        {
  
        }

        private void cbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPrepod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbKurs_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbKurs_SelectionChangeCommitted(object sender, EventArgs e)
        {

            idkurs = db.Kurs.FirstOrDefault(n => n.Name_Kurs == cbKurs.Text).id_kurs;
            var prepod = db.Prepod.SqlQuery("select * from Prepod,PredPrep where Prepod.id_prepod=PredPrep.id_prepod and PredPrep.id_kurs ="+ idkurs + " ")
               .Select(n => n.F_Name + " " + n.I_Name + " " + n.O_Name).ToList();
            cbPrepod.DataSource = prepod;
            cbPrepod.Text = cPrepod;
        }

        private void cbPrepod_SelectionChangeCommitted(object sender, EventArgs e)
        {
            idprep = db.Prepod.FirstOrDefault(n => n.F_Name + " " + n.I_Name + " " + n.O_Name == cbPrepod.Text).id_prepod;
            var time = db.TimeSC.SqlQuery("select * from TimeSC where not exists(select * from Zakaz where Zakaz.lstime = TimeSC.id_time and Zakaz.id_prepod = " + idprep + ")")
               .Select(n => n.text_time).ToList();
            
            cbTime.DataSource = time;
            cbTime.Text = cTime;
        }

        private void cbTime_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tbPrice.Text = (db.Kurs.FirstOrDefault(n => n.Name_Kurs == cbKurs.Text).Price).ToString();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (cbKurs.Text != "" && cbPrepod.Text != "" && cbTime.Text != "" && dtpZakaz.Text != "")
            {
                if (this.Text == "Добавление")
                {
                    Zakaz zzk = new Zakaz
                    {
                        id_user = db.Users.FirstOrDefault(n => n.UF_Name + " " + n.UI_Name + " " + n.UO_Name == Program.f1.tbAccount.Text).id_user,
                        id_prepod = db.Prepod.FirstOrDefault(n => n.F_Name + " " + n.I_Name + " " + n.O_Name == cbPrepod.Text).id_prepod,
                        id_kurs = db.Kurs.FirstOrDefault(n => n.Name_Kurs == cbKurs.Text).id_kurs,
                        lstime = db.TimeSC.FirstOrDefault(n => n.text_time == cbTime.Text).id_time,
                        DateZ = dtpZakaz.Value
                    };

                    db.Zakaz.Add(zzk);
                    db.SaveChanges();
                }
                else
                {
                    Zakaz skl = db.Zakaz.FirstOrDefault(n => n.id_zakaz == index);
                    skl.id_user = db.Users.FirstOrDefault(n => n.UF_Name + " " + n.UI_Name + " " + n.UO_Name == Program.f1.tbAccount.Text).id_user;
                    skl.id_prepod = db.Prepod.FirstOrDefault(n => n.F_Name + " " + n.I_Name + " " + n.O_Name == cbPrepod.Text).id_prepod;
                    skl.id_kurs = db.Kurs.FirstOrDefault(n => n.Name_Kurs == cbKurs.Text).id_kurs;
                    skl.lstime = db.TimeSC.FirstOrDefault(n => n.text_time == cbTime.Text).id_time;
                    skl.DateZ = dtpZakaz.Value;
                    db.SaveChanges();
                }
                this.Close();

              


                Word.Application app = new Word.Application();
                Word.Document doc = app.Documents.Open(@Application.StartupPath + "\\SZ.doc");
                doc.SaveAs2("SZ");
                Word.Range range = doc.Range();

                doc.Bookmarks["client"].Range.Text = Program.f1.tbAccount.Text.ToString();
                doc.Bookmarks["ispolnitel"].Range.Text = cbPrepod.Text.ToString();
                doc.Bookmarks["namekurs"].Range.Text = cbKurs.Text.ToString();
                doc.Bookmarks["datenow"].Range.Text = DateTime.Now.Date.ToString("dd MMMM yyyy");
                
                //REVU: Шрифт
                object start = 0;
                object end = doc.Content.End;
                Word.Range range1 = doc.Range(ref start, ref end);
                range1.Font.Name = "Times New Roman";
                range1.Font.Size = 14;

                app.Visible = true;
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание!");
            }
        }

        private void FormAddZakaz_Load(object sender, EventArgs e)
        {
           
            var pred = db.Kurs.Select(n => n.Name_Kurs).ToList();
            cbKurs.DataSource = pred;
            cbKurs.Text = cPredmet;
        }
    }
}
