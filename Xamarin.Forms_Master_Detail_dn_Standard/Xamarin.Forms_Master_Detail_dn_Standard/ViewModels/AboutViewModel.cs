﻿using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Xamarin.Forms_Master_Detail_dn_Standard.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}