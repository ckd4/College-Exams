using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ExamApplication
{
    public partial class MainWindow : Window
    {
        private School school;

        public MainWindow()
        {
            InitializeComponent();

            school = new School();
        }

        private void AddStudent(object sender, RoutedEventArgs e)
        {
            // Проверка пустых или Null значений во всех Текст-боксах
            if (
                string.IsNullOrEmpty(StudentNameTextBox.Text) || string.IsNullOrEmpty(StudentSurnameTextBox.Text) ||
                string.IsNullOrEmpty(StudentClassYearTextBox.Text) || string.IsNullOrEmpty(StudentClassLetterTextBox.Text))
            {
                MessageBox.Show("Incorrect Data", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                // Добавление информации о студентах в класс
                school.Students.Add(new Student
                {
                    Name = StudentNameTextBox.Text,
                    Surname = StudentSurnameTextBox.Text,
                    Class = new ClassName(Convert.ToInt32(StudentClassYearTextBox.Text), StudentClassLetterTextBox.Text)
                });
            }
            catch
            //Обработка на корректные данные при вводе информации о студентах
            {
                MessageBox.Show("Incorrect Data", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
        }
        // Создание отчета с повторяющими фамилиями
        private async void MakeReport(object sender, RoutedEventArgs e)
        {
            try
            {
                await school.MakeReport(ReportPathTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Очистка списка студентов из класса
        private void ClearStudents(object sender, RoutedEventArgs e)
        {
            school.Students.Clear();
        }
    }
}
