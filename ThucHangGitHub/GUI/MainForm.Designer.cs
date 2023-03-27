namespace ThucHangGitHub.GUI
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
            this.dgv_sv = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_sort = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_sv
            // 
            this.dgv_sv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sv.Location = new System.Drawing.Point(-1, -1);
            this.dgv_sv.Name = "dgv_sv";
            this.dgv_sv.RowHeadersWidth = 51;
            this.dgv_sv.RowTemplate.Height = 24;
            this.dgv_sv.Size = new System.Drawing.Size(887, 245);
            this.dgv_sv.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 55);
            this.button2.TabIndex = 2;
            this.button2.Text = "sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_sort
            // 
            this.cb_sort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_sort.FormattingEnabled = true;
            this.cb_sort.Items.AddRange(new object[] {
            "Class",
            "ID",
            "Name",
            "Dtb",
            "NS",
            "Gender"});
            this.cb_sort.Location = new System.Drawing.Point(644, 321);
            this.cb_sort.Name = "cb_sort";
            this.cb_sort.Size = new System.Drawing.Size(265, 37);
            this.cb_sort.TabIndex = 22;
            this.cb_sort.SelectedIndexChanged += new System.EventHandler(this.cb_sort_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 521);
            this.Controls.Add(this.cb_sort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_sv);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_sort;
    }
}