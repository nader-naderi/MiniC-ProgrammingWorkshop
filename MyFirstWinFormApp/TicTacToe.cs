using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinFormApp
{
	public partial class TicTacToe : Form
	{
		public enum Turns { Player_1, Player_2 }
		
		private Turns turns = Turns.Player_1;

		char[,] map = new char[3, 3]
		{ 
			{ ' ', ' ', ' ' },
			{ ' ', ' ', ' ' },
			{ ' ', ' ', ' ' }, 
		};

		char playerOneSymbol = 'O';
		char playerTwoSymbol = 'X';

		public TicTacToe()
		{
			InitializeComponent();
		}

		private void TicTacToe_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < map.GetLength(0); i++)
				for (int j = 0; j < map.GetLength(1); j++)
					if (map[i, j] != ' ')
						map[i, j] = ' ';

			if (turns == Turns.Player_1)
			{
				turnsLbl.Text = "Turns : Player 1";
			}
			else if (turns == Turns.Player_2)
			{
				turnsLbl.Text = "Turns : Player 2";
			}
		}

		private void UpdateAllCells()
		{
			UpdateCell(cell_00, 0, 0);
			UpdateCell(cell_01, 0, 1);
			UpdateCell(cell_02, 0, 2);

			UpdateCell(cell_10, 1, 0);
			UpdateCell(cell_11, 1, 1);
			UpdateCell(cell_12, 1, 2);

			UpdateCell(cell_20, 2, 0);
			UpdateCell(cell_21, 2, 1);
			UpdateCell(cell_22, 2, 2);
		}

		private void UpdateCell(Button cell, int i, int j)
		{
			cell.Text = map[i, j].ToString();
		}

		private void cell_00_Click(object sender, EventArgs e)
		{
			SymbolConfiguration(0, 0);
		}

		private void cell_10_Click(object sender, EventArgs e)
		{
			SymbolConfiguration(1, 0);
		}

		private void cell_20_Click(object sender, EventArgs e)
		{
			SymbolConfiguration(2, 0);
		}

		private void cell_01_Click(object sender, EventArgs e)
		{
			SymbolConfiguration(0, 1);
		}

		private void cell_11_Click(object sender, EventArgs e)
		{
			SymbolConfiguration(1, 1);
		}

		private void cell_21_Click(object sender, EventArgs e)
		{
			SymbolConfiguration(2, 1);
		}

		private void cell_02_Click(object sender, EventArgs e)
		{
			SymbolConfiguration(0, 2);
		}

		private void cell_12_Click(object sender, EventArgs e)
		{
			SymbolConfiguration(1, 2);
		}

		private void cell_22_Click(object sender, EventArgs e)
		{
			SymbolConfiguration(2, 2);
		}

		private void SymbolConfiguration(int i, int j)
		{
			TurnsConfiguration();
			char targetSymbol = 'O';

			if (turns == Turns.Player_1)
			{
				turnsLbl.Text = "Turns : Player 1";
				targetSymbol = playerOneSymbol;
			}
			else if (turns == Turns.Player_2)
			{
				turnsLbl.Text = "Turns : Player 2";
				targetSymbol = playerTwoSymbol;
			}
			map[i, j] = targetSymbol;

			UpdateAllCells();
		}

		private void TurnsConfiguration()
		{
			if (turns == Turns.Player_1)
			    turns = Turns.Player_2;
			else if (turns == Turns.Player_2)
					 turns = Turns.Player_1;

			string s = "1";
			Console.Write("Name {0}", s);
		}
	}
}
