using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace ProjectSC_Type3
{
    public partial class MainMenu : MetroFramework.Forms.MetroForm
    {
        BDprojectsc db = new BDprojectsc();
        public string table;
        public string acc;
        public int iduser;
        public MainMenu()
        {
            InitializeComponent();
        }



        private void MainMenu_Load(object sender, EventArgs e)
        {
            accName.Text = Program.f1.tbAccount.Text;
            acc = Program.f1.tbAccount.Text;
            if ("admin" == db.Users.FirstOrDefault(n => n.Usermane == Program.f1.tbLogin.Text).Role)
            {

            }
            else
            {
                if (table == "zakazuser")
                {
                    metroTile1.Visible = true;
                    metroTile2.Visible = true;
                    metroTile3.Visible = true;

                }
                else
                {
                    metroTile1.Visible = false;
                    metroTile2.Visible = false;
                    metroTile3.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bUsers_Click(object sender, EventArgs e)
        {
            table = "users";
            var marka = db.Users.Select(n => new { n.id_user, n.Usermane,n.Password,n.UF_Name,n.UI_Name,n.UO_Name,n.Role }).ToList();
            dtgOne.DataSource = marka;
            dtgOne.Columns[0].HeaderText = "ID";
            dtgOne.Columns[1].HeaderText = "Логин";
            dtgOne.Columns[2].HeaderText = "Пароль";
            dtgOne.Columns[3].HeaderText = "Фамилия";
            dtgOne.Columns[4].HeaderText = "Имя";
            dtgOne.Columns[5].HeaderText = "Отчество";
            dtgOne.Columns[6].HeaderText = "Роль";
        }

        private void bCourses_Click(object sender, EventArgs e)
        {
            table = "courses";
            var marka = db.Kurs.Select(n => new { n.id_kurs, n.Name_Kurs, n.Price }).ToList();
            dtgOne.DataSource = marka;
            dtgOne.Columns[0].HeaderText = "ID";
            dtgOne.Columns[1].HeaderText = "Логин";
            dtgOne.Columns[2].HeaderText = "Цена";

        }

        private void bPrepod_Click(object sender, EventArgs e)
        {
            table = "prepod";


            if ("admin" == db.Users.FirstOrDefault(n => n.Usermane == Program.f1.tbLogin.Text).Role)
            {

            }
            else
            {
               
               
                    metroTile1.Visible = false;
                    metroTile2.Visible = false;
                    metroTile3.Visible = false;
                
            }

            var marka = db.PredPrep.Select(n => new { n.id_prepod, n.Prepod.F_Name, n.Prepod.I_Name, n.Prepod.O_Name,n.Kurs.Name_Kurs }).ToList();
            dtgOne.DataSource = marka;
            dtgOne.Columns[0].HeaderText = "ID";
            dtgOne.Columns[1].HeaderText = "Фамилия";
            dtgOne.Columns[2].HeaderText = "Имя";
            dtgOne.Columns[3].HeaderText = "Отчество";
            dtgOne.Columns[4].HeaderText = "Курс";
        }

        private void bMyCoursesAdm_Click(object sender, EventArgs e)
        {
            table = "zakaz";
            var marka = db.Zakaz.Select(n => new { n.id_zakaz, n.Prepod.F_Name, n.Prepod.I_Name, n.Prepod.O_Name, n.Kurs.Name_Kurs, n.Users.UF_Name,n.Users.UI_Name,n.Users.UO_Name, n.TimeSC.text_time,n.DateZ }).ToList();
            dtgOne.DataSource = marka;
            dtgOne.Columns[0].HeaderText = "ID";
            dtgOne.Columns[1].HeaderText = "Фамилия";
            dtgOne.Columns[2].HeaderText = "Имя";
            dtgOne.Columns[3].HeaderText = "Отчество";
            dtgOne.Columns[4].HeaderText = "Курс";
            dtgOne.Columns[5].HeaderText = "Фамилия";
            dtgOne.Columns[6].HeaderText = "Имя";
            dtgOne.Columns[7].HeaderText = "Отчество";
            dtgOne.Columns[8].HeaderText = "Время занятия";
            dtgOne.Columns[9].HeaderText = "Дата заяявки";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            if (table == "prepod")
            {
                FormAddPrepod f = new FormAddPrepod();
                f.Text = "Добавление";
                f.ShowDialog();

            }
            if (table == "predprep")
            {
                FormAddPredPrep f = new FormAddPredPrep();
                f.Text = "Добавление";
                f.ShowDialog();

            }
            if (table == "zakaz")
            {
                FormAddZakaz f = new FormAddZakaz();
                f.Text = "Добавление";
                f.ShowDialog();

            }
            if (table == "zakazuser")
            {
                FormAddZakaz f = new FormAddZakaz();
                f.Text = "Добавление";
                f.ShowDialog();

            }
            if (table == "courses")
            {
                FormAddCourse f = new FormAddCourse();
                f.Text = "Добавление";
                f.ShowDialog();

            }
           
        }

        private void bPrepodCoursesAdm_Click(object sender, EventArgs e)
        {
            table = "predprep";
            var marka = db.PredPrep.Select(n => new { n.id_prepod, n.Prepod.F_Name, n.Prepod.I_Name, n.Prepod.O_Name, n.Kurs.Name_Kurs }).ToList();
            dtgOne.DataSource = marka;
            dtgOne.Columns[0].HeaderText = "ID";
            dtgOne.Columns[1].HeaderText = "Фамилия";
            dtgOne.Columns[2].HeaderText = "Имя";
            dtgOne.Columns[3].HeaderText = "Отчество";
            dtgOne.Columns[4].HeaderText = "Курс";
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            BDprojectsc db = new BDprojectsc();

            try
            {
                if (table == "courses")
                {
                    FormAddCourse f = new FormAddCourse();
                    f.Text = "Редактирование";
                    f.index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                    var kurs = db.Kurs.FirstOrDefault(n => n.id_kurs == f.index);

                    f.tbNameKurs.Text = kurs.Name_Kurs;
                    f.tbPrice.Text = Convert.ToString(kurs.Price);
                    f.ShowDialog();
                }
                if (table == "prepod")
                {
                    FormAddPrepod f = new FormAddPrepod();
                    f.Text = "Редактирование";
                    f.index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                    var prepod = db.Prepod.FirstOrDefault(n => n.id_prepod == f.index);

                    f.tbFName.Text = prepod.F_Name;
                    f.tbIName.Text = prepod.I_Name;
                    f.tbOName.Text = prepod.O_Name;

                    //f.cModel = db.Modelis.FirstOrDefault(n => n.Marka == model.Marki.ID_Marka).Marki.Name;
                    f.ShowDialog();

                }
                if (table == "predprep")
                {
                    FormAddPredPrep f = new FormAddPredPrep();
                    f.Text = "Редактирование";
                    f.index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                    var predprep = db.PredPrep.FirstOrDefault(n => n.id_predprep == f.index);
                    var prepod = db.Prepod.FirstOrDefault(n => n.id_prepod == predprep.id_prepod);

                    f.cPredmet = db.Kurs.FirstOrDefault(n => n.id_kurs == predprep.id_kurs).Name_Kurs;
                    f.cPrepod = prepod.F_Name + " " + prepod.I_Name + " " + prepod.O_Name;
                    //f.cModel = db.Modelis.FirstOrDefault(n => n.Marka == model.Marki.ID_Marka).Marki.Name;
                    f.ShowDialog();

                }
                if (table == "zakaz")
                {
                    FormAddZakaz f = new FormAddZakaz();
                    f.Text = "Редактирование";
                    f.index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                    var zakaz = db.Zakaz.FirstOrDefault(n => n.id_zakaz == f.index);
                    var prepod = db.Prepod.FirstOrDefault(n => n.id_prepod == zakaz.id_prepod);
                    f.cPredmet = db.Kurs.FirstOrDefault(n => n.id_kurs == zakaz.id_kurs).Name_Kurs;
                    //f.cPrepod = prepod.F_Name + " " + prepod.I_Name + " " + prepod.O_Name;
                    f.cbPrepod.Text = db.Prepod.FirstOrDefault(n => n.id_prepod == zakaz.id_prepod).F_Name
                        + " " + 
                        db.Prepod.FirstOrDefault(n => n.id_prepod == zakaz.id_prepod).I_Name 
                        + " " +
                        db.Prepod.FirstOrDefault(n => n.id_prepod == zakaz.id_prepod).O_Name;
                    f.cTime = db.TimeSC.FirstOrDefault(n => n.id_time == zakaz.lstime).text_time;
                    f.tbPrice.Text = Convert.ToString(db.Kurs.FirstOrDefault(n => n.id_kurs == zakaz.id_kurs).Price);
                    f.dtpZakaz.Value = zakaz.DateZ;
                    f.ShowDialog();

                }
                if (table == "zakazuser")
                {
                    FormAddZakaz f = new FormAddZakaz();
                    f.Text = "Редактирование";
                    f.index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                    var zakaz = db.Zakaz.FirstOrDefault(n => n.id_zakaz == f.index);
                    var prepod = db.Prepod.FirstOrDefault(n => n.id_prepod == zakaz.id_prepod);
                    f.cPredmet = db.Kurs.FirstOrDefault(n => n.id_kurs == zakaz.id_kurs).Name_Kurs;
                    //f.cPrepod = prepod.F_Name + " " + prepod.I_Name + " " + prepod.O_Name;
                    f.cbPrepod.Text = db.Prepod.FirstOrDefault(n => n.id_prepod == zakaz.id_prepod).F_Name
                        + " " +
                        db.Prepod.FirstOrDefault(n => n.id_prepod == zakaz.id_prepod).I_Name
                        + " " +
                        db.Prepod.FirstOrDefault(n => n.id_prepod == zakaz.id_prepod).O_Name;
                    f.cTime = db.TimeSC.FirstOrDefault(n => n.id_time == zakaz.lstime).text_time;
                    f.tbPrice.Text = Convert.ToString(db.Kurs.FirstOrDefault(n => n.id_kurs == zakaz.id_kurs).Price);
                    f.dtpZakaz.Value = zakaz.DateZ;
                    f.ShowDialog();

                }

            }
            catch { MessageBox.Show("Выберите поле"); }
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            if (table == "courses")
            {
                int index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                if (MessageBox.Show("Вы уверены, что хотите удалить запись из таблицы и все связанные с ней записи из таблиц ? ", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var zakaz = db.Zakaz.Where(n => n.id_kurs == index);
                    var avto = db.PredPrep.Where(n => n.id_kurs == index);
                    var model = db.Kurs.FirstOrDefault(n => n.id_kurs == index);

                    if (db.Zakaz.FirstOrDefault(n => n.id_kurs == index) != null)
                    {
                        for (int i = 0; i <= zakaz.Count(); i++)
                        {
                            db.Zakaz.Remove(db.Zakaz.FirstOrDefault(n => n.id_kurs == index));
                            db.SaveChanges();
                        }
                        if (db.PredPrep.FirstOrDefault(n => n.id_kurs == index) != null)
                        {
                            for (int i = 0; i <= avto.Count(); i++)
                            {
                                db.PredPrep.Remove(db.PredPrep.FirstOrDefault(n => n.id_kurs == index));
                                db.SaveChanges();
                            }

                        }
                    }
                    db.Kurs.Remove(model);
                    db.SaveChanges();
                    bCourses_Click(sender, e);
                }
            }
            if (table == "prepod")
            {
                int index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                if (MessageBox.Show("Вы уверены, что хотите удалить запись из таблицы и все связанные с ней записи из таблиц ? ", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var zakaz = db.Zakaz.Where(n => n.id_prepod == index);
                    var avto = db.PredPrep.Where(n => n.id_prepod == index);
                    var model = db.Prepod.FirstOrDefault(n => n.id_prepod == index);

                    if (db.Zakaz.FirstOrDefault(n => n.id_prepod == index) != null)
                    {
                        for (int i = 0; i <= zakaz.Count(); i++)
                        {
                            db.Zakaz.Remove(db.Zakaz.FirstOrDefault(n => n.id_prepod == index));
                            db.SaveChanges();
                        }
                        if (db.PredPrep.FirstOrDefault(n => n.id_prepod == index) != null)
                        {
                            for (int i = 0; i <= avto.Count(); i++)
                            {
                                db.PredPrep.Remove(db.PredPrep.FirstOrDefault(n => n.id_prepod == index));
                                db.SaveChanges();
                            }

                        }
                    }
                    db.Prepod.Remove(model);
                    db.SaveChanges();
                    bPrepod_Click(sender, e);
                }
            }
            if (table == "predprep")
            {
                int index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                if (MessageBox.Show("Вы уверены, что хотите удалить запись из таблицы и все связанные с ней записи из таблиц ? ", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var zakaz = db.Zakaz.Where(n => n.id_prepod == index);
                    var avto = db.PredPrep.FirstOrDefault(n => n.id_prepod == index);
                    

                    if (db.Zakaz.FirstOrDefault(n => n.id_prepod == index) != null)
                    {
                        for (int i = 0; i <= zakaz.Count(); i++)
                        {
                            db.Zakaz.Remove(db.Zakaz.FirstOrDefault(n => n.id_prepod == index));
                            db.SaveChanges();
                        }
                      
                    }
                    db.PredPrep.Remove(avto);
                    db.SaveChanges();
                    bPrepod_Click(sender, e);
                }
            }
            if (table == "zakaz")
            {
                int index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                var zakaz = db.Zakaz.FirstOrDefault(n => n.id_zakaz == index);

                db.Zakaz.Remove(zakaz);
                db.SaveChanges();
                bMyCoursesAdm_Click(sender, e);
            }
            if (table == "zakazuser")
            {
                int index = Convert.ToInt32(dtgOne[0, dtgOne.CurrentRow.Index].Value);
                var zakaz = db.Zakaz.FirstOrDefault(n => n.id_zakaz == index);

                db.Zakaz.Remove(zakaz);
                db.SaveChanges();
                bMyCoursesAdm_Click(sender, e);
            }
        }

        private void bDiagrammOne_Click(object sender, EventArgs e)
        {
            FormDiagramm f = new FormDiagramm();
            f.Text = "Диаграмма";
            f.ShowDialog();
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            if (table == "courses")
            {
                bCourses_Click(sender, e);

            }
            if (table == "prepod")
            {
                bPrepod_Click(sender, e);

            }
            if (table == "predprep")
            {
                bPrepodCoursesAdm_Click(sender, e);

            }
            if (table == "zakaz")
            {
                bMyCoursesAdm_Click(sender, e);

            }
            if (table == "zakazuser")
            {
                bMyKurs_Click(sender, e);

            }
            if ("admin" == db.Users.FirstOrDefault(n => n.Usermane == Program.f1.tbLogin.Text).Role)
            {
                
            }
            else
            {
                if (table == "zakazuser")

                {
                    metroTile1.Visible = true;
                    metroTile2.Visible = true;
                    metroTile3.Visible = true;

                }
                else
                {
                    metroTile1.Visible = false;
                    metroTile2.Visible = false;
                    metroTile3.Visible = false;
                }
            }
        }

        private void bDiagrammTwo_Click(object sender, EventArgs e)
        {
            FormDiagramm2 f = new FormDiagramm2();
            f.Text = "Диаграмма";
            f.ShowDialog();
        }

        private void bMyKurs_Click(object sender, EventArgs e)
        {
            table = "zakazuser";
            metroTile1.Visible = true;
            metroTile2.Visible = true;
            metroTile3.Visible = true;
            iduser = db.Users.FirstOrDefault(n => n.UF_Name + " " + n.UI_Name + " " + n.UO_Name == Program.f1.tbAccount.Text).id_user;

            var keks = db.Zakaz.SqlQuery("select * from Zakaz where id_user=" + iduser + "")
    .Select(n => new 
    { n.id_zakaz, n.Prepod.F_Name, n.Prepod.I_Name, n.Prepod.O_Name, n.Kurs.Name_Kurs, n.Users.UF_Name,
        n.Users.UI_Name, n.Users.UO_Name, n.TimeSC.text_time, n.DateZ })
    .ToList();

            dtgOne.DataSource = keks;
            dtgOne.Columns[0].Visible = false;
            dtgOne.Columns[1].HeaderText = "Фамилия";
            dtgOne.Columns[2].HeaderText = "Имя";
            dtgOne.Columns[3].HeaderText = "Отчество";
            dtgOne.Columns[4].HeaderText = "Курс";
            dtgOne.Columns[5].HeaderText = "Фамилия";
            dtgOne.Columns[6].HeaderText = "Имя";
            dtgOne.Columns[7].HeaderText = "Отчество";
            dtgOne.Columns[8].HeaderText = "Время занятия";
            dtgOne.Columns[9].HeaderText = "Дата заяявки";

        }

        private void bWord_Click(object sender, EventArgs e)
        {
            saveWord.ShowDialog();

        }

        private void bExcel_Click(object sender, EventArgs e)
        {
            saveExcel.ShowDialog();

        }
        private void saveWord_FileOk(object sender, CancelEventArgs e)
        {
            Word.Document oDoc = new Word.Document();
            oDoc.Application.Visible = true;

            object start = 0;
            object end = 0;
            Word.Range tableLocation = oDoc.Range(ref start, ref end);
            oDoc.Tables.Add(tableLocation, dtgOne.RowCount + 1, dtgOne.ColumnCount - 1);

            oDoc.Tables[1].Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            oDoc.Tables[1].Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            for (int j = 0; j < dtgOne.ColumnCount; j++)
            {
                oDoc.Tables[1].Cell(1, j).Range.Text = dtgOne.Columns[j].HeaderCell.Value.ToString();
                oDoc.Tables[1].Cell(1, j).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oDoc.Tables[1].Cell(1, j).Range.Bold = 5;
            }

            for (int i = 1; i <= dtgOne.RowCount; i++)
            {
                for (int j = 0; j < dtgOne.ColumnCount; j++)
                {
                    oDoc.Tables[1].Cell(i + 1, j).Range.Text = dtgOne[j, i - 1].Value.ToString();
                }
            }
            oDoc.SaveAs2(saveWord.FileName);
        }

        private void saveExcel_FileOk(object sender, CancelEventArgs e)
        {
            Excel.Application Tule = new Excel.Application();
            Tule.Visible = true;
            Tule.Workbooks.Add();
            Excel.Worksheet workSheet = (Excel.Worksheet)Tule.ActiveSheet;
            for (int j = 1; j < dtgOne.ColumnCount; j++)
            {
                workSheet.Cells[1, j] = dtgOne.Columns[j].HeaderCell.Value.ToString();
            }
            for (int i = 1; i < dtgOne.RowCount; i++)
            {
                for (int j = 1; j < dtgOne.ColumnCount; j++)
                {
                    workSheet.Cells[i + 1, j] = dtgOne[j, i - 1].Value.ToString();
                }
            }
            workSheet.SaveAs(saveExcel.FileName);
        }
    }
}
