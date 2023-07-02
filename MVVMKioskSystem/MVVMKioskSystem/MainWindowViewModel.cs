using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMKioskSystem
{
    public class MainWindowViewModel : BaseWindowViewModel
    {
        public string FileContent { get; set; }
        public BaseWindowViewModel ActiveView { get; set; }
        public bool UserType
        {
            get
            {
                if(FileContent == "Kiosk")
                {
                    return true;
                }else
                {
                    return false;
                }
            }
        }
        public MainWindowViewModel()
        {
            ReadFile();
            if (UserType == true)
            {
                ActiveView = new UserWindowViewModel();
            }
            else
            {
                ActiveView = new LoginWindowViewModel(this);
            }
        }

        public void ReadFile()
        {
            string Path = "C:\\Users\\Amey.Kesarkar\\source\\repos\\MVVMKioskSystem\\MVVMKioskSystem\\Resources\\Config.txt";

            if(File.Exists(Path))
            {
                string str = File.ReadAllText(Path);
                int n = str.IndexOf('=');
                FileContent = str.Substring(n+1).Trim();
            }
        }

    }
}
