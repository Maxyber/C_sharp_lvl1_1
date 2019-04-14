using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmTask4
{
    public partial class Task4 : Form
    {

        // База данных с днями рождениями
        Contacts database;

        public Task4()
        {
            InitializeComponent();
        }

        private void btnNewBase_Click(object sender, EventArgs e) // обработчик кнопки новая база
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new Contacts(sfd.FileName);
                database.Add("Фамилия", "Имя", "Отчество", DateTime.Now, "000000, Областная область, г. Город, район Район, улица Улица, д. Дом, стр. Корп. кв. Кв.", "email@domain", "+8(888)888-88-88");
                database.Save();
            };
        }
        private void btnOpenBase_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new Contacts(ofd.FileName);
                database.Load();
                Print(database);
            }
        }
        private void btnAddRecord_Click(object sender, EventArgs e) // обработчик кнопки добавить запись
        {
            string uFamily = tbFamily.Text;
            string uName = tbName.Text;
            string uSurname = tbSurname.Text;
            DateTime uDate = new DateTime();
            if ((int.TryParse(tbDateYear.Text, out int yyyy)) && (int.TryParse(tbDateMonth.Text, out int mm)) && (int.TryParse(tbDateDay.Text, out int dd)) && (DateTime.TryParse($"{dd}/{mm}/{yyyy}T00:00:00Z", out DateTime xDate)))
            {
                uDate = xDate;
            }
            else {
                MessageBox.Show("Ошибка в дате рождения!");
                uDate = DateTime.Now;
            }
            string uAddress = $"{tbAddressIndex.Text}|{tbAddressRegion.Text}|{tbAddressCity.Text}|{tbAddressDistrict.Text}|{tbAddressStreet.Text}|{tbAddressHome.Text}|{tbAddressBuilding.Text}|{tbAddressFlat.Text}";
            string uEmail = $"{tbEmailName}|{tbEmailDomain}";
            string uPhone = $"{tbPhoneCoutry.Text}|{tbPhoneRegion.Text}|{tbPhone1.Text}|{tbPhone2.Text}|{tbPhone3.Text}";

            database.Add(uFamily, uName, uSurname, uDate, uAddress, uEmail, uPhone);
        }

        private void btnEditRecord_Click(object sender, EventArgs e) // обработчик кнопки сохранить запись
        {

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e) // обработчик кнопки удалить запись
        {

        }

        private void Print(Contacts data)
        {
            if (data.Count > 1)
            {
                for (int i = 1; i < data.Count; i++)
                {
                    lbBirthdays.Items.Add(data.ToListBox(i));
                }
            }
        }

        private void lbBirthdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbBirthdays.Items.IndexOf() + 1;
            Birthdays item = database[];
        }
    }
}
