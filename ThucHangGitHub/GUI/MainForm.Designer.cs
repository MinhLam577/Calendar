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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 521);
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
    }
}