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
    public partial class FormAddCourse : MetroFramework.Forms.MetroForm
    {
        BDprojectsc db = new BDprojectsc();
        public int index;
        public FormAddCourse()
        {
            InitializeComponent();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tbNameKurs.Text != "" && tbPrice.Text != "")
            {
                if (this.Text == "Добавление")
                {
                    Kurs skl = new Kurs
                    {
                        Name_Kurs = tbNameKurs.Text,
                        Price = Convert.ToDecimal(tbPrice.Text)

                    };

                    db.Kurs.Add(skl);
                    db.SaveChanges();
                }
                else
                {
                    Kurs skl = db.Kurs.FirstOrDefault(n => n.id_kurs == index);
                    skl.Name_Kurs = tbNameKurs.Text;
                    skl.Price = Convert.ToDecimal(tbPrice.Text);

                    db.SaveChanges();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Внимание!");
            }
        }
    }
}
