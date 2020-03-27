using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamGroup.Model;

namespace XamGroup.ViewModel
{
    public class AbsenceViewModel : INotifyPropertyChanged
    {

        private List<AbsenceModel> _listItems;
        public List<AbsenceModel> ListItems
        {
            get { return _listItems; }
            set
            {
                _listItems = value;
                OnPropertyChanged("ListItems");
            }
        }
        private AbsenceModel _itemTappedCommand;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public AbsenceModel ItemTappedCommand
        {
            get { return _itemTappedCommand; }
            set
            {
                _itemTappedCommand = value;
                if (_itemTappedCommand != null)
                {
                    SelectionExecute(_itemTappedCommand);
                    OnPropertyChanged("ItemTappedCommand");
                }
            }
        }

        public AbsenceViewModel()
        {
            ListItems = new List<AbsenceModel>();
            //var cellItem = new AbsenceModel()
            //{
            //    CheckIn = "8:40 am",
            //    Checkout = "12:30 pm"
            //};
            for (int i = 0; i <= 10; i++)
            {
                ListItems.Add(new AbsenceModel()
                {
                    CheckIn = "8:40 am",
                    Checkout = "12:30 pm"
                });
            }

        }

        private void SelectionExecute(AbsenceModel arg)
        {
            arg.Clicked = "Selected";
            foreach (var item in ListItems)
            {
                if (item.Clicked == "Selected")
                {
                    item.IsExpand = !item.IsExpand;
                    item.Clicked = string.Empty;
                }
                else
                {
                    item.Clicked = string.Empty;
                }
            }
        }
    }
}
