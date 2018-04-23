using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Grid.LookUp;

namespace LookUpEditPopupContentTemplate
{
    public partial class MainPage : UserControl
    {
        ObservableCollection<Item> Items = new ObservableCollection<Item>();
        
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += MainPage_Loaded;
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 25; i++)
            {
                Item it = new Item() { ID = i, Name = "Name" + i.ToString(), ItemDate = DateTime.Now.AddDays(i) };
                Items.Add(it);     
            }            
            editor.ItemsSource = Items;
            
        }

    }

    public class Item {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ItemDate { get; set; }
    }



}
