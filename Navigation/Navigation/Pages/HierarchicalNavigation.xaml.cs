﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Navigation.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HierarchicalNavigation : ContentPage
    {
        public HierarchicalNavigation()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

    }
}