using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Бухтияров Максим
// 1. С помощью рефлексии выведите все свойства структуры DateTime
//
// 2. Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
//
// 3. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
// б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
// в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
// г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).
//
// 4. *Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных (Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).
//
// 5. **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
//

namespace Lesson_8
{
    public partial class frmBasic : Form
    {

        FormMethods frm; // создаем экземпляр класса с методами, применимыми к этой форме в момент создания самой формы

        public frmBasic()
        {
            InitializeComponent();
            rbTask1.Checked = true;
            frm = new FormMethods(this);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            bool[] rbArray = new bool[] { rbTask1.Checked, rbTask2.Checked, rbTask3.Checked, rbTask4.Checked, rbTask5.Checked };
            frm.RbCheck(rbArray);
        }
    }
}
