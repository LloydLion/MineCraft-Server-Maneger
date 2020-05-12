using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MineCraft_Server_Maneger.Models
{
    class ServerStade : INotifyPropertyChanged
    {
        private bool isRunnning;
        private bool isSelected;

        public bool IsRunnning { get => isRunnning; set { isRunnning = value; OnPropertyChanged(); } }
        public bool IsSelected { get => isSelected; set { isSelected = value; OnPropertyChanged(); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string caller = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(caller));
        }

        public void InvokeEventPropertyChanged()
        {
            OnPropertyChanged("null");
        }
    }
}