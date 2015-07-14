namespace AdministrationApp
{
    partial class frmEventReport
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
            this.txtIdEvento = new System.Windows.Forms.TextBox();
            this.btnBestEvent = new System.Windows.Forms.Button();
            this.btnWorstEvent = new System.Windows.Forms.Button();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtEventLoc = new System.Windows.Forms.TextBox();
            this.txt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIdEvento
            // 
            this.txtIdEvento.Location = new System.Drawing.Point(21, 40);
            this.txtIdEvento.Name = "txtIdEvento";
            this.txtIdEvento.ReadOnly = true;
            this.txtIdEvento.Size = new System.Drawing.Size(161, 20);
            this.txtIdEvento.TabIndex = 0;
            // 
            // btnBestEvent
            // 
            this.btnBestEvent.Location = new System.Drawing.Point(33, 12);
            this.btnBestEvent.Name = "btnBestEvent";
            this.btnBestEvent.Size = new System.Drawing.Size(75, 40);
            this.btnBestEvent.TabIndex = 1;
            this.btnBestEvent.Text = "Best Event";
            this.btnBestEvent.UseVisualStyleBackColor = true;
            this.btnBestEvent.Click += new System.EventHandler(this.btnBestEvent_Click);
            // 
            // btnWorstEvent
            // 
            this.btnWorstEvent.Location = new System.Drawing.Point(114, 12);
            this.btnWorstEvent.Name = "btnWorstEvent";
            this.btnWorstEvent.Size = new System.Drawing.Size(80, 40);
            this.btnWorstEvent.TabIndex = 2;
            this.btnWorstEvent.Text = "Worst Event";
            this.btnWorstEvent.UseVisualStyleBackColor = true;
            this.btnWorstEvent.Click += new System.EventHandler(this.btnWorstEvent_Click);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(21, 196);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(161, 20);
            this.txtDate.TabIndex = 3;
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(21, 157);
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(161, 20);
            this.txtType.TabIndex = 4;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(21, 79);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.ReadOnly = true;
            this.txtEventName.Size = new System.Drawing.Size(161, 20);
            this.txtEventName.TabIndex = 5;
            // 
            // txtEventLoc
            // 
            this.txtEventLoc.Location = new System.Drawing.Point(21, 118);
            this.txtEventLoc.Name = "txtEventLoc";
            this.txtEventLoc.ReadOnly = true;
            this.txtEventLoc.Size = new System.Drawing.Size(161, 20);
            this.txtEventLoc.TabIndex = 6;
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Location = new System.Drawing.Point(21, 141);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(31, 13);
            this.txt.TabIndex = 7;
            this.txt.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Event Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Event Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEventName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIdEvento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEventLoc);
            this.groupBox1.Controls.Add(this.txt);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 244);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información del evento";
            // 
            // frmEventReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(226, 317);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnWorstEvent);
            this.Controls.Add(this.btnBestEvent);
            this.Name = "frmEventReport";
            this.Text = "Event Reports";
            this.Load += new System.EventHandler(this.BestEvent_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIdEvento;
        private System.Windows.Forms.Button btnBestEvent;
        private System.Windows.Forms.Button btnWorstEvent;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtEventLoc;
        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}