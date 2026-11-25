using System.Collections.ObjectModel;
using Counter.Models;

namespace Counter
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<CounterModel> Counters { get; set; } = new();

        public MainPage()
        {
            InitializeComponent();
            CountersCollectionView.ItemsSource = Counters;
        }

        private void OnAddCounterClicked(object sender, EventArgs e)
        {
            string name = string.IsNullOrWhiteSpace(NameEntry.Text) ? "Licznik" : NameEntry.Text;

            Counters.Add(new CounterModel
            {
                Name = name,
                Value = 0
            });

            NameEntry.Text = string.Empty;
        }
    }
}