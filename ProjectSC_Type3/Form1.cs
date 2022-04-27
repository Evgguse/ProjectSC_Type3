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

    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        BDprojectsc db = new BDprojectsc();
        public string account;
        public Form1()
        {
            Program.f1 = this;
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {

            try 
            {
                
                    if (tbPassword.Text == db.Users.FirstOrDefault(n => n.Usermane == tbLogin.Text).Password)
                    {
                        if ("admin" == db.Users.FirstOrDefault(n => n.Usermane == tbLogin.Text).Role)
                        {
                            MainMenu ff = new MainMenu();
                            this.Hide();
                            account = db.Users.FirstOrDefault(n => n.Usermane == tbLogin.Text).UF_Name + " "
                                + db.Users.FirstOrDefault(n => n.Usermane == tbLogin.Text).UI_Name + " "
                                + db.Users.FirstOrDefault(n => n.Usermane == tbLogin.Text).UO_Name;
                            tbAccount.Text = account;
                        ff.bCourses.Visible = true;
                        ff.bPrepodCoursesAdm.Visible = true;
                        ff.bMyCoursesAdm.Visible = true;
                        ff.bUsers.Visible = true;
                        ff.bDiagramm.Visible = true;
                            ff.ShowDialog();
                        }
                        else
                        {
                        MainMenu ff = new MainMenu();
                        this.Hide();
                        account = db.Users.FirstOrDefault(n => n.Usermane == tbLogin.Text).UF_Name + " "
                            + db.Users.FirstOrDefault(n => n.Usermane == tbLogin.Text).UI_Name + " "
                            + db.Users.FirstOrDefault(n => n.Usermane == tbLogin.Text).UO_Name;
                        tbAccount.Text = account;
                        ff.bCourses.Visible = false;
                        ff.bPrepodCoursesAdm.Visible = false;
                        ff.bMyCoursesAdm.Visible = false;
                        ff.bUsers.Visible = false;
                        ff.bDiagramm.Visible = false;
                        ff.ShowDialog();
                    }
                    }
                    else 
                {
                    MessageBox.Show("Алярмо, вы ввели неверный логин или пароль");
                }
   
            }
            catch 
            {
                MessageBox.Show("Упс, что-то пошло не так :(");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var cbx = db.Users.Select(n => n.Usermane).ToList();
            tbLogin.DataSource = cbx;
            tbPassword.Clear();
            tbLogin.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
