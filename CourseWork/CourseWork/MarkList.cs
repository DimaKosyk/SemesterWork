using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class MarkList
    {
        private List<Mark> marks;

        public MarkList()
        {
            marks = new List<Mark>();
        }

        public void AddMark(Mark current)
        {
            marks.Add(current);
        }

        public Mark GetMark(int x)
        {
            return marks[x];    
        }

    }
}
