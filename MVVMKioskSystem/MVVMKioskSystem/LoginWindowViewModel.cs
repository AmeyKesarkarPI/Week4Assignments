using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace MVVMKioskSystem
{
    public class LoginWindowViewModel : BaseWindowViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICommand LoginCommand { get; set; }
        public LoginWindowEntity Login { get; set; }
        public MainWindowViewModel MainWindowViewModel { get; set; }
        
        public LoginWindowViewModel(MainWindowViewModel mainWindowViewModel)
        {
            LoginCommand = new RelayCommand(LoginUser);
            MainWindowViewModel = mainWindowViewModel;

        }

        public void LoginUser()
        {
            if (UserName != null && Password != null)
            {
                Login = new LoginWindowEntity();
                Agent agent = new Agent();
                agent.AgentName = UserName;
                agent.Password = Password;
                bool AgentSuccess = Login.AgentLogin(agent);

                Admin admin = new Admin();
                admin.AdminName = UserName;
                admin.Password = Password;
                bool AdminSuccess = Login.AdminLogin(admin);

                if(AgentSuccess)
                {
                    MainWindowViewModel.ActiveView = new AgentWindowViewModel(MainWindowViewModel);
                    MainWindowViewModel.OnPropertyChanged(nameof(MainWindowViewModel.ActiveView));
                }
                else if (AdminSuccess)
                {
                    //MainWindowViewModel m = new MainWindowViewModel(new AdminWindowViewModel());
                }
                else
                {
                    MessageBox.Show("Login Failed!!!");
                }
            }
            else
            {
                MessageBox.Show("Enter Correct Username and Password!!");
            }
        }
    }
}
