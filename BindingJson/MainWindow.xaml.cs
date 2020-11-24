using Newtonsoft.Json.Linq;
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

namespace BindingJson
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //创建JObject
            //textfile1.txt存储着需要解析的JSON数据
            var jobj = JObject.Parse(System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\..\\..\\TestData.txt"));
            //创建TreeView的数据源
            treeView.ItemsSource = jobj.Children().Select(c => JsonHeaderLogic.FromJToken(c));
        }
    }
}
