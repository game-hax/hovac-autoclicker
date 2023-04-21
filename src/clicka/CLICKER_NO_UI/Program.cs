using System;
using System.Windows.Forms;

namespace CLICKER_NO_UI
{
	// Token: 0x0200000A RID: 10
	internal static class Program
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000021F1 File Offset: 0x000003F1
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ui());
		}
	}
}
