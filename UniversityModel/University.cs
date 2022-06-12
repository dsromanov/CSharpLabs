using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2sharp
{
    public class University//1 lvl
    {
        private string nameOfUniversity;
        private int studentsFirstCourse;
        private int graduatedStudents;
        public University()
        {

        }
        public University(string name,int studentsFirst, int graduated)
        {
            this.nameOfUniversity = name;
            this.studentsFirstCourse = studentsFirst;
            this.graduatedStudents = graduated;
        }
        public string getName()
        {
            return nameOfUniversity;
        }
        public void setName(string name)
        {
            this.nameOfUniversity = name;
        }
        public int getFirstCourse()
        {
            return studentsFirstCourse;
        }
        public void setFirstCourse(int studentsFirst)
        {
            this.studentsFirstCourse = studentsFirst;
        }
        public int getGraduated()
        {
            return graduatedStudents;
        }
        public void setGraduated(int graduated)
        {
            this.graduatedStudents = graduated;
        }

        public virtual double quality()
        {
            double Q = Math.Round(Convert.ToDouble(getGraduated()) / Convert.ToDouble(getFirstCourse()),2);
            return Q;
        }
        public virtual string info()
        {
            return "Название университета: " + getName() + Environment.NewLine + "Количество поступивших на 1 курс: " + getFirstCourse() + Environment.NewLine +  "Количество выпускников: " + getGraduated();
        }
    }
    public class SecondUniversity: University // 2 lvl
    {
        private int percent;
        public SecondUniversity(string name, int studentsFirst, int graduated, int percent): base (name,studentsFirst,graduated)
        {
            this.percent = percent;
        }
        public int getPercent()
        {
            return percent;
        }
        public void setPercent(int percent)
        {
            this.percent = percent;
        }
        public override double quality()
        {
            double Q = base.quality();
            double Qp = Q*Convert.ToDouble(percent/100.0);
            return Qp;
        }
        public override string info()
        {
            return base.info() + Environment.NewLine + "Процент выпускников работающих по специальности: " + getPercent();
        }
    }
}
