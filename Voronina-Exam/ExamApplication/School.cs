using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ExamApplication
{
    // Класс опередляющий школу
    internal class School
    {
        // Конструктор
        public School()
        {
            Students = new List<Student>();
        }

        // Список студентов
        public List<Student> Students { get; private set; }

        // Создание отчета о школе
        public async Task MakeReport(string path)
        {
            // Вначале заполняем заголовок файла и заполняем список студентов и проходимся с помощью цикла,
            // если есть повторы, то заполняем данные в файл

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("             School Information              \n");

            sb.AppendLine("Class       Name            Second name     ");

            sb.AppendLine("");
            foreach (Student student in Students.OrderBy(x => x.Class.ToString()))
            {
                sb.AppendLine(
                    $"{student.Class.ToString().PadRight(12)}" +
                    $"{student.Name.PadRight(16)}" +
                    $"{student.Surname.PadRight(18)}");
            }
            sb.AppendLine("\n");

            /*Создается коллекция studentSurnames, содержащая только фамилии студентов, 
             извлеченные из свойства Surname каждого студента в списке Students.*/

            IEnumerable<string> studentSurnames = Students.Select(x => x.Surname);

            /*Вычисляется разница между общим количеством фамилий студентов и количеством уникальных фамилий.
             Если разница не равна нулю, это означает, что есть повторяющиеся фамилии среди студентов.*/

            int surnameDiff = studentSurnames.Count() - studentSurnames.Distinct().Count();
            if (surnameDiff != 0)
            {
                //Создается строка repeated, содержащая перечисление повторяющихся фамилий,
                //найденных с помощью группировки студентов по фамилии.
                string repeated = string.Join(", ",
                    Students.GroupBy(x => x.Surname)
                        .Where(g => g.Count() > 1)
                        .Select(y => y.Key));

                sb.Append($"The school has {surnameDiff + 1} namesakes: ");
                sb.AppendLine($"{repeated}");
            }
            /*Используя StreamWriter, отчет записывается в файл с помощью асинхронного метода WriteAsync,
             а затем вызывается FlushAsync, чтобы убедиться, что все данные записаны.*/

            using (StreamWriter sw = File.CreateText(path))
            {
                await sw.WriteAsync(sb.ToString());
                await sw.FlushAsync();
            }
        }
    }
}
