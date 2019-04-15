using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using frmTask1;
using frmTask2;
using frmTask3;
using frmTask4;
using frmTask5;

namespace Lesson_8
{
    class FormMethods
    {
        // frmBasic myForm;

        public FormMethods(frmBasic frm) // инициализации класса методов формы
        {
            frmBasic myForm = frm;
        }


        public void RbCheck(bool[] array)
        {
            int rbChecked = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == true)
                {
                    rbChecked = i;
                    break;
                }
            }

            switch (rbChecked)
            {
                case 0:
                    FrmTask1Start();
                    break;
                case 1:
                    FrmTask2Start();
                    break;
                case 2:
                    FrmTask3Start();
                    break;
                case 3:
                    FrmTask4Start();
                    break;
                case 4:
                    FrmTask5Start();
                    break;
            }
        }
        public void FrmTask1Start()
        {
            Task1 frm = new Task1();
            frm.Show();
        }
        public void FrmTask2Start()
        {
            Task2 frm = new Task2();
            frm.Show();
        }
        public void FrmTask3Start()
        {
            Task3 frm = new Task3();
            frm.Show();
        }
        public void FrmTask4Start()
        {
            Task4 frm = new Task4();
            frm.Show();
        }
        public void FrmTask5Start()
        {
            Task5 frm = new Task5();
            frm.Show();
        }
    }
}
