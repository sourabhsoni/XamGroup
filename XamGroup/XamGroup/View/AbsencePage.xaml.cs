using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamGroup.ViewModel;

namespace XamGroup.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AbsencePage : ContentPage
    {
        public AbsencePage()
        {
            InitializeComponent();
            this.BindingContext = new AbsenceViewModel();
        }
    }
}