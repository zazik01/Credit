using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Logo : Form
    {
        static int time = 0; //Переменная счётчика времени
        App app = new App(); //Ссылка на основное приложение
        public Logo()
        {
            InitializeComponent();
            timer.Start(); //Запуск таймера
        }

        private void timer_Tick(object sender, EventArgs e) //Подсчёт времени и дальнейший запуск программы
        {
            time++;
            if (time == 20)
            {
                timer.Stop();
                app.Show();
                this.Hide();
            }
        }
    }
}