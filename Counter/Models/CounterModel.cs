using System.ComponentModel;

namespace Counter.Models
{
    public class CounterModel : INotifyPropertyChanged
    {
        private int _value;

        public string Name { get; set; } = string.Empty;

        public int Value
        {
            get => _value;
            set
            {
                if (_value != value)
                {
                    _value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}