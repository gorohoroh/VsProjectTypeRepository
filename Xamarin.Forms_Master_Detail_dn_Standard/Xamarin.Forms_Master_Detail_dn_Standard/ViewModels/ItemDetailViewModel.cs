using System;

using Xamarin.Forms_Master_Detail_dn_Standard.Models;

namespace Xamarin.Forms_Master_Detail_dn_Standard.ViewModels
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
