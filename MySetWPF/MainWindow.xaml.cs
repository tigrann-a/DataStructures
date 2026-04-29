using MySetProject;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MySetWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MySet<Student> _math = new MySet<Student>();
        MySet<Student> _phys = new MySet<Student>();
        MySet<Student> _hist = new MySet<Student>();
        MySet<Student> _biol = new MySet<Student>();
        MySet<Student> _data = new MySet<Student>();
        MySet<Student> _prog = new MySet<Student>();

        MySet<Student> _men = new MySet<Student>();
        MySet<Student> _woman = new MySet<Student>();

        Dictionary<string, MySet<Student>> allSets = new Dictionary<string, MySet<Student>>();
        public MainWindow()
        {
            Student armen    = new Student(1, "Armen", Gender.Male);
            Student john     = new Student(4, "Armen", Gender.Male);
            Student george   = new Student(5, "Armen", Gender.Male);
            Student bob      = new Student(6, "Armen", Gender.Male);
            _men.AddRange(new Student[] {armen, john, george, bob});

            Student jennifer = new Student(7, "Armen", Gender.Female);
            Student armenuhi = new Student(2, "Armenuhi", Gender.Female);
            Student mareta = new Student(3, "Mareta", Gender.Female);
            _woman.AddRange(new Student[] { jennifer, armenuhi, mareta });
        }

        private void leftSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void rightSet_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}