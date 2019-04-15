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
            if ((int.TryParse(tbDateYear.Text, out int yyyy)) && (int.TryParse(tbDateMonth.Text, out int mm)) && (int.TryParse(tbDateDay.Text, out int dd)) && (DateTime.TryParse($"{dd}/{mm}/{yyyy}", out DateTime xDate)))
            {
                uDate = xDate;
            }
            else {
                MessageBox.Show("Ошибка в дате рождения!");
                uDate = DateTime.Now;
            }
            string uAddress = $"{tbAddressIndex.Text},{tbAddressRegion.Text},{tbAddressCity.Text},{tbAddressDistrict.Text},{tbAddressStreet.Text},{tbAddressHome.Text},{tbAddressBuilding.Text},{tbAddressFlat.Text}";
            string uEmail = $"{tbEmailName.Text}@{tbEmailDomain.Text}";
            string uPhone = $"{tbPhoneCoutry.Text}({tbPhoneRegion.Text}){tbPhone1.Text}-{tbPhone2.Text}-{tbPhone3.Text}";

            lblInfo.Text = database.Add(uFamily, uName, uSurname, uDate, uAddress, uEmail, uPhone);
            database.Save();
            Print(database);
        }
        object

        private void btnEditRecord_Click(object sender, EventArgs e) // обработчик кнопки сохранить запись
        {
            int i = lbBirthdays.SelectedIndex + 1;
            string uFamily = tbFamily.Text;
            string uName = tbName.Text;
            string uSurname = tbSurname.Text;
            DateTime uDate = new DateTime();
            if ((int.TryParse(tbDateYear.Text, out int yyyy)) && (int.TryParse(tbDateMonth.Text, out int mm)) && (int.TryParse(tbDateDay.Text, out int dd)) && (DateTime.TryParse($"{dd}/{mm}/{yyyy}", out DateTime xDate)))
            {
                uDate = xDate;
            }
            else
            {
                MessageBox.Show("Ошибка в дате рождения!");
                uDate = DateTime.Now;
            }
            string uAddress = $"{tbAddressIndex.Text},{tbAddressRegion.Text},{tbAddressCity.Text},{tbAddressDistrict.Text},{tbAddressStreet.Text},{tbAddressHome.Text},{tbAddressBuilding.Text},{tbAddressFlat.Text}";
            string uEmail = $"{tbEmailName.Text}@{tbEmailDomain.Text}";
            string uPhone = $"{tbPhoneCoutry.Text}({tbPhoneRegion.Text}){tbPhone1.Text}-{tbPhone2.Text}-{tbPhone3.Text}";

            lblInfo.Text = database.Insert(i, uFamily, uName, uSurname, uDate, uAddress, uEmail, uPhone);
            database.Remove(i + 1);
            database.Save();
            Print(database);
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e) // обработчик кнопки удалить запись
        {
            int i = lbBirthdays.SelectedIndex + 1;
            if (database == null) return;
            database.Remove((int)i);
            database.Save();
            Print(database);
        }

        private void Print(Contacts data)
        {
            lbBirthdays.Items.Clear();
            if (data.Count > 1)
            {
                for (int i = 1; i < data.Count; i++)
                {
                    lbBirthdays.Items.Add(data.ToListBox(i));
                }
            }
        }
        private void ExtractItem(Birthdays item)
        {
            tbFamily.Text = item.Family;
            tbName.Text = item.Name;
            tbSurname.Text = item.Surname;

            DateTime date = item.Date;
            tbDateYear.Text = date.Year.ToString();
            tbDateMonth.Text = date.Month.ToString();
            tbDateDay.Text = date.Day.ToString();

            string[] address = item.Address.Split(',');
            tbAddressIndex.Text = address[0];
            tbAddressRegion.Text = address[1];
            tbAddressCity.Text = address[2];
            tbAddressDistrict.Text = address[3];
            tbAddressStreet.Text = address[4];
            tbAddressHome.Text = address[5];
            tbAddressBuilding.Text = address[6];
            tbAddressFlat.Text = address[7];

            string[] phone = item.Phone.Split('(');
            tbPhoneCoutry.Text = phone[0];
            tbPhoneRegion.Text = phone[1].Split(')')[0];
            string[] pnumber = phone[1].Split(')')[1].Split('-');
            tbPhone1.Text = pnumber[0];
            tbPhone2.Text = pnumber[1];
            tbPhone3.Text = pnumber[2];

            string[] email = item.Email.Split('@');
            tbEmailName.Text = email[0];
            tbEmailDomain.Text = email[1];
        }

        private void lbBirthdays_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = lbBirthdays.SelectedIndex + 1;
            Birthdays item = database[i];
            ExtractItem(item);
        }
    }
}
