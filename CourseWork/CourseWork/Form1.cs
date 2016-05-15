using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddMarks(myMarks);
            label1.Text = myMarks.GetMark(0).Year.ToString();
            label1.Text = myMarks.GetMark(0).Country;
            AddPhilatelist(myPhilatelists);
            label2.Text = myPhilatelists.GetPhilatelist(0).Name;
        }

        MarkList myMarks = new MarkList();

        PhilatelistList myPhilatelists = new PhilatelistList();

        private void AddMarks(MarkList myMarks)
        {
            TextReader mark = new StreamReader(@"marks.txt");
            int numOfMarks = Convert.ToInt32(mark.ReadLine());
            for (int i = 0; i < numOfMarks; i++)
            {
                myMarks.AddMark(new Mark(Convert.ToInt32(mark.ReadLine()), mark.ReadLine(), Convert.ToDouble(mark.ReadLine()), Convert.ToInt32(mark.ReadLine()), mark.ReadLine())); 
            }
            mark.Close();
        }

        private void AddPhilatelist(PhilatelistList myPhilatelists)
        {
            TextReader philatelists = new StreamReader(@"philatelists.txt");
            int numOfPhilatelists = Convert.ToInt32(philatelists.ReadLine());
            for (int i = 0; i < numOfPhilatelists; i++)
            {
                myPhilatelists.AddPhilatelists(new Philatelist(philatelists.ReadLine(), philatelists.ReadLine(), philatelists.ReadLine()));
            }
            philatelists.Close();
        }
    }
}
