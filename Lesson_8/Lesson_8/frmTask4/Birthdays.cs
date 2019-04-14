using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Xml.Serialization;
using System.IO;

namespace frmTask4
{
    [Serializable]
    public class Birthdays
    {
        private string family;    // Фамилия
        private string name;      // Имя
        private string surname;   // Отчество
        private DateTime date;    // Дата рождения
        private string address;   // Фактический адрес
        private string email;     // Адрес электронной почты
        private string phone;     // Телефонный номер
        
        // Для сериализации должен быть пустой конструктор.
        public Birthdays()
        {
        }
        public Birthdays(string family, string name, string surname, DateTime date, string address, string email, string phone)
        {
            this.family = family;
            this.name = name;
            this.surname = surname;
            this.date = date;
            this.address = address;
            this.email = email;
            this.phone = phone;
        }
        public string Family
        {
            get { return family; }
            set { family = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }
    // Класс для хранения списка контактов. А также для сериализации в XML и десериализации из XML
    class Contacts
    {
        string fileName;
        List<Birthdays> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public Contacts(string fileName)
        {
            this.fileName = fileName;
            list = new List<Birthdays>();
        }
        public void Add(string family, string name, string surname, DateTime date, string address, string email, string phone)
        {
            list.Add(new Birthdays(family, name, surname, date, address, email, phone));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }
        // Индексатор - свойство для доступа к закрытому объекту
        public Birthdays this[int index]
        {
            get { return list[index]; }
        }
        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Birthdays>));
            Stream fStream;
            fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Birthdays>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Birthdays>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public string ToListBox(int index)
        {
            return $"{list[index].Family} {list[index].Name} {list[index].Surname}";
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}
