namespace projakts
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEnterProjekt = new System.Windows.Forms.Button();
            this.dgvShowProjekts = new System.Windows.Forms.DataGridView();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cmbLanguich = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleet = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProjekts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(600, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "שם הפרויקט";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "תאריך";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(205, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "שפת הפרויקט";
            // 
            // btnEnterProjekt
            // 
            this.btnEnterProjekt.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterProjekt.Location = new System.Drawing.Point(41, 49);
            this.btnEnterProjekt.Name = "btnEnterProjekt";
            this.btnEnterProjekt.Size = new System.Drawing.Size(130, 87);
            this.btnEnterProjekt.TabIndex = 3;
            this.btnEnterProjekt.Text = "הוספת הפרויקט";
            this.btnEnterProjekt.UseVisualStyleBackColor = true;
            this.btnEnterProjekt.Click += new System.EventHandler(this.btnEnterProjekt_Click);
            // 
            // dgvShowProjekts
            // 
            this.dgvShowProjekts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowProjekts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.time,
            this.languch,
            this.deleet});
            this.dgvShowProjekts.Location = new System.Drawing.Point(97, 222);
            this.dgvShowProjekts.Name = "dgvShowProjekts";
            this.dgvShowProjekts.RowHeadersWidth = 62;
            this.dgvShowProjekts.RowTemplate.Height = 28;
            this.dgvShowProjekts.Size = new System.Drawing.Size(657, 182);
            this.dgvShowProjekts.TabIndex = 4;
            this.dgvShowProjekts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowProjekts_CellClick);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(635, 110);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(119, 37);
            this.txtName.TabIndex = 5;
            // 
            // dtpTime
            // 
            this.dtpTime.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTime.Location = new System.Drawing.Point(338, 110);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(260, 37);
            this.dtpTime.TabIndex = 6;
            // 
            // cmbLanguich
            // 
            this.cmbLanguich.Font = new System.Drawing.Font("Malgun Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguich.FormattingEnabled = true;
            this.cmbLanguich.Items.AddRange(new object[] {
            "paython",
            "c#",
            "java script"});
            this.cmbLanguich.Location = new System.Drawing.Point(192, 109);
            this.cmbLanguich.Name = "cmbLanguich";
            this.cmbLanguich.Size = new System.Drawing.Size(124, 38);
            this.cmbLanguich.TabIndex = 7;
            // 
            // name
            // 
            this.name.HeaderText = "שם";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // time
            // 
            this.time.HeaderText = "תאריך הגשה";
            this.time.MinimumWidth = 8;
            this.time.Name = "time";
            this.time.Width = 150;
            // 
            // languch
            // 
            this.languch.HeaderText = "שפה";
            this.languch.MinimumWidth = 8;
            this.languch.Name = "languch";
            this.languch.Width = 150;
            // 
            // deleet
            // 
            this.deleet.HeaderText = "מחיקה";
            this.deleet.MinimumWidth = 8;
            this.deleet.Name = "deleet";
            this.deleet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleet.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbLanguich);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvShowProjekts);
            this.Controls.Add(this.btnEnterProjekt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProjekts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnterProjekt;
        private System.Windows.Forms.DataGridView dgvShowProjekts;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cmbLanguich;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn languch;
        private System.Windows.Forms.DataGridViewButtonColumn deleet;
    }
}

