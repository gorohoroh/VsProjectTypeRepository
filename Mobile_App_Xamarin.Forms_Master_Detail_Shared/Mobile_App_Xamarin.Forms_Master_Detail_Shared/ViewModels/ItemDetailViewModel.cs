using System;

using Mobile_App_Xamarin.Forms_Master_Detail_Shared.Models;

namespace Mobile_App_Xamarin.Forms_Master_Detail_Shared.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
