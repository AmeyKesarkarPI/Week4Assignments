using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace ex
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public ICommand SaveCommand { get; set; }
        public ICommand SortByCategoryCommand { get; set; }
        public ICommand SortByBrandCommand { get; set; }
        public ICommand SortByDateCommand { get; set; }
        public Product Product { get; set; }
        public Category SelectedCategories { get; set; }
        public Brand SelectedBrand { get; set; }


        public List<Category> Categories { get; set; } = new List<Category>();
        public List<Brand> Brands { get; set; } = new List<Brand>();
        public List<ManufactureDate> ManufactureDate { get; set; } = new List<ManufactureDate>();

        public List<Product> productsObservable { get; set; } = new List<Product>();

        public List<Item> ItemList { get; set; } = new List<Item>();
        public List<Item> ItemListClone { get; set; } = new List<Item>();

        public SolidColorBrush BrandsIsSelected
        {
            get
            {
                return brandsIsSelected;
            }
            set
            {
                brandsIsSelected = value;
                OnPropertyChanged(nameof(brandsIsSelected));
            }
        }

        private SolidColorBrush brandsIsSelected { get; set; }

        public SolidColorBrush CategoryIsSelected
        {
            get
            {
                return categoryIsSelected;
            }
            set
            {
                categoryIsSelected = value;
                OnPropertyChanged(nameof(categoryIsSelected));
            }
        }

        private SolidColorBrush categoryIsSelected { get; set; }

        public SolidColorBrush ManufactureDateIsSelected
        {
            get
            {
                return manufactureDateIsSelected;
            }
            set
            {
                manufactureDateIsSelected = value;
                OnPropertyChanged(nameof(manufactureDateIsSelected));
            }
        }

        private SolidColorBrush manufactureDateIsSelected {get;set;}


        public MainWindowViewModel()
        {
            Categories = new List<Category>() {
                new Category() {CategoryID = 1, CategoryName = "Toys" },
                new Category() {CategoryID = 2, CategoryName = "Home" },
                new Category() {CategoryID = 3, CategoryName = "Electronics" },
                new Category() {CategoryID = 4, CategoryName = "Leisure" },
                new Category() {CategoryID = 5, CategoryName = "Beverages" },
                new Category() {CategoryID = 6, CategoryName = "Utilities" },
                new Category() {CategoryID = 7, CategoryName = "Decor" },
                new Category() {CategoryID = 8, CategoryName = "Sports" },
                new Category() {CategoryID = 9, CategoryName = "Outdoor" },
                new Category() {CategoryID = 10, CategoryName = "Summer" },
            };

            Brands = new List<Brand>() {
                new Brand() {BrandID = 1, BrandName = "Hamleys" },
                new Brand() {BrandID = 2, BrandName = "Sunflower" },
                new Brand() {BrandID = 3, BrandName = "Sony" },
                new Brand() {BrandID = 4, BrandName = "Ikea" },
                new Brand() {BrandID = 5, BrandName = "Cola" },
                new Brand() {BrandID = 6, BrandName = "Hammer" },
                new Brand() {BrandID = 7, BrandName = "Balloon" },
                new Brand() {BrandID = 8, BrandName = "KG" },
                new Brand() {BrandID = 9, BrandName = "Sofa" },
                new Brand() {BrandID = 10, BrandName = "Max Fashion" },
            };

            Product = new Product(this);
            SaveCommand = new RelayCommand(SaveButton);
            SortByBrandCommand = new RelayCommand(SortByBrand);
            SortByCategoryCommand = new RelayCommand(SortByCategory);
            SortByDateCommand = new RelayCommand(SortByManufactureDate);
        }


        public void DeleteProduct()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public void SaveButton()
        {
            ManufactureDate.Add(new ManufactureDate()
            {
                Month = Product.MfgDate.Month,
                Year = Product.MfgDate.Year,
            });

            productsObservable.Add(new Product(this)
            {
                ProductName = Product.ProductName,
                MfgDate = Product.MfgDate,
                IsActive = Product.IsActive,
                CategoryName = SelectedCategories.CategoryName,
                BrandName = SelectedBrand.BrandName
            });

            ItemListClone.Clear();
            SolidColorBrush red = new SolidColorBrush(Colors.Red);
            if(CategoryIsSelected == null && BrandsIsSelected == null && ManufactureDateIsSelected == null)
            {
                SortByCategory();
            }
            else
            {
                if (CategoryIsSelected.Color == red.Color)
                {
                    SortByCategory();
                }
                else if (BrandsIsSelected.Color == red.Color)
                {
                    SortByBrand();
                }
                else if (ManufactureDateIsSelected.Color == red.Color)
                {
                    SortByManufactureDate();
                }
            }
            OnPropertyChanged("ItemList");

        }

        public void SortByManufactureDate()
        {
            BrandsIsSelected = new SolidColorBrush(Colors.LightGray);
            CategoryIsSelected = new SolidColorBrush(Colors.LightGray);
            ManufactureDateIsSelected = new SolidColorBrush(Colors.Red);
            ItemListClone.Clear();
            ManufactureDate = ManufactureDate.OrderBy(x => x.Year).OrderBy(x => x.Month).ToList();
            var StringDate = ManufactureDate.GroupBy(x => x.StringDate).Select(y => y.FirstOrDefault());
            foreach (var date in StringDate)
            {
                foreach (var prod in productsObservable)
                {
                    DateTime dates = new DateTime(prod.MfgDate.Year, prod.MfgDate.Month, 1);
                    string dateStr = dates.ToString("MMM, yyyy");
                    if (dateStr == date.StringDate)
                    {
                        ItemListClone.Add(date);
                        ItemListClone.Add(prod);
                    }
                }
            }
            ItemListClone.Distinct().ToList();
            ItemList = ItemListClone.Distinct().ToList();
            ItemList = ItemList.ToList();
            OnPropertyChanged("ItemList");
        }
        public void SortByCategory()
        {
            BrandsIsSelected = new SolidColorBrush(Colors.LightGray);
            CategoryIsSelected = new SolidColorBrush(Colors.Red);
            ManufactureDateIsSelected = new SolidColorBrush(Colors.LightGray);
            ItemListClone.Clear();
            Categories = Categories.OrderBy(x => x.CategoryName).ToList();
            foreach (var cat in Categories)
            {
                foreach (var prod in productsObservable)
                {
                    if (prod.CategoryName == cat.CategoryName)
                    {
                        ItemListClone.Add(cat);
                        ItemListClone.Add(prod);
                    }
                }

            }
            ItemList = ItemListClone.Distinct().ToList();
            ItemList = ItemList.ToList();
            OnPropertyChanged("ItemList");
        }

        public void SortByBrand()
        {
            BrandsIsSelected = new SolidColorBrush(Colors.Red);
            CategoryIsSelected = new SolidColorBrush(Colors.LightGray);
            ManufactureDateIsSelected = new SolidColorBrush (Colors.LightGray);
            ItemListClone.Clear();
            Brands = Brands.OrderBy(x => x.BrandName).ToList();
            foreach (var brand in Brands)
            {
                int count = 1;
                foreach (var prod in productsObservable)
                {
                    if (prod.BrandName == brand.BrandName)
                    {
                        if (count == 1)
                        {
                            ItemListClone.Add(brand);
                        }
                        ItemListClone.Add(prod);
                    }
                }

            }
            ItemList = ItemListClone.Distinct().ToList();
            ItemList = ItemList.ToList();
            OnPropertyChanged("ItemList");
        }


    }
}
