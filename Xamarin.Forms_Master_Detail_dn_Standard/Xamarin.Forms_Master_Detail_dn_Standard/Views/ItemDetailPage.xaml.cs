using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Xamarin.Forms_Master_Detail_dn_Standard.Models;
using Xamarin.Forms_Master_Detail_dn_Standard.ViewModels;

namespace Xamarin.Forms_Master_Detail_dn_Standard.Views
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