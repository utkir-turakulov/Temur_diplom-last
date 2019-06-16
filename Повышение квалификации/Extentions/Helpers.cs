using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Повышение_квалификации.Extentions
{
	public class Helpers
	{
		public static bool GetDialogResult(string dialogMessage, string dialogTitle)
		{
			DialogResult dialogResult = MessageBox.Show(dialogMessage, dialogTitle, MessageBoxButtons.YesNo);

			switch (dialogResult)
			{
				case DialogResult.Yes:
					{
						return true;
					}

				case DialogResult.No:
					{
						return false;
					}

				default:
					return false;;
			}
		}
	}
}
