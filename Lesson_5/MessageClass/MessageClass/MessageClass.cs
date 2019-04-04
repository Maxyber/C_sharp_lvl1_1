using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageClass
{
    public class Message
    {
        string msg;

        // логика
        public Message(string str)
        {
            msg = str;
        }
        public string this[string str]
        {
            get
            {
                return msg;
            }
            set
            {
                msg = str;
            }
        }
        public void Add(string text)
        {
            msg = msg + text;
        }
        public override string ToString()
        {
            string res = msg;
            return res;
        }
        public void PrintWords(int letter = 100)
        {
            string[] strArr = msg.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
            {
                string temp = strArr[i];
                if (temp.Length <= letter) PrintString(temp);
            }
            PrintString("Операция выполнена");
        }
        public void WordDeleteLC(char ch)
        {
            char lastCh;
            int count = 0;
            Message newmsg = new Message("");
            string[] strArr = msg.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
            {
                lastCh = strArr[i][strArr[i].Length - 1];
                if (lastCh != ch) newmsg.Add(" " + strArr[i]);
                else count++;
            }
            PrintString($"Вы удалили {count} слов");
            msg = newmsg.ToString();
        }
        public string Longest()
        {
            string[] strArr = msg.Split(' ');
            string res = strArr[0];
            for (int i = 1; i < strArr.Length; i++)
                if (res.Length < strArr[i].Length) res = strArr[i];
            return res;
        }
        public StringBuilder SBLongest()
        {
            StringBuilder sb = new StringBuilder();
            int lLength = this.Longest().Length;
            string[] strArr = msg.Split(' ');
            for (int i = 0; i < strArr.Length; i++)
                if (strArr[i].Length == lLength) sb = sb.Insert(sb.Length, strArr[i] + " ");
            sb = sb.Remove(sb.Length - 1, 1);
            return sb;
        }
        // интерфейс
        private void PrintString(string toPrint)
        {
            Console.WriteLine(toPrint);
        }
        public void Print()
        {
            Console.WriteLine("Ваше сообщение: " + msg);
        }

    }

}
