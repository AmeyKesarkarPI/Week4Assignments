using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMKioskSystem
{
    public class BulkSearchViewModel : BaseWindowViewModel
    {
        MainWindowViewModel MainWindow { get; set; }
        public BulkSearchViewModel(MainWindowViewModel mainWindow)
        {
            PageName = "Bulk Search";
            MainWindow = mainWindow;
        }
    }
}
