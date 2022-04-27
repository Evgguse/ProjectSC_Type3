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
    public partial class FormDiagramm : MetroFramework.Forms.MetroForm
    {
        BDprojectsc db = new BDprojectsc();
        public FormDiagramm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var date1 = dtpOne.Value.Date;
            var date2 = dtpTwo.Value.Date;
            chart1.Series[0].Points.Clear();
            var fir = db.Prepod.Where
            (n => n.Zakaz.FirstOrDefault
            (m => m.DateZ > date1 && m.DateZ < date2) != null)
            .Select(n => new
            {
                Name = n.F_Name + " " + n.I_Name + " " + n.O_Name,
                Price = db.Zakaz.Where(m => m.id_prepod == n.id_prepod && m.DateZ > date1 && m.DateZ < date2).Sum(m => m.Kurs.Price)
            }).ToList();

            for (int i = 0; i < fir.Count(); i++)
            {
              
                    chart1.Series[0].Points.AddXY(fir[i].Name, fir[i].Price);
              
            }
            chart1.ChartAreas[0].AxisX.Title = "Преподаватель";
            chart1.ChartAreas[0].AxisY.Title = "Заработано";

            dgView.DataSource = fir;
            dgView.Columns[0].HeaderText = "Преподаватель";
            dgView.Columns[1].HeaderText = "Заработано";
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            {
                chart1.Series[0].Points.Clear();
                var jjk = db.Prepod.Where
                (n => n.Zakaz.FirstOrDefault
                (m => m.DateZ.Year.ToString() == cbYear.Text) != null)
                .Select(n => new
                {
                    Name = n.F_Name + " " + n.I_Name + " " + n.O_Name,

                    Price = db.Zakaz.Where(m => m.id_prepod == n.id_prepod && (m.DateZ.Year).ToString() == cbYear.Text).Sum(m => m.Kurs.Price)
                }).ToList();

                for (int i = 0; i < jjk.Count(); i++)
                {
       
                  
                        chart1.Series[0].Points.AddXY(jjk[i].Name, jjk[i].Price);
                    
                }
                chart1.ChartAreas[0].AxisX.Title = "Преподаватель";
                chart1.ChartAreas[0].AxisY.Title = "Заработано";

                dgView.DataSource = jjk;
                dgView.Columns[0].HeaderText = "Преподаватель";
                dgView.Columns[1].HeaderText = "Заработано";
            }
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex == 0)
            {
                saveKartinka.ShowDialog();
            }
            else
            {
                saveWord.ShowDialog();
            }
        }

        private void rbOne_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
        }

        private void rbTwo_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }
        private void saveWord_FileOk(object sender, CancelEventArgs e)
        {
            Word.Document oDoc = new Word.Document();
            oDoc.Application.Visible = true;

            object start = 0;
            object end = 0;
            Word.Range tableLocation = oDoc.Range(ref start, ref end);
            oDoc.Tables.Add(tableLocation, dgView.RowCount + 1, dgView.ColumnCount);

            oDoc.Tables[1].Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            oDoc.Tables[1].Borders.InsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;

            for (int j = 1; j <= dgView.ColumnCount; j++)
            {
                oDoc.Tables[1].Cell(1, j).Range.Text = dgView.Columns[j - 1].HeaderCell.Value.ToString();
                oDoc.Tables[1].Cell(1, j).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                oDoc.Tables[1].Cell(1, j).Range.Bold = 5;
            }

            for (int i = 1; i <= dgView.RowCount; i++)
            {
                for (int j = 0; j < dgView.ColumnCount; j++)
                {
                    oDoc.Tables[1].Cell(i + 1, j + 1).Range.Text = dgView[j, i - 1].Value.ToString();
                }
            }
            oDoc.SaveAs2(saveWord.FileName);
        }

        private void saveKartinka_FileOk(object sender, CancelEventArgs e)
        {
            chart1.SaveImage(saveKartinka.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp);
            switch (saveKartinka.FilterIndex)
            {
                case 1: chart1.SaveImage(saveKartinka.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Bmp); break;
                case 2: chart1.SaveImage(saveKartinka.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); break;
                case 3: chart1.SaveImage(saveKartinka.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg); break;
            }
        }
    }
}

