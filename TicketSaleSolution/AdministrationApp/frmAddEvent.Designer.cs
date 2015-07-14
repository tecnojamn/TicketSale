namespace AdministrationApp
{
    partial class frmAddEvent
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.cbMinutes = new System.Windows.Forms.ComboBox();
            this.cbEventLocation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddTicketType = new System.Windows.Forms.Button();
            this.cbTicketType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteTicketType = new System.Windows.Forms.Button();
            this.gbImage = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.gbImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 1;
            // 
            // cbHour
            // 
            this.cbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(112, 144);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(42, 21);
            this.cbHour.TabIndex = 8;
            // 
            // cbMinutes
            // 
            this.cbMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMinutes.FormattingEnabled = true;
            this.cbMinutes.Location = new System.Drawing.Point(160, 144);
            this.cbMinutes.Name = "cbMinutes";
            this.cbMinutes.Size = new System.Drawing.Size(42, 21);
            this.cbMinutes.TabIndex = 9;
            // 
            // cbEventLocation
            // 
            this.cbEventLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEventLocation.FormattingEnabled = true;
            this.cbEventLocation.Location = new System.Drawing.Point(112, 89);
            this.cbEventLocation.Name = "cbEventLocation";
            this.cbEventLocation.Size = new System.Drawing.Size(151, 21);
            this.cbEventLocation.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Time";
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(112, 63);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(151, 21);
            this.cbType.TabIndex = 3;
            // 
            // cbMonth
            // 
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(160, 117);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(41, 21);
            this.cbMonth.TabIndex = 6;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(112, 37);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(151, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cbDay
            // 
            this.cbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(112, 117);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(42, 21);
            this.cbDay.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Name";
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(206, 117);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(56, 21);
            this.cbYear.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "EventLocation";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(106, 385);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 38);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 38);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddTicketType
            // 
            this.btnAddTicketType.Location = new System.Drawing.Point(134, 43);
            this.btnAddTicketType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddTicketType.Name = "btnAddTicketType";
            this.btnAddTicketType.Size = new System.Drawing.Size(56, 20);
            this.btnAddTicketType.TabIndex = 1;
            this.btnAddTicketType.Text = "Add";
            this.btnAddTicketType.UseVisualStyleBackColor = true;
            this.btnAddTicketType.Click += new System.EventHandler(this.btnAddTicketType_Click);
            // 
            // cbTicketType
            // 
            this.cbTicketType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTicketType.FormattingEnabled = true;
            this.cbTicketType.Location = new System.Drawing.Point(101, 18);
            this.cbTicketType.Name = "cbTicketType";
            this.cbTicketType.Size = new System.Drawing.Size(150, 21);
            this.cbTicketType.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteTicketType);
            this.groupBox1.Controls.Add(this.btnAddTicketType);
            this.groupBox1.Controls.Add(this.cbTicketType);
            this.groupBox1.Location = new System.Drawing.Point(10, 169);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(262, 72);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ticket types";
            // 
            // btnDeleteTicketType
            // 
            this.btnDeleteTicketType.Location = new System.Drawing.Point(196, 43);
            this.btnDeleteTicketType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteTicketType.Name = "btnDeleteTicketType";
            this.btnDeleteTicketType.Size = new System.Drawing.Size(56, 20);
            this.btnDeleteTicketType.TabIndex = 12;
            this.btnDeleteTicketType.Text = "Delete";
            this.btnDeleteTicketType.UseVisualStyleBackColor = true;
            this.btnDeleteTicketType.Click += new System.EventHandler(this.btnDeleteTicketType_Click);
            // 
            // gbImage
            // 
            this.gbImage.Controls.Add(this.btnBrowse);
            this.gbImage.Controls.Add(this.pbImage);
            this.gbImage.Location = new System.Drawing.Point(10, 245);
            this.gbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbImage.Name = "gbImage";
            this.gbImage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbImage.Size = new System.Drawing.Size(262, 120);
            this.gbImage.TabIndex = 57;
            this.gbImage.TabStop = false;
            this.gbImage.Text = "Image";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(4, 17);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(56, 19);
            this.btnBrowse.TabIndex = 13;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(167, 17);
            this.pbImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(83, 90);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // frmAddEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(283, 430);
            this.Controls.Add(this.gbImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cbHour);
            this.Controls.Add(this.cbMinutes);
            this.Controls.Add(this.cbEventLocation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.cbDay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddEvent";
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.frmAddEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.gbImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.ComboBox cbMinutes;
        private System.Windows.Forms.ComboBox cbEventLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddTicketType;
        private System.Windows.Forms.ComboBox cbTicketType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteTicketType;
        private System.Windows.Forms.GroupBox gbImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pbImage;

    }
}