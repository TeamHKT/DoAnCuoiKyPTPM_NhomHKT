namespace WinformApp
{
    partial class QuanLyVe
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgv_Ve = new Guna.UI2.WinForms.Guna2DataGridView();
			this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.cbb_SuKien = new Guna.UI2.WinForms.Guna2ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_Ve)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_Ve
			// 
			this.dgv_Ve.AllowUserToAddRows = false;
			this.dgv_Ve.AllowUserToDeleteRows = false;
			this.dgv_Ve.AllowUserToResizeColumns = false;
			this.dgv_Ve.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgv_Ve.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_Ve.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_Ve.ColumnHeadersHeight = 40;
			this.dgv_Ve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_Ve.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_Ve.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dgv_Ve.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Ve.Location = new System.Drawing.Point(0, 61);
			this.dgv_Ve.Margin = new System.Windows.Forms.Padding(2);
			this.dgv_Ve.MultiSelect = false;
			this.dgv_Ve.Name = "dgv_Ve";
			this.dgv_Ve.RowHeadersVisible = false;
			this.dgv_Ve.RowHeadersWidth = 51;
			this.dgv_Ve.RowTemplate.Height = 24;
			this.dgv_Ve.Size = new System.Drawing.Size(824, 464);
			this.dgv_Ve.TabIndex = 15;
			this.dgv_Ve.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Ve.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.dgv_Ve.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.dgv_Ve.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.dgv_Ve.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.dgv_Ve.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Ve.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Ve.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.dgv_Ve.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dgv_Ve.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Ve.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.dgv_Ve.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.dgv_Ve.ThemeStyle.HeaderStyle.Height = 40;
			this.dgv_Ve.ThemeStyle.ReadOnly = false;
			this.dgv_Ve.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.dgv_Ve.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.dgv_Ve.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dgv_Ve.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			this.dgv_Ve.ThemeStyle.RowsStyle.Height = 24;
			this.dgv_Ve.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dgv_Ve.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// guna2HtmlLabel2
			// 
			this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
			this.guna2HtmlLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.guna2HtmlLabel2.Location = new System.Drawing.Point(11, 11);
			this.guna2HtmlLabel2.Margin = new System.Windows.Forms.Padding(2);
			this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
			this.guna2HtmlLabel2.Size = new System.Drawing.Size(90, 28);
			this.guna2HtmlLabel2.TabIndex = 21;
			this.guna2HtmlLabel2.Text = "Sự kiện:";
			// 
			// cbb_SuKien
			// 
			this.cbb_SuKien.BackColor = System.Drawing.Color.Transparent;
			this.cbb_SuKien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbb_SuKien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbb_SuKien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_SuKien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbb_SuKien.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbb_SuKien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbb_SuKien.ItemHeight = 30;
			this.cbb_SuKien.Location = new System.Drawing.Point(106, 8);
			this.cbb_SuKien.Name = "cbb_SuKien";
			this.cbb_SuKien.Size = new System.Drawing.Size(302, 36);
			this.cbb_SuKien.TabIndex = 22;
			// 
			// QuanLyVe
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 525);
			this.Controls.Add(this.cbb_SuKien);
			this.Controls.Add(this.guna2HtmlLabel2);
			this.Controls.Add(this.dgv_Ve);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "QuanLyVe";
			this.Text = "QuanLyVe";
			((System.ComponentModel.ISupportInitialize)(this.dgv_Ve)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Ve;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
		private Guna.UI2.WinForms.Guna2ComboBox cbb_SuKien;
	}
}