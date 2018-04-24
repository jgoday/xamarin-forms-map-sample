using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XMap.Views
{
    public partial class MainView: MasterDetailPage
    {
        public MainView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);

            if (Device.RuntimePlatform == Device.WPF)
            {
                MasterBehavior = MasterBehavior.Popover;
            }
        }
    }
}