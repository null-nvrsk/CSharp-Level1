// [Скоморохов Максим]
// а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен постараться получить это число за минимальное количество ходов.
// в) * Добавить кнопку «Отменить», которая отменяет последние ходы.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Doubler
{
    public partial class MainForm : Form
    {
        int commandCount = 0;
        int number = 0;
        int findNumber = 0;

        Random rnd = new Random();

        //---------------------------------------------------------------------
        public MainForm()
        {
            InitializeComponent();
            RedrawInfo();
        }

        //---------------------------------------------------------------------
        private void btnPlus_Click(object sender, EventArgs e)
        {
            number++;
            commandCount++;
            RedrawInfo();
            CheckSuccess();
        }

        //---------------------------------------------------------------------
        private void btnDouble_Click(object sender, EventArgs e)
        {
            number *= 2;
            commandCount++;
            RedrawInfo();
            CheckSuccess();
        }

        //---------------------------------------------------------------------
        private void btnReset_Click(object sender, EventArgs e)
        {
            number = 0;
            commandCount = 0;
            RedrawInfo();
        }

        //---------------------------------------------------------------------
        private void RedrawInfo()
        {
            lblNumber.Text = number.ToString();
            lblCommands.Text = $"Кол-во команд: {commandCount}";
            if (findNumber > 0)
                lblFindNumber.Text = "Подобрать число " + findNumber.ToString();
            else
                lblFindNumber.Text = "";
        }

        //---------------------------------------------------------------------
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findNumber = rnd.Next(1, 101);
            MessageBox.Show($"Вам надо подобрать число {findNumber}");
            RedrawInfo();
        }

        //---------------------------------------------------------------------
        private void CheckSuccess()
        {
            if (number == findNumber)
            {
                MessageBox.Show($"Поздравляем! Вы подобрали число за {commandCount} ходов");
                number = 0;
                commandCount = 0;
                RedrawInfo();
            }
        }
    }
}
