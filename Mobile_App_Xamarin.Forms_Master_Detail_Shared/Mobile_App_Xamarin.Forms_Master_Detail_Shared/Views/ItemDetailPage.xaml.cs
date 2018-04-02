using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Mobile_App_Xamarin.Forms_Master_Detail_Shared.Models;
using Mobile_App_Xamarin.Forms_Master_Detail_Shared.ViewModels;

namespace Mobile_App_Xamarin.Forms_Master_Detail_Shared.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ItemDetailPage : ContentPage
	{
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Item
            {
                Text = "Item 1",
                Description = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }
    }
}