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
using System.Collections;
using System.Collections.ObjectModel;

namespace Taski
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> _Task;
        ObservableCollection<string> _TaskDone;
        public MainWindow()
        {
            InitializeComponent();
            _TaskDone = new ObservableCollection<string>();
            TaskDone.ItemsSource = _TaskDone;
            _Task = new ObservableCollection<string> { };
            Task.ItemsSource = _Task;
            textBox1.Text = "";
        }

        private void TaskAdd_Click(object sender, RoutedEventArgs e)
        {
            string text = textBox1.Text;
            _Task.Add(text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введеите задачу");
            }
        }
        private void Task_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (TaskDone.SelectedIndex != -1)
            {
                _TaskDone.RemoveAt(TaskDone.SelectedIndex);
            }
        }

        private void Task_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            string del = Task.SelectedItem.ToString();
            _Task.RemoveAt(Task.SelectedIndex);
            _TaskDone.Add(del);
        }
    }
}
