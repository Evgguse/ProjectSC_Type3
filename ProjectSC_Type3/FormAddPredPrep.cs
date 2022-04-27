using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSC_Type3
{
    public partial class FormAddPredPrep : MetroFramework.Forms.MetroForm
    {
        BDprojectsc db = new BDprojectsc();
        public int index;
        public string cPrepod;
        public string cPredmet;
 
        public FormAddPredPrep()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (cbPredmet.Text != "" && cbPrepod.Text != "")
            {
                if (this.Text == "Добавление")
                {
                    PredPrep zzk = new PredPrep
                    {
                        id_prepod = db.Prepod.FirstOrDefault(n => n.F_Name + " " + n.I_Name + " " + n.O_Name == cbPrepod.Text).id_prepod,
                        id_kurs = db.Kurs.FirstOrDefault(n => n.Name_Kurs == cbPredmet.Text).id_kurs

                    };

                    db.PredPrep.Add(zzk);
                    db.SaveChanges();
                }
                else
                {
                    PredPrep skl = db.PredPrep.FirstOrDefault(n => n.id_predprep == index);
                    skl.id_prepod = db.Prepod.FirstOrDefault(n => n.F_Name + " " + n.I_Name + " " + n.O_Name == cbPrepod.Text).id_prepod;
                    skl.id_kurs = db.Kurs.FirstOrDefault(n => n.Name_Kurs == cbPredmet.Text).id_kurs;
                    db.SaveChanges();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание!");
            }
        }

        private void FormAddPredPrep_Activated(object sender, EventArgs e)
        {
            var prepod = db.Prepod.Select(n => n.F_Name + " " + n.I_Name + " " + n.O_Name).ToList();
            cbPrepod.DataSource = prepod;
            cbPrepod.Text = cPrepod;
            var pred = db.Kurs.Select(n => n.Name_Kurs).ToList();
            cbPredmet.DataSource = pred;
            cbPredmet.Text = cPredmet;
        }
    }
}
