namespace Calendar
{
    partial class AddOrEditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txb_gm = new System.Windows.Forms.TextBox();
            this.txb_tenps = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_nameapp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_datestart = new System.Windows.Forms.DateTimePicker();
            this.btn_ok = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_dateend = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.dtp_dateend);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btn_cancel);
            this.groupBox1.Controls.Add(this.txb_gm);
            this.groupBox1.Controls.Add(this.txb_tenps);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_nameapp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtp_datestart);
            this.groupBox1.Controls.Add(this.btn_ok);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(193, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(981, 643);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Appointment";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(592, 536);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(195, 67);
            this.btn_cancel.TabIndex = 16;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txb_gm
            // 
            this.txb_gm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_gm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_gm.Location = new System.Drawing.Point(392, 147);
            this.txb_gm.Multiline = true;
            this.txb_gm.Name = "txb_gm";
            this.txb_gm.Size = new System.Drawing.Size(395, 36);
            this.txb_gm.TabIndex = 1;
            // 
            // txb_tenps
            // 
            this.txb_tenps.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_tenps.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tenps.Location = new System.Drawing.Point(392, 61);
            this.txb_tenps.Multiline = true;
            this.txb_tenps.Name = "txb_tenps";
            this.txb_tenps.Size = new System.Drawing.Size(395, 36);
            this.txb_tenps.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(258, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 36);
            this.label6.TabIndex = 13;
            this.label6.Text = "Gmail:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(169, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 36);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tên của bạn:";
            // 
            // txb_nameapp
            // 
            this.txb_nameapp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txb_nameapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_nameapp.Location = new System.Drawing.Point(392, 240);
            this.txb_nameapp.Multiline = true;
            this.txb_nameapp.Name = "txb_nameapp";
            this.txb_nameapp.Size = new System.Drawing.Size(395, 36);
            this.txb_nameapp.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(152, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên cuộc họp:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "DateStart:";
            // 
            // dtp_datestart
            // 
            this.dtp_datestart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_datestart.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_datestart.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtp_datestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datestart.Location = new System.Drawing.Point(392, 342);
            this.dtp_datestart.Name = "dtp_datestart";
            this.dtp_datestart.Size = new System.Drawing.Size(395, 30);
            this.dtp_datestart.TabIndex = 3;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(217, 536);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(195, 67);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(219, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 36);
            this.label7.TabIndex = 17;
            this.label7.Text = "DateEnd:";
            // 
            // dtp_dateend
            // 
            this.dtp_dateend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_dateend.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dateend.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtp_dateend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_dateend.Location = new System.Drawing.Point(392, 433);
            this.dtp_dateend.Name = "dtp_dateend";
            this.dtp_dateend.Size = new System.Drawing.Size(395, 30);
            this.dtp_dateend.TabIndex = 4;
            // 
            // AddOrEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 791);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddOrEditForm";
            this.Text = "AddOrEditForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb_nameapp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_datestart;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txb_gm;
        private System.Windows.Forms.TextBox txb_tenps;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_dateend;
        private System.Windows.Forms.Label label7;
    }
}