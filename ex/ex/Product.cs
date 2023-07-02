using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Markup;

namespace ex
{
    public class Product : Item
    {
        public string ProductName { get; set; }
        public bool IsActive { get; set; }
        public DateTime MfgDate { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public bool EditProductButton { get; set; }
        public ICommand EditProductCommand { get; set; }
        public ICommand DeleteProductCommand { get; set; }
        private MainWindowViewModel ViewModel { get; set; }

        public Product(MainWindowViewModel mainWindowViewModel)
        {
            ViewModel = mainWindowViewModel;
            EditProductCommand = new RelayCommand(EditProduct);
            DeleteProductCommand = new RelayCommand(ViewModel.DeleteProduct);
        }

        private void EditProduct()
        {
            Console.WriteLine(this);
            ViewModel.Product = this;
            ViewModel.Product.CategoryName = this.CategoryName;

            ViewModel.Product.BrandName = this.BrandName;
            ViewModel.OnPropertyChanged(nameof(ViewModel.Product.CategoryName));
            ViewModel.OnPropertyChanged(nameof(ViewModel.Product.BrandName));   
            ViewModel.OnPropertyChanged(nameof(ViewModel.Product));
        }

        public string SaveVisible
        {
            get
            {
                if (EditProductButton == true)
                {
                    return "Hidden";
                }
                else
                {
                    return "Visible";
                }
            }
        }

        public string UpdateVisible
        {
            get
            {
                if (EditProductButton == true)
                {
                    return "Visible";
                }
                else
                {
                    return "Hidden";
                }
            }
        }

        public string ActiveStatus
        {
            get
            {
                if (IsActive == false)
                {
                    return "InActive";

                }
                else
                {
                    return "Active";
                }
            }
        }

        public string MfgDateStr
        {
            get
            {
                return MfgDate.ToString("dd/MM/yyyy");
            }
        }



        public string ExpDateStr
        {
            get
            {
                DateTime exp = MfgDate.AddMonths(6);
                return exp.ToString("dd/MM/yyyy");
            }
        }

        public string BorderColor
        {
            get
            {
                if (IsActive == true)
                {
                    return "Green";
                }
                else
                {
                    return "Red";
                }
            }
        }
    }
}
