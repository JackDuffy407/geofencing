using geofencing.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace geofencing.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}