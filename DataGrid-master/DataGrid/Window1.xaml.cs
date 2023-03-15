using System;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataGrid
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        public Teacher Teacher { get; set; }
      
        public Window1()
        {
            InitializeComponent();
           

        }
        public Teacher GetNewObject()
        {
            return new Teacher() { Name = "Новый предмет", ContactNumber = "Новый номер" };
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
            Teacher teacher = new Teacher()
            {
                Name = tb_fio.Text,
                ContactNumber = tb_number.Text
            };

            Teacher = teacher; 
            Close();

        }
      
    }

}
