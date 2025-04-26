using Bank.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class App : Form
    {
        DataGridView table = new DataGridView(); //Создание таблицы для расчёта кредита

        public App()
        {
            InitializeComponent();
        }

        private void App_Load(object sender, EventArgs e) //Создание столбцов таблицы и параметров при загрузке формы
        {
            table.Dock = DockStyle.Fill;

            table.Columns.Add("months", "Дата платежа");
            table.Columns.Add("moneyToDept", "Погашение основного долга");
            table.Columns.Add("moneyToPercent", "Погашение процента");
            table.Columns.Add("payment", "Месячный платёж");
            table.Columns.Add("ostatok", "Отаток задолженности");
            table.ColumnHeadersHeight = 90;
            table.ReadOnly = true;
            table.AllowUserToAddRows = false;
            table.AllowUserToDeleteRows = false;
            table.Columns[0].Width = 162;
            table.Columns[1].Width = 140;
            table.Columns[2].Width = 140;
            table.Columns[3].Width = 140;
            table.Columns[4].Width = 140;
        }

        private void App_FormClosed(object sender, FormClosedEventArgs e) //Выход из приложения при его закрытии (так как это вторая форма)
        {
            Application.Exit();
        }

        private void button_tableShow_Click(object sender, EventArgs e) //Показ таблицы при нажатии кнопки
        {
            //Проверки на корректность данных
            if (textBox_sum.Text == "" || textBox_term.Text == "" || textBox_percent.Text == "") //На пустые строки
            {
                MessageBox.Show("Вы заполнили не все поля");
            }
            else if (long.Parse(textBox_sum.Text) < 10000 || double.Parse(textBox_term.Text) < 0.5 || double.Parse(textBox_percent.Text) <= 0) //На корректность значений (относительно реальных данных)
            {
                MessageBox.Show("Минимальная сумма кредита - 10000\nМинимальный срок кредита - полгода\nПроцентная ставка должна быть не менее 0%");
            }
            else if (textBox_sum.Text.Length > 10 || textBox_term.Text.Length > 20 || textBox_term.TextLength > 20) //На длинну символов (из-за ограничений в типах данных)
            {
                MessageBox.Show("Сумма должна быть по длине не более 10 символов\nСрок и ставка должны юыть по длине не более 20 символов");
            }
            else if (textBox_sum.Text[0] == '0' || textBox_term.Text.Length >= 2 && textBox_term.Text[0] == '0' && textBox_term.Text[1] != ',' || textBox_percent.Text.Length >= 2 && textBox_percent.Text[0] == '0' && textBox_percent.Text[1] != ',') //Проверка на ввод чисел с нуля 1
            {
                MessageBox.Show("Числа не должны начинаться на 0\n(кроме \"0,\")");
            }
            else //Если данные корректны - создание таблицы и отображение формы с ней
            {
                table.Rows.Clear(); //Очистка рядов (дабы избежать повторных строк в таблице)

                //Инициализация переменных данными с формы
                DateTime creditDate = dateTimePicker.Value;
                double sum = int.Parse(textBox_sum.Text);
                double term = double.Parse(textBox_term.Text);
                double percent = double.Parse(textBox_percent.Text) * 0.01;

                //Переменные для подсчёта итоговой суммы
                double finOnDebt = 0;
                double finOnPercent = 0;

                //Платёж по основному долгу (по формуле)
                double on_debt = Math.Floor(sum / (term * 12));

                for (int i = 0; i < term * 12; i++) //Цикл заполнения рядов таблицы
                {
                    //Изменение данных для занесения в таблицу
                    creditDate = creditDate.AddMonths(1); //Дата
                    int daysInMonth = DateTime.DaysInMonth(creditDate.Year, creditDate.Month); //Кол-во дней в месяце
                    int daysInYear = DateTime.IsLeapYear(creditDate.Year) ? 366 : 365; //Кол-во дней в году
                    double on_percent = Math.Floor((sum * percent * daysInMonth) / daysInYear); //Платёж по процентам (по формуле)
                    double payment = on_debt + on_percent; //Размер дифференцированного платежа
                    sum -= on_debt; //Остаток задолженности

                    //Подсчт итоговых сумм
                    finOnDebt += on_debt;
                    finOnPercent += on_percent;

                    //Дату в строку
                    string dateOfPayment = creditDate.ToLongDateString();

                    //Добавление ряда в таблицу
                    if (i == term * 12 - 1 & sum > 0) //В случае, если использовалось округление (при "некрасивых" числах)
                    {
                        table.Rows.Add(dateOfPayment, on_debt + "+" + sum + "₽", on_percent + "₽", payment + sum + "₽", "0₽");
                        finOnDebt += sum;
                    }
                    else //В обычном случае
                    {
                        table.Rows.Add(dateOfPayment, on_debt + "₽", on_percent + "₽", payment + "₽", sum + "₽");
                    }
                }

                //Добавление итогового ряда
                table.Rows.Add();
                table.Rows.Add("Итог:", finOnDebt + "₽", finOnPercent + "₽", finOnDebt+finOnPercent + "₽");

                //Создание и вывод формы с таблицей
                Form tableForm = new Form();
                tableForm.Icon = Resources.MoneyIcon;
                tableForm.Text = "График погашения кредита";
                tableForm.Width = 800;
                tableForm.Height = 550;
                tableForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                tableForm.StartPosition = FormStartPosition.CenterScreen;
                tableForm.MaximizeBox = false;
                tableForm.MinimizeBox = false;
                tableForm.Controls.Clear();
                tableForm.Controls.Add(table);
                tableForm.ShowDialog();
                tableForm.Controls.Clear();
            }
        }

        private void textBox_sum_KeyPress(object sender, KeyPressEventArgs e) //Проверка на ввод только чисел или кнопки Backspace
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_term_KeyPress(object sender, KeyPressEventArgs e) //Проверка на ввод только чисел, 1 запятой или кнопки Backspace
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8 && num != 44)
            {
                e.Handled = true;
            }
            if (num == 44)
            {
                if (textBox_term.Text.Contains(','))
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_percent_KeyPress(object sender, KeyPressEventArgs e) //Проверка на ввод только чисел, 1 запятой или кнопки Backspace
        {
            char num = e.KeyChar;
            if (!char.IsDigit(num) && num != 8 && num != 44)
            {
                e.Handled = true;
            }
            if (num == 44)
            {
                if (textBox_percent.Text.Contains(','))
                {
                    e.Handled = true;
                }
            }
        }
    }
}