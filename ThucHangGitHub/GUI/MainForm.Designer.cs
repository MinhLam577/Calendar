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
            this.cb_ClassName = new System.Windows.Forms.ComboBox();
            this.lb_class = new System.Windows.Forms.Label();
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
            this.button1.Location = new System.Drawing.Point(64, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 55);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cb_ClassName
            // 
            this.cb_ClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ClassName.FormattingEnabled = true;
            this.cb_ClassName.Items.AddRange(new object[] {
            "21TCLC_DT4",
            "21TCLC_DT3",
            "21TCLC_DT2",
            "21TCLC_KHDL",
            "22TCLC_KHDL",
            "ALL"});
            this.cb_ClassName.Location = new System.Drawing.Point(230, 440);
            this.cb_ClassName.Name = "cb_ClassName";
            this.cb_ClassName.Size = new System.Drawing.Size(279, 37);
            this.cb_ClassName.TabIndex = 22;
            // 
            // lb_class
            // 
            this.lb_class.AutoSize = true;
            this.lb_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_class.Location = new System.Drawing.Point(62, 443);
            this.lb_class.Name = "lb_class";
            this.lb_class.Size = new System.Drawing.Size(78, 29);
            this.lb_class.TabIndex = 21;
            this.lb_class.Text = "Class";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 521);
            this.Controls.Add(this.cb_ClassName);
            this.Controls.Add(this.lb_class);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_sv);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_sv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cb_ClassName;
        private System.Windows.Forms.Label lb_class;
    }
}