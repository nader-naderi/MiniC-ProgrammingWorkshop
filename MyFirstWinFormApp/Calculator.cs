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
	public partial class Calculator : Form
	{
		int firstNumber;
		int lastNumber;
		
		public enum OperationType { Minus, Plus, Multipliaction, Divide };


		OperationType operationType;

		bool isOperatedPreviously = false;

		public Calculator()
		{
			InitializeComponent();
		}

		private void AddTextToMainText(string text)
		{
			if(isOperatedPreviously)
			{
				mainTxtBox.Text = string.Empty;
				isOperatedPreviously = false;
			}

			mainTxtBox.Text += text;
		}

		private void numberZero_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(0.ToString());
		}

		private void numberOne_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(1.ToString());
		}

		private void numberTwo_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(2.ToString());
		}

		private void numberThree_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(3.ToString());
		}

		private void numberFour_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(4.ToString());
		}

		private void numberFive_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(5.ToString());
		}

		private void numberSix_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(6.ToString());
		}

		private void numberSeven_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(7.ToString());
		}

		private void numberEight_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(8.ToString());
		}

		private void numberNine_Btn_Click(object sender, EventArgs e)
		{
			AddTextToMainText(9.ToString());
		}

		private void multipleBtn_Click(object sender, EventArgs e)
		{
			ChangeOperationType(OperationType.Multipliaction);
		}

		private void divisionBtn_Click(object sender, EventArgs e)
		{
			ChangeOperationType(OperationType.Divide);
		}

		

		private void minusBtn_Click(object sender, EventArgs e)
		{
			ChangeOperationType(OperationType.Minus);

		}

		private void sumationBtn_Click(object sender, EventArgs e)
		{
			ChangeOperationType(OperationType.Plus);

		}

		private void ChangeOperationType(OperationType targetType)
		{
			operationType = targetType;
			firstNumber = Convert.ToInt32(mainTxtBox.Text);
			mainTxtBox.Text = string.Empty;
		}

		private void equalBtn_Click(object sender, EventArgs e)
		{
			lastNumber = Convert.ToInt32(mainTxtBox.Text);
			mainTxtBox.Text = string.Empty;


			switch (operationType)
			{
				case OperationType.Minus:
					mainTxtBox.Text = (firstNumber - lastNumber).ToString();
					break;
				case OperationType.Plus:
					mainTxtBox.Text = (firstNumber + lastNumber).ToString();

					break;
				case OperationType.Multipliaction:
					mainTxtBox.Text = (firstNumber * lastNumber).ToString();

					break;
				case OperationType.Divide:
					mainTxtBox.Text = (firstNumber / lastNumber).ToString();

					break;
				default:
					break;
			}

			isOperatedPreviously = true;
		}

		private void clearBtn_Click(object sender, EventArgs e)
		{
			mainTxtBox.Text = string.Empty;
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (mainTxtBox.Text.Length <= 0)
				return;

			mainTxtBox.Text = mainTxtBox.Text.Remove(mainTxtBox.Text.Length - 1);
		}
	}
}
