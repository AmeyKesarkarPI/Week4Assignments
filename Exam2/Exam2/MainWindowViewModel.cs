using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Exam2
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public List<BaseWindowViewModel> Pages { get; set; }
        public ICommand NavigateCommand { get; set; }
        public BaseWindowViewModel SelectedPage { get; set; } = new
            BaseWindowViewModel();
        public BaseWindowViewModel ActiveView
        {
            get
            {
                return SelectedPage.BasePage;
            }
            set
            {
                activeView = value;
                OnPropertyChanged(nameof(ActiveView));  
            }
        }

        private BaseWindowViewModel activeView { get; set; }

        public MainWindowViewModel()
        {
            Pages = new List<BaseWindowViewModel>();
            Pages.Add(new HomeViewModel());
            Pages.Add(new AboutViewModel());
            Pages.Add(new GalleryViewModel());
            NavigateCommand = new RelayCommand(NavigateTo);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NavigateTo()
        {
            ActiveView = SelectedPage;
        }

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }


    }
}
