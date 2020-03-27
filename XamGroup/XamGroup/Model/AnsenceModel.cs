using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamGroup.Model
{
    public class AbsenceModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private bool _isCorrected;
        public bool IsCorrected
        {
            get { return _isCorrected; }
            set
            {
                _isCorrected = value;
                OnPropertyChanged("IsCorrected");
            }
        }
        private string _date;
        public string Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }
        private string _checkIn;
        public string CheckIn
        {
            get { return _checkIn; }
            set
            {
                _checkIn = value;
                OnPropertyChanged("CheckIn");
            }
        }
        private string _checkout;
        public string Checkout
        {
            get { return _checkout; }
            set
            {
                _checkout = value;
                OnPropertyChanged("Checkout");
            }
        }
        private string _apply;
        public string Apply
        {
            get { return _apply; }
            set
            {
                _apply = value;
                OnPropertyChanged("Apply");
            }
        }
        private bool _isExpand;
        public bool IsExpand
        {
            get { return _isExpand; }
            set
            {
                _isExpand = value;
                OnPropertyChanged("IsExpand");
            }
        }

        public ICommand ExpandCommand
        {
            get
            {
                return new Command((e) =>
                {
                    var item = (e as AbsenceModel);
                    // delete logic on item
                });
            }
        }
        private string _clicked;
        public string Clicked
        {
            get { return _clicked; }
            set
            {
                _clicked = value;
                OnPropertyChanged("Clicked");
            }
        }
    }
}
