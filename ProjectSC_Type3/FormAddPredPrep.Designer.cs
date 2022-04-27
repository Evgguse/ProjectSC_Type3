
namespace ProjectSC_Type3
{
    partial class FormAddPredPrep
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
            this.cbPrepod = new MetroFramework.Controls.MetroComboBox();
            this.cbPredmet = new MetroFramework.Controls.MetroComboBox();
            this.bSave = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // cbPrepod
            // 
            this.cbPrepod.FormattingEnabled = true;
            this.cbPrepod.ItemHeight = 23;
            this.cbPrepod.Location = new System.Drawing.Point(172, 63);
            this.cbPrepod.Name = "cbPrepod";
            this.cbPrepod.Size = new System.Drawing.Size(270, 29);
            this.cbPrepod.TabIndex = 0;
            this.cbPrepod.UseSelectable = true;
            // 
            // cbPredmet
            // 
            this.cbPredmet.FormattingEnabled = true;
            this.cbPredmet.ItemHeight = 23;
            this.cbPredmet.Location = new System.Drawing.Point(172, 98);
            this.cbPredmet.Name = "cbPredmet";
            this.cbPredmet.Size = new System.Drawing.Size(270, 29);
            this.cbPredmet.TabIndex = 1;
            this.cbPredmet.UseSelectable = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(46, 146);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(396, 29);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Сохранить";
            this.bSave.UseSelectable = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(46, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Преподаватель";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(46, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(61, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Предмет";
            // 
            // FormAddPredPrep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 188);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbPredmet);
            this.Controls.Add(this.cbPrepod);
            this.Name = "FormAddPredPrep";
            this.Text = "FormAddPredPrep";
            this.Activated += new System.EventHandler(this.FormAddPredPrep_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton bSave;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroComboBox cbPrepod;
        public MetroFramework.Controls.MetroComboBox cbPredmet;
    }
}