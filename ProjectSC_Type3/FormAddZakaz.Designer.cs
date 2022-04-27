
namespace ProjectSC_Type3
{
    partial class FormAddZakaz
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
            this.cbKurs = new MetroFramework.Controls.MetroComboBox();
            this.cbPrepod = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbTime = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.bSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dtpZakaz = new MetroFramework.Controls.MetroDateTime();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(36, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Курс";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(24, 99);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Преподаватель";
            // 
            // cbKurs
            // 
            this.cbKurs.FormattingEnabled = true;
            this.cbKurs.ItemHeight = 23;
            this.cbKurs.Location = new System.Drawing.Point(143, 63);
            this.cbKurs.Name = "cbKurs";
            this.cbKurs.Size = new System.Drawing.Size(241, 29);
            this.cbKurs.TabIndex = 2;
            this.cbKurs.UseSelectable = true;
            this.cbKurs.SelectedIndexChanged += new System.EventHandler(this.cbKurs_SelectedIndexChanged);
            this.cbKurs.SelectionChangeCommitted += new System.EventHandler(this.cbKurs_SelectionChangeCommitted);
            this.cbKurs.SelectedValueChanged += new System.EventHandler(this.cbKurs_SelectedValueChanged);
            // 
            // cbPrepod
            // 
            this.cbPrepod.FormattingEnabled = true;
            this.cbPrepod.ItemHeight = 23;
            this.cbPrepod.Location = new System.Drawing.Point(143, 99);
            this.cbPrepod.Name = "cbPrepod";
            this.cbPrepod.Size = new System.Drawing.Size(241, 29);
            this.cbPrepod.TabIndex = 3;
            this.cbPrepod.UseSelectable = true;
            this.cbPrepod.SelectedIndexChanged += new System.EventHandler(this.cbPrepod_SelectedIndexChanged);
            this.cbPrepod.SelectionChangeCommitted += new System.EventHandler(this.cbPrepod_SelectionChangeCommitted);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(24, 158);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Время";
            // 
            // cbTime
            // 
            this.cbTime.FormattingEnabled = true;
            this.cbTime.ItemHeight = 23;
            this.cbTime.Location = new System.Drawing.Point(143, 158);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(241, 29);
            this.cbTime.TabIndex = 6;
            this.cbTime.UseSelectable = true;
            this.cbTime.SelectedIndexChanged += new System.EventHandler(this.cbTime_SelectedIndexChanged);
            this.cbTime.SelectionChangeCommitted += new System.EventHandler(this.cbTime_SelectionChangeCommitted);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 207);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(73, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Стоимость";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(26, 324);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(358, 42);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Записаться";
            this.bSave.UseSelectable = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 265);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(82, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Дата заявки";
            // 
            // dtpZakaz
            // 
            this.dtpZakaz.Enabled = false;
            this.dtpZakaz.Location = new System.Drawing.Point(143, 265);
            this.dtpZakaz.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtpZakaz.Name = "dtpZakaz";
            this.dtpZakaz.Size = new System.Drawing.Size(241, 29);
            this.dtpZakaz.TabIndex = 10;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(143, 207);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(241, 20);
            this.tbPrice.TabIndex = 11;
            // 
            // FormAddZakaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 399);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.dtpZakaz);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cbPrepod);
            this.Controls.Add(this.cbKurs);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FormAddZakaz";
            this.Text = "FormAddZakaz";
            this.Activated += new System.EventHandler(this.FormAddZakaz_Activated);
            this.Load += new System.EventHandler(this.FormAddZakaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton bSave;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        public MetroFramework.Controls.MetroComboBox cbKurs;
        public MetroFramework.Controls.MetroComboBox cbPrepod;
        public MetroFramework.Controls.MetroComboBox cbTime;
        public MetroFramework.Controls.MetroDateTime dtpZakaz;
        public System.Windows.Forms.TextBox tbPrice;
    }
}