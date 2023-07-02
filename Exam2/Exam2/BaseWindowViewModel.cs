using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exam2
{
    public class BaseWindowViewModel : INotifyPropertyChanged
    {
        public string PageName { get; set; }
        public ICommand NavigateCommand { get; set; }
        public BaseWindowViewModel BasePage
        {
            get
            {
                return basePage;
            }
            set
            {
                BasePage = value;
            }
        }

        private BaseWindowViewModel basePage { get; set; }

        MainWindowViewModel MainWindowViewModel { get; set; } 

        public BaseWindowViewModel()
        {
            PageName = "Base Window";
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
