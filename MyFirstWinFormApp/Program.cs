namespace MyFirstWinFormApp
{
	internal static class Program
	{
		// Tic-Tac-Toe
		// Mineswapper
		// 


		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.


			ApplicationConfiguration.Initialize();
			Application.Run(new TicTacToe());
		}
	}
}