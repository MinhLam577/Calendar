namespace Calendar
{
    partial class MainForm
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
            this.dgv_app = new System.Windows.Forms.DataGridView();
            this.btn_addapp = new System.Windows.Forms.Button();
            this.btn_addrmd = new System.Windows.Forms.Button();
            this.btn_join = new System.Windows.Forms.Button();
            this.dgv_user = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_app)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_app
            // 
            this.dgv_app.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_app.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_app.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_app.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_app.Location = new System.Drawing.Point(2, 61);
            this.dgv_app.Name = "dgv_app";
            this.dgv_app.ReadOnly = true;
            this.dgv_app.RowHeadersWidth = 51;
            this.dgv_app.RowTemplate.Height = 24;
            this.dgv_app.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_app.Size = new System.Drawing.Size(1025, 431);
            this.dgv_app.TabIndex = 0;
            this.dgv_app.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_app_CellClick);
            // 
            // btn_addapp
            // 
            this.btn_addapp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addapp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addapp.Location = new System.Drawing.Point(12, 513);
            this.btn_addapp.Name = "btn_addapp";
            this.btn_addapp.Size = new System.Drawing.Size(195, 82);
            this.btn_addapp.TabIndex = 1;
            this.btn_addapp.Text = "Add Appointment";
            this.btn_addapp.UseVisualStyleBackColor = true;
            this.btn_addapp.Click += new System.EventHandler(this.btn_addapp_Click);
            // 
            // btn_addrmd
            // 
            this.btn_addrmd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_addrmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addrmd.Location = new System.Drawing.Point(795, 513);
            this.btn_addrmd.Name = "btn_addrmd";
            this.btn_addrmd.Size = new System.Drawing.Size(195, 82);
            this.btn_addrmd.TabIndex = 7;
            this.btn_addrmd.Text = "Add Reminder";
            this.btn_addrmd.UseVisualStyleBackColor = true;
            this.btn_addrmd.Click += new System.EventHandler(this.btn_addrmd_Click);
            // 
            // btn_join
            // 
            this.btn_join.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_join.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_join.Location = new System.Drawing.Point(415, 513);
            this.btn_join.Name = "btn_join";
            this.btn_join.Size = new System.Drawing.Size(195, 82);
            this.btn_join.TabIndex = 2;
            this.btn_join.Text = "Join Meeting";
            this.btn_join.UseVisualStyleBackColor = true;
            this.btn_join.Click += new System.EventHandler(this.btn_join_Click);
            // 
            // dgv_user
            // 
            this.dgv_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_user.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_user.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_user.Location = new System.Drawing.Point(1033, 61);
            this.dgv_user.Name = "dgv_user";
            this.dgv_user.ReadOnly = true;
            this.dgv_user.RowHeadersWidth = 51;
            this.dgv_user.RowTemplate.Height = 24;
            this.dgv_user.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_user.Size = new System.Drawing.Size(766, 431);
            this.dgv_user.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1216, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 36);
            this.label1.TabIndex = 10;
            this.label1.Text = "Danh sách user trong cuộc họp";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(347, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 36);
            this.label2.TabIndex = 12;
            this.label2.Text = "Danh sách cuộc họp";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1792, 960);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_user);
            this.Controls.Add(this.btn_join);
            this.Controls.Add(this.btn_addrmd);
            this.Controls.Add(this.btn_addapp);
            this.Controls.Add(this.dgv_app);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgv_app)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_user)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_app;
        private System.Windows.Forms.Button btn_addapp;
        private System.Windows.Forms.Button btn_addrmd;
        private System.Windows.Forms.Button btn_join;
        private System.Windows.Forms.DataGridView dgv_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

