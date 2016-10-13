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
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace WPFapplication
{
    /// <summary>
    /// Created by vlad2572 12.10.2016
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Вызов диалогового окна - выбор каталога
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ChooseCatalog();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show("Нет доступа к данному каталогу");
            }
            
        }

        // Выбор каталога в файловой системе
        public void ChooseCatalog()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ListBoxDlls.Items.Clear();
                ListBoxTypes.Items.Clear();
                ListBoxContent.Items.Clear();
                TextBox1.Text = dialog.SelectedPath;
                DirectoryInfo dir = new DirectoryInfo(dialog.SelectedPath);

                foreach (var item in dir.GetFiles("*.dll"))
                {
                    ListBoxDlls.Items.Add(item);
                }
                if (dir.GetFiles("*.dll").Length == 0)
                {
                    MessageBoxResult result = System.Windows.MessageBox.Show("В каталоге нет dll файлов");
                }
            }
        }

        //кнопка "Закрыть приложение"
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //выбор dll файла из списка
        private void ListBoxDlls_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                FillTypesList(GetTypes(TextBox1.Text + ListBoxDlls.SelectedItem.ToString()));
            }
            catch (BadImageFormatException)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show("Содержимое dll файла не соответсвует ожидаемому");
                ListBoxTypes.Items.Clear();
                ListBoxContent.Items.Clear();
            } catch (FileNotFoundException)
            {
                MessageBoxResult result = System.Windows.MessageBox.Show("Нет доступа к dll файлу");
            } catch (NullReferenceException) { }

                  
        }

        //выбор Типа из содержащихся в dll файле
        private void ListBoxTypes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {       
            ListBoxContent.Items.Clear();
            try
            {
                FillContentWithFields(ReturnFields());
                FillContentWithMethods(ReturnMethods());
                FillContentWithProperties(ReturnProperties());
            }
            catch (NullReferenceException)
            {
                // ловим данный эксепшн, тем самым реализуя неограниченность выбора dll файлом и просмотра их содержимого
            }
            catch (BadImageFormatException)
            {
                // ловим данный эксепшн, тем самым реализуя неограниченность выбора dll файлом и просмотра их содержимого
                ListBoxTypes.Items.Clear();
                ListBoxContent.Items.Clear();
            }
        }

        //Получение содержимого сборки
        public Type[] GetTypes(string assemblyName)
        {
            Assembly assembly = Assembly.ReflectionOnlyLoadFrom(assemblyName);
                
            return assembly.GetTypes();
        }

        //Возврат Типов содержащихся в сборке
        public void FillTypesList(Type[] types)
        {
            ListBoxTypes.Items.Clear();
            ListBoxContent.Items.Clear();
            foreach (var item in types)
            {
                ListBoxTypes.Items.Add(item);
            }
        }

        //Возврат Методов содержащихся в Типе
        public MethodInfo[] ReturnMethods()
        {
            MethodInfo[] methods = null;
            foreach (var item in GetTypes(TextBox1.Text + ListBoxDlls.SelectedItem.ToString()))
            {
                if (item.ToString().Equals(ListBoxTypes.SelectedItem.ToString()))
                {
                    methods = item.GetMethods();
                }
            }
            return methods;
        }


        //Возврат Полей содержащихся в Типе
        public FieldInfo[] ReturnFields()
        {
            FieldInfo[] fields = null;
            foreach (var item in GetTypes(TextBox1.Text + ListBoxDlls.SelectedItem.ToString()))
            {
                if (item.ToString().Equals(ListBoxTypes.SelectedItem.ToString())) /// null reference
                {
                    fields = item.GetFields();
                }
                
            }
            return fields;
        }


        //Возврат Свойств содержащихся в Типе
        public PropertyInfo[] ReturnProperties()
        {
            PropertyInfo[] properties = null;
            foreach (var item in GetTypes(TextBox1.Text + ListBoxDlls.SelectedItem.ToString()))
            {
                if (item.ToString().Equals(ListBoxTypes.SelectedItem.ToString()))
                {
                    properties = item.GetProperties();
                }
            }
            return properties;
        }


        //Заполнение списка Методами Типа
        public void FillContentWithMethods(MethodInfo[] methods)
        {
            if (methods.Equals(null))
            {

            }
            else
            {
                ListBoxContent.Items.Add("------- Methods: -------");
                foreach (var method in methods)
                {
                    ListBoxContent.Items.Add(method);
                }
            }
                
        }


        //Заполнение списка Филдами Типа
        public void FillContentWithFields(FieldInfo[] fields)
        {
            if (fields.Equals(null))
            {

            }
            else
            {
                ListBoxContent.Items.Add("------- Fields: -------");
                foreach (var field in fields)
                {
                    ListBoxContent.Items.Add(field);
                }
            }
                
        }


        //Заполнение списка Свойствами Типа
        public void FillContentWithProperties(PropertyInfo[] properties)
        {
            if (properties.Equals(null))
            {

            }
            else
            {
                ListBoxContent.Items.Add(" ------- Properties: -------");
                foreach (var property in properties)
                {
                    ListBoxContent.Items.Add(property);
                }
            }
                
        }


        private void DisplayMethodsButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxContent.Items.Clear();
            FillContentWithMethods(ReturnMethods());
        }


        private void DisplayFieldsButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxContent.Items.Clear();
            FillContentWithFields(ReturnFields());
        }


        private void DisplayPropertiesButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxContent.Items.Clear();
            FillContentWithProperties(ReturnProperties());
        }


        private void DisplayAllButton_Click(object sender, RoutedEventArgs e)
        {
            ListBoxContent.Items.Clear();
            FillContentWithMethods(ReturnMethods());
            FillContentWithFields(ReturnFields());
            FillContentWithProperties(ReturnProperties());
        }
    }
}
