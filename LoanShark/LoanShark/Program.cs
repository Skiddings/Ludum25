#region Using Statements
using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace LoanShark
{
	static class Program
	{
		private static LoadSharkGame game;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main ()
		{
			game = new LoadSharkGame ();
			game.Run ();
		}
	}
}
