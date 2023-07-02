using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MVVMKioskSystem
{
    public class TokenSearchViewModel : BaseWindowViewModel
    {
        MainWindowViewModel MainWindow { get; set; }
        public string Token { get; set; }
       
        public TokenSearchViewModel(MainWindowViewModel mainWindow)
        {
            PageName = "Token Search";
            MainWindow = mainWindow;
        }
    }
}
