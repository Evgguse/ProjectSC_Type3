
namespace ProjectSC_Type3
{
    partial class FormAddCourse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbNameKurs = new MetroFramework.Controls.MetroTextBox();
            this.tbPrice = new MetroFramework.Controls.MetroTextBox();
            this.bSave = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 87);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Наименование";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 136);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Стоимость";
            // 
            // tbNameKurs
            // 
            // 
            // 
            // 
            this.tbNameKurs.CustomButton.Image = null;
            this.tbNameKurs.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.tbNameKurs.CustomButton.Name = "";
            this.tbNameKurs.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNameKurs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNameKurs.CustomButton.TabIndex = 1;
            this.tbNameKurs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNameKurs.CustomButton.UseSelectable = true;
            this.tbNameKurs.CustomButton.Visible = false;
            this.tbNameKurs.Lines = new string[0];
            this.tbNameKurs.Location = new System.Drawing.Point(160, 87);
            this.tbNameKurs.MaxLength = 32767;
            this.tbNameKurs.Name = "tbNameKurs";
            this.tbNameKurs.PasswordChar = '\0';
            this.tbNameKurs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNameKurs.SelectedText = "";
            this.tbNameKurs.SelectionLength = 0;
            this.tbNameKurs.SelectionStart = 0;
            this.tbNameKurs.ShortcutsEnabled = true;
            this.tbNameKurs.Size = new System.Drawing.Size(186, 23);
            this.tbNameKurs.TabIndex = 2;
            this.tbNameKurs.UseSelectable = true;
            this.tbNameKurs.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNameKurs.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPrice
            // 
            // 
            // 
            // 
            this.tbPrice.CustomButton.Image = null;
            this.tbPrice.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.tbPrice.CustomButton.Name = "";
            this.tbPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPrice.CustomButton.TabIndex = 1;
            this.tbPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPrice.CustomButton.UseSelectable = true;
            this.tbPrice.CustomButton.Visible = false;
            this.tbPrice.Lines = new string[0];
            this.tbPrice.Location = new System.Drawing.Point(160, 136);
            this.tbPrice.MaxLength = 32767;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPrice.SelectedText = "";
            this.tbPrice.SelectionLength = 0;
            this.tbPrice.SelectionStart = 0;
            this.tbPrice.ShortcutsEnabled = true;
            this.tbPrice.Size = new System.Drawing.Size(186, 23);
            this.tbPrice.TabIndex = 3;
            this.tbPrice.UseSelectable = true;
            this.tbPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(35, 176);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(311, 23);
            this.bSave.TabIndex = 4;
            this.bSave.Text = "Сохранить";
            this.bSave.UseSelectable = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // FormAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 234);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.tbNameKurs);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormAddCourse";
            this.Text = "FormAddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton bSave;
        public MetroFramework.Controls.MetroTextBox tbNameKurs;
        public MetroFramework.Controls.MetroTextBox tbPrice;
    }
}