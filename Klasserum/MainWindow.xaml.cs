using Klasserum.entities;
using Klasserum.Data;
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

namespace Klasserum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classroom> ClassroomList = new List<Classroom>();
        private DataList data = new DataList();
        private Classroom classroom = new Classroom();

        public MainWindow()
        {
            InitializeComponent();
            ClassroomList = data.ClassroomList();
            ClassroomCombo.ItemsSource = ClassroomList;
            
        }

        private void ClassroomCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            classroom = ClassroomCombo.SelectedItem as Classroom;
            if (classroom.Teacher == null)
            {
                classroom.Teacher = new Teacher("Dummy", "Person", new List<string>() { "dummy text" });
            }
            if (classroom.Subject == null)
            {
                classroom.Subject = "No subject!";
            }
            lblTeacher.Content = classroom.Teacher.Fullname;
            lblSubject.Content = classroom.Subject;
            lstStudents.ItemsSource = classroom.Students;
        }
    }
}
