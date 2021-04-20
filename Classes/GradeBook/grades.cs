using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class grades
    {
        public void addgrade(float grade)
        {
            gradelist.Add(grade);
        }
        List<float> gradelist= new List<float>();

    }
}
