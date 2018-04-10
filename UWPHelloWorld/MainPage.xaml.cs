using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPHelloWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<MyListItem> dataList;
        public MainPage()
        {
            this.InitializeComponent();
            this.InitializeList();
        }

        private void InitializeList()
        {
            dataList = new ObservableCollection<MyListItem>() { new MyListItem() { Name = "Hello World", Page = typeof(SubPages.HelloWorld) } };
            homeList.ItemsSource = dataList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MyListItem mli = dataList.Where(x => x.Name.Equals(((Button)sender).Content)).First();
            this.Frame.Navigate(mli.Page);
        }

        class MyListItem
        {
            public String Name { get; set; }

            public Type Page { get; set; }
        }
    }
}
