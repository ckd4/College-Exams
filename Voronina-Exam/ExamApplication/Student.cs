using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamApplication
{
    internal class ClassName : object
    {
        public int Year { get; set; }

        public string Letter { get; set; }

        public ClassName() { }

        // Конструкт, который будет принимать в себя год обучения и букву класса
        public ClassName(int year, string letter)
        {
            Year = year;
            Letter = letter;
        }

        // Форматирование класса в строку
        public override string ToString()
        {
            return $"{Year}-{Letter}";
        }
    }
    // Класс Студентов
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public ClassName Class { get; set; }
    }
}
