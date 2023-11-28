using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
{
	public class Card : Form
	{
		public Button Left { get; set; }
		public Button Right { get; set; }
		private int id;
		private string img;
		private Panel item;

		private string title;

		public Panel GetItem()
		{
			return item;
		}

		public Card(int id, string img, string title)
		{
			Left = new Button();
			Right = new Button();
			this.id = id;
			this.title = title;
			this.img = img;
			// item
			item = new Panel();
			item.Size = new Size(220, 250);
			item.BorderStyle = BorderStyle.FixedSingle;
			item.Margin = new Padding(20);
			//top
			Panel top = new Panel();
			//bottom
			Panel bottom = new Panel();
			//middle
			Panel middle = new Panel();
			//lable
			Label name = new Label();
			//buttonleft
			Left.Size = new Size(109, 30);
			Left.FlatStyle = FlatStyle.Flat;
			Left.ForeColor = Color.FromArgb(60, 35, 23);
			Left.Text = "Chi tiết";
			Left.Cursor = Cursors.Hand;
			Left.Tag = id;
			//buttonright
			Right.Size = new Size(109, 30);
			Right.FlatStyle = FlatStyle.Flat;
			Right.ForeColor = Color.FromArgb(60, 35, 23);
			Right.Text = "Mua vé";
			Right.Cursor = Cursors.Hand;
			Right.Tag = id;
			//PICTURE
			PictureBox pic = new PictureBox();
			string path = $@"..\..\img\{img}";
			pic.Image = System.Drawing.Image.FromFile(path);
			pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			//
			item.BringToFront();
			item.BackColor = Color.FromArgb(224, 216, 176);
			item.BorderStyle = BorderStyle.None;
			item.Controls.Add(top);
			top.Dock = DockStyle.Top;
			top.Size = new Size(250, 150);
			top.BringToFront();
			//
			top.Controls.Add(pic);
			pic.Dock = DockStyle.Fill;
			pic.BringToFront();

			item.Controls.Add(bottom);
			bottom.Dock = DockStyle.Bottom;
			bottom.Size = new Size(200, 30);
			bottom.BringToFront();

			item.Controls.Add(middle);
			middle.Dock = DockStyle.Fill;
			middle.BringToFront();

			middle.Controls.Add(name);
			name.ForeColor = Color.FromArgb(60, 35, 23);
			name.Text = title;
			name.Font = new Font("Arial", 12);
			name.Dock = DockStyle.Fill;
			name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			name.BringToFront();

			bottom.Controls.Add(Left);
			bottom.Controls.Add(Right);
			Left.Font = new Font("Arial", 10);
			Left.Dock = DockStyle.Left;
			Right.Font = new Font("Arial", 10);
			Right.Dock = DockStyle.Right;
		}
	}
}