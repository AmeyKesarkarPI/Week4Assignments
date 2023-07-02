using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StringAdder
{
    public class Item
    {
        public string Content
        {
            get
            {
                return content;
            } set
            {
                content = value;
                ViewModel.DisplayString = value;
            }
        }
        private string content { get; set; }
        public int Id { get; set; }

        public ICommand DeleteButtonCommand { get; set; }
        public Item GetItem
        {
            get
            {
                return this;
            }
        }
        //public Item GetItem
        //{
        //    get
        //    {
        //        return new 
        //    }; set;
        //}

        MainWindowViewModel ViewModel { get; set; }

        public Item(MainWindowViewModel viewModel)
        {
            DeleteButtonCommand = new RelayCommand(DeleteButtonClick);
            ViewModel = viewModel;
        }


        public void DeleteButtonClick()
        {
            //ViewModel.Items;
            Item i = GetItem;

            ViewModel.Items.Remove(i);
            ViewModel.Items = ViewModel.Items.ToList();


            List<String> content = new List<String>();
            for (int j = 0; j < ViewModel.Items.Count; j++)
            {
                content.Add(ViewModel.Items[j].Content);
            }
            ViewModel.displayString = string.Join(", ", content);
            ViewModel.OnPropertyChanged(nameof(ViewModel.displayString));
            ViewModel.OnPropertyChanged(nameof(ViewModel.Items));
        }
    }
}
