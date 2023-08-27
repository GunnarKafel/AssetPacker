using System;
using System.Windows.Forms;

namespace AssetPacker
{
	internal static class Program
	{
		public static packForm formInstance;
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			var form = new packForm();
			formInstance = form;
			Application.Run(form);
		}
	}
}
