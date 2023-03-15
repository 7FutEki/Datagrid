﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Teacher> _data;


        public MainWindow()
        {
            InitializeComponent();
            _data = new ObservableCollection<Teacher>();
            dt_grid.ItemsSource = _data;
            var win = new Window1();
            win.ShowDialog();
            var s = win.Teacher;


            MessageBox.Show(s.Name);
            _data.Add(s);

            var new_object = win.GetNewObject();
            _data.Add(new_object);
        }

        private void btn_del_Click(object sender, RoutedEventArgs e)
        {
            var s = (e.OriginalSource as Button).DataContext;
            Teacher current = (Teacher)s;
            _data.Remove(current);
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Window1 about = new Window1();
            about.Show();

           
        }
    }
    public class Teacher
    {
        public string Name { get; set; }
        public string ContactNumber { get; set; }
    }
}
