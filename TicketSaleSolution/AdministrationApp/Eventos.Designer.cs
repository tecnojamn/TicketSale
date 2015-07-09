namespace AdministrationApp
{
    partial class frmEventos
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
            this.gvEventos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbEventLocation = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvEventos
            // 
            this.gvEventos.AllowUserToAddRows = false;
            this.gvEventos.AllowUserToDeleteRows = false;
            this.gvEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvEventos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.EventName,
            this.Type,
            this.Description,
            this.LocationName,
            this.Date});
            this.gvEventos.Location = new System.Drawing.Point(0, 15);
            this.gvEventos.Margin = new System.Windows.Forms.Padding(4);
            this.gvEventos.MultiSelect = false;
            this.gvEventos.Name = "gvEventos";
            this.gvEventos.Size = new System.Drawing.Size(859, 369);
            this.gvEventos.TabIndex = 1;
            this.gvEventos.AllowUserToDeleteRowsChanged += new System.EventHandler(this.gvEventos_AllowUserToDeleteRowsChanged);
            this.gvEventos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEventos_CellClick);
            this.gvEventos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvEventos_CellContentClick);
            this.gvEventos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvEventos_KeyDown);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // EventName
            // 
            this.EventName.HeaderText = "Name";
            this.EventName.Name = "EventName";
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // LocationName
            // 
            this.LocationName.HeaderText = "LocationName";
            this.LocationName.Name = "LocationName";
            this.LocationName.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(132, 259);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 46);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modify";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(988, 14);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 47);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Delete";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // cbHour
            // 
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(159, 223);
            this.cbHour.Margin = new System.Windows.Forms.Padding(4);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(55, 24);
            this.cbHour.TabIndex = 31;
            // 
            // cbMinutes
            // 
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Location = new System.Drawing.Point(223, 223);
            this.cbMinutes.Margin = new System.Windows.Forms.Padding(4);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(55, 24);
            this.cbMinutes.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Time";
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(223, 190);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(4);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(53, 24);
            this.cbMonth.TabIndex = 28;
            // 
            // cbDay
            // 
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(159, 190);
            this.cbDay.Margin = new System.Windows.Forms.Padding(4);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(55, 24);
            this.cbDay.TabIndex = 27;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(285, 190);
            this.cbYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(73, 24);
            this.cbYear.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "EventLocation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Name";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(159, 91);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(200, 22);
            this.txtDescripcion.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(159, 59);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 22);
            this.txtName.TabIndex = 19;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(159, 123);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(200, 24);
            this.cbType.TabIndex = 18;
            // 
            // cbEventLocation
            // 
            this.cbEventLocation.FormattingEnabled = true;
            this.cbEventLocation.Location = new System.Drawing.Point(159, 156);
            this.cbEventLocation.Margin = new System.Windows.Forms.Padding(4);
            this.cbEventLocation.Name = "cbEventLocation";
            this.cbEventLocation.Size = new System.Drawing.Size(200, 24);
            this.cbEventLocation.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cbHour);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.cbMinutes);
            this.groupBox1.Controls.Add(this.cbEventLocation);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.cbMonth);
            this.groupBox1.Controls.Add(this.txtDescripcion);
            this.groupBox1.Controls.Add(this.cbDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(867, 69);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(381, 313);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del evento";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(259, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 47);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 17);
            this.label7.TabIndex = 33;
            this.label7.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(159, 27);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(132, 22);
            this.txtId.TabIndex = 34;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(881, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 47);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 396);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvEventos);
            this.Controls.Add(this.btnBorrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEventos";
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.Eventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvEventos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvEventos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbEventLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;

    }
}