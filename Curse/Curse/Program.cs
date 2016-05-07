using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterWork
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MarkList AllMark = new MarkList(Environment.CurrentDirectory + @"\Users\dima\Documents\Visual Studio 2013\Projects\SemesterWork\AllMark.txt");
            MarkList MyMark = new MarkList(Environment.CurrentDirectory + @"\Users\dima\Documents\Visual Studio 2013\Projects\SemesterWork\MyMark.txt");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public class Mark
        {
            private string name;
            private string year;
            private string country;
            private string describe;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Year
            {
                get { return year; }
                set { year = value; }
            }

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            public string Describe
            {
                get { return describe; }
                set { describe = value; }
            }

            public Mark(string n, string y, string c, string d)
            {
                name = n;
                year = y;
                country = c;
                describe = d;
            }
        }

        public class Philatelist
        {
            private string name;
            private string country;
            private string details;
            private string raremark;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public string Country
            {
                get { return country; }
                set { country = value; }
            }

            public string Details
            {
                get { return details; }
                set { details = value; }
            }

            public string Rarecoin
            {
                get { return raremark; }
                set { raremark = value; }
            }

            public Philatelist(string n, string c, string d, string r)
            {
                name = n;
                country = c;
                details = d;
                raremark = r;
            }
        }

        public class MarkList //:TxtReader
        {
            List<Mark> MyList;

            public MarkList(string p) //:base(p)
            {
                MyList = new List<Mark>();
            }

            public void CreateNewElem(string n, string y, string c, string d) //создает новый элемент
            {
                n = n.Replace(System.Environment.NewLine, "");
                y = y.Replace(System.Environment.NewLine, "");
                c = c.Replace(System.Environment.NewLine, "");
                d = d.Replace(System.Environment.NewLine, "");

                AddInColl(n, y, c, d);
                string[] str = { n, y, c, d };
                AddToFile(str);
            }

            public void CreateCollFromFile() //создает колелекцию из файла
            {
                string[] str = CreateArr();
                if (str.Length % 4 != 0)
                {
                    CriticalError();
                    return;
                }
                for (int i = 0; i < str.Length; i += 4)
                {
                    AddInColl(str[i], str[i + 1], str[i + 2], str[i + 3]);
                }
            }

            public void ChangeElem(int markindex, string n, string y, string c, string d) //меняет элемент коллекции
            {
                n = n.Replace(System.Environment.NewLine, "");
                y = y.Replace(System.Environment.NewLine, "");
                c = c.Replace(System.Environment.NewLine, "");
                d = d.Replace(System.Environment.NewLine, "");

                if (MyList.Count <= markindex)
                {
                    return;
                }
                Mark current = MyList[markindex];
                if(!(n ! = "" && n != null && y != "" && y != null && c != "" && c != null && d != "" && d != null))
                {
                    if(n != "" && n != null)
                        current.Name = n;
                    if(y != "" && y != null)
                        current.Year = y;
                    if(c != "" && c != null)
                        current.Country = c;
                    if(d != "" && d != null)
                        current.Describe = d;

                    ChangeFile(CreateFileFromColl());

                }
            }

            public void DeleteItem(int markindex) // удаляет элемент из коллекции
            {
                MyList.RemoveAt(markindex);
                ChangeFile(CreateFileFromColl());
            }

            public override void Print()
            {
                int a = 0;
                foreach (Mark n in MyList)
                {
                    Console.WriteLine(a + ":\t" + n.Name + ", " + n.Year + ", " + n.Country + ", " + n.Describe);
                    a++;
                }
            }

            private void CriticalError()
            {
                Console.WriteLine("Файл поврежден!");
            }

            private string[] CreateFileFromColl() //создает массив из коллекции
            {
                string[] str = new string[MyList.Count() * 4];
                int a = 0;
                foreach (Mark n in MyList)
                {
                    str[a] = n.Name;
                    str[a + 1] = n.Year;
                    str[a + 2] = n.Country;
                    str[a + 3] = n.Describe;
                    a += 4;
                }
                return str;
            }

            private void AddInColl(string n, string y, string c, string d) //заносить элемент в коллекцию
            {
                MyList.Add(new Mark(n, y, c, d));
            }
        }

        public class TxtReader
        {
            private string path;
            public string Path
            {
                get { return path; }
                set { path = value; }
            }


        }

    }
}
