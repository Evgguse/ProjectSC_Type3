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
    public partial class FormAddPrepod : MetroFramework.Forms.MetroForm
    {
        BDprojectsc db = new BDprojectsc();
        public int index;
        public string ckp;
        public FormAddPrepod()
        {
            InitializeComponent();
        }

        private void metroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (tbFName.Text != "" && tbIName.Text != "" && tbOName.Text != "" && tbOName.Text != "" )
            {
                if (this.Text == "Добавление")
                {
                    Prepod skl = new Prepod
                    {
                        F_Name = tbFName.Text,
                        I_Name = tbIName.Text,
                        O_Name = tbOName.Text

                    };

                    db.Prepod.Add(skl);
                    db.SaveChanges();
                }
                else
                {
                    Prepod skl = db.Prepod.FirstOrDefault(n => n.id_prepod == index);
                    skl.F_Name = tbFName.Text;
                    skl.I_Name = tbIName.Text;
                    skl.O_Name = tbOName.Text;

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
