using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomControls
{
	public class TextBoxDigit : Guna.UI2.WinForms.Guna2TextBox
	{
		public TextBoxDigit()
		{
			this.KeyPress += TextBoxDigit_KeyPress;
			this.ForeColor = System.Drawing.Color.Black;
		}

		private void TextBoxDigit_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
				e.Handled = false;
			else
				e.Handled = true;
		}
	}
}