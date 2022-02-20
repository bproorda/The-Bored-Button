using System.ComponentModel;
using TheBoredButton.ViewModels;
using Xamarin.Forms;

namespace TheBoredButton.Views
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