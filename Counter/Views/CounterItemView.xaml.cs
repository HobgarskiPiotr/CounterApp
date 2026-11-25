using Counter.Models;

namespace Counter.Views
{
    public partial class CounterItemView : ContentView
    {
        public CounterItemView()
        {
            InitializeComponent();
        }

        private void OnIncrementClicked(object sender, EventArgs e)
        {
            if (BindingContext is CounterModel counter)
            {
                counter.Value++;
            }
        }

        private void OnDecrementClicked(object sender, EventArgs e)
        {
            if (BindingContext is CounterModel counter)
            {
                counter.Value--;
            }
        }
    }
}