using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVMKioskSystem
{
    public class AgentWindowViewModel : BaseWindowViewModel
    {
        public ICommand MoveToCommand { get; set; }
        public List<BaseWindowViewModel> AgentViewModels { get; set; }
        MainWindowViewModel MainWindowViewModel { get; set; }

        public BaseWindowViewModel SelectedAgentViewModel { get; set; }

        public AgentWindowViewModel(MainWindowViewModel viewModel)
        {
            MainWindowViewModel = viewModel;
            AgentViewModels = new List<BaseWindowViewModel>();
            AgentViewModels.Add(new TokenSearchViewModel(MainWindowViewModel));
            AgentViewModels.Add(new BulkSearchViewModel(MainWindowViewModel));
            MoveToCommand = new RelayCommand(MoveTo);
        }

        public void MoveTo()
        {
            MainWindowViewModel.ActiveView = SelectedAgentViewModel;
            MainWindowViewModel.OnPropertyChanged(nameof(MainWindowViewModel.ActiveView));
        }
    }
}
