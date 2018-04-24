using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XMap.Views
{
    using Models;
    using Services;

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MapView : ContentPage
    {
        private MainModel _model;

        public MapView()
        {
            InitializeComponent();

            _model = new MainModel();
            BindingContext = _model;
            NavigationPage.SetHasNavigationBar(this, false);

            MyMap.DoubleClick += async (o, e) =>
            {
                var service = DependencyService.Get<ICadastralService>();
                var res = await service.FindCadastralReference(
                    e.Position.Latitude,
                    e.Position.Longitude);
                // _model.Text = $"Lat = {e.Position.Latitude}, Lon = {e.Position.Longitude}";_model.Text = $"Lat = {e.Position.Latitude}, Lon = {e.Position.Longitude}";
                _model.Text = res;
            };
        }
    }
}