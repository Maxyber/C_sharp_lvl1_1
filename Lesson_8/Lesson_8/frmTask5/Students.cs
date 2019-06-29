using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace frmTask5
{
    public class Students
    {
        string family;
        string name;
        string city;
        string university;
        string faculty;
        string stream;
        int age;
        int year;
        string group;

        public Students()
        {
        }
        public Students(string family, string name, string city, string university, string faculty, string stream, string group, int age, int year)
        {
            this.family = family;
            this.name = name;
            this.city = city;
            this.university = university;
            this.faculty = faculty;
            this.stream = stream;
            this.group = group;
            this.age = age;
            this.year = year;
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
        public string University
        {
            get { return university; }
            set { university = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public string Stream
        {
            get { return stream; }
            set { stream = value; }
        }
        public string Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public override string ToString()
        {
            string s;
            s = $"Студент {family} {name} из {city} в возрасте {age}\r\nучащийся в {university} на факультете {faculty} по специальности {stream} на {year} курсе в {group} группе";
            return s;
        }
    }
    class StdListConverter
    {
        List<Students> list;
        public string xmlfile;
        public string csfile;

        public StdListConverter(string csfile, string xmlfile)
        {
            this.csfile = csfile;
            this.xmlfile = xmlfile;
            list = new List<Students>();
        }
        public string CsFile
        {
            set { csfile = value; }
        }
        public string XmlFile
        {
            set { xmlfile = value; }
        }
        public Students this[int index]
        {
            get
            {
                return list[index];
            }
        }

        public void LoadCs()
        {
            StreamReader fStream = new StreamReader(csfile, Encoding.UTF8);
            while (!fStream.EndOfStream)
            {
                try
                {
                    string[] s = fStream.ReadLine().Split(';');
                    int.TryParse(s[5], out int age);
                    int.TryParse(s[6], out int year);
                    Add(s[0], s[1], s[8], s[2], s[3], s[4], s[7], age, year);
                }
                catch
                {

                }
            }
            //list = (List<Students>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public void SaveXml()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Students>));
            Stream fStream;
            fStream = new FileStream(xmlfile, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Add(string family, string name, string city, string university, string faculty, string stream, string group, int age, int year)
        {
            list.Add(new Students(family, name, city, university, faculty, stream, group, age, year));
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}
