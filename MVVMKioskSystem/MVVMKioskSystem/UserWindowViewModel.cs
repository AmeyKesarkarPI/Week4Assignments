using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMKioskSystem
{
    public class UserWindowViewModel : BaseWindowViewModel
    {

        public UserWindowViewModel()
        {
            PageName = "User";
            OnPropertyChanged(nameof(PageName));
        }
    }
}
