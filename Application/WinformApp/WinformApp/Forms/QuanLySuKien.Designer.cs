namespace WinformApp
{
    partial class QuanLySuKien
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
			this.flowLayoutPanel_SuKien = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flowLayoutPanel_SuKien
			// 
			this.flowLayoutPanel_SuKien.AutoScroll = true;
			this.flowLayoutPanel_SuKien.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel_SuKien.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel_SuKien.Name = "flowLayoutPanel_SuKien";
			this.flowLayoutPanel_SuKien.Size = new System.Drawing.Size(830, 586);
			this.flowLayoutPanel_SuKien.TabIndex = 0;
			// 
			// QuanLySuKien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(830, 586);
			this.Controls.Add(this.flowLayoutPanel_SuKien);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "QuanLySuKien";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "QuanLySuKien";
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_SuKien;
	}
}