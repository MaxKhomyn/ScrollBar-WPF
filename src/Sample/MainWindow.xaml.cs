using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Sample
{
    public partial class MainWindow : Window
    {
        private List<string> _items = new List<string>();
        List<string> ItemsCollection { get => _items; set => _items = value; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeItems();
        }

        private void InitializeItems()
        {
            for (int i = 1; i <= 100; i++)
            {
                ItemsCollection.Add($"Item #{i}");
            }
            ListBox.ItemsSource = ItemsCollection;
        }
    }
}
