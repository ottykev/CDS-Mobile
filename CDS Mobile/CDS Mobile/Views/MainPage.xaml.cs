using CDS_Mobile.ViewModels;
using System.Runtime.CompilerServices;

namespace CDS_Mobile.Views
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}