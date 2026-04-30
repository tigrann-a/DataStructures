using MySetLib;
using System.Windows;
using System.Windows.Controls;

namespace MySetWPF;

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
        Student john     = new Student(2, "John", Gender.Male);
        Student george   = new Student(3, "George", Gender.Male);
        Student bob      = new Student(4, "Bob", Gender.Male);
        _men.AddRange(new Student[] {armen, john, george, bob});

        Student jennifer = new Student(5, "Jennifer", Gender.Female);
        Student armenuhi = new Student(6, "Armenuhi", Gender.Female);
        Student mareta   = new Student(7, "Mareta", Gender.Female);
        Student armine   = new Student(8, "Armine", Gender.Female);
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