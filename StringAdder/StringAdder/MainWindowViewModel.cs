using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Navigation;

namespace StringAdder
{
    public class MainWindowViewModel : BaseViewModel
    {
        public ICommand AddButtonCommand { get; set; }
        public List<Item> Items { get; set; } = new List<Item>();
        //public Item NewItem { get; set; }  
        public Item SelectedItem { get; set; }

        public string DisplayString
        {
            get
            {
                return displayString;
            }
            set
            {
                List<String> content = new List<String>();
                for (int i = 0; i < Items.Count; i++)
                {
                    content.Add(Items[i].Content);
                }
                displayString = string.Join(", ", content);
                OnPropertyChanged(nameof(displayString));
            }
        }

        public string displayString { get;set ; }
        public MainWindowViewModel()
        {
            AddButtonCommand = new RelayCommand(AddButtonClick);
            SelectedItem = new Item(this);
        }

        public void AddButtonClick()
        {
            Items = Items.ToList();
            Items.Add(new Item(this)
            {
                Id = Items.Count(),
            });

            OnPropertyChanged(nameof(Items));
        }
    }
}
