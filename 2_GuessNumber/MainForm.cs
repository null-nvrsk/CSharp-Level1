// [Скоморохов Максим]
// Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.Для ввода данных от человека используется элемент TextBox.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_GuessNumber
{
    public partial class MainForm : Form
    {
        private int number = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------
        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            number = rnd.Next(1, 101);

            btnStart.Enabled = false;
            tbUserInput.Enabled = true;
            btnCheck.Enabled = true;
            lblResult.Text = "";
            tbUserInput.Text = "";
        }

        //---------------------------------------------------------------------
        private void btnCheck_Click(object sender, EventArgs e)
        {
            try
            {
                int userNumber = int.Parse(tbUserInput.Text);
                if (userNumber >= 1 && userNumber <= 100)
                {

                    CheckValue(number, userNumber);
                }
                else
                {
                    MessageBox.Show("Введите число от 1 до 100");
                    tbUserInput.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Введите число от 1 до 100");
                tbUserInput.Text = "";
            }
            
            
        }

        //---------------------------------------------------------------------
        private void CheckValue(int number, int userNumber)
        {
            if (userNumber > number)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Введено слишком большое число";
            }
            else if (userNumber < number)
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Введено слишком маленькое число";
            }
            else
            {
                lblResult.ForeColor = Color.Green;
                lblResult.Text = "Поздравляю! Вы угадали";

                btnStart.Enabled = true;
                tbUserInput.Enabled = false;
                btnCheck.Enabled = false;
            }
            
        }
    }
}
