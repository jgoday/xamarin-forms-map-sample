using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;
using Xamarin.Forms.Maps.GTK;

namespace XMap.Gtk
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Gtk.Application.Init();
            Forms.Init();
            FormsMaps.Init();

            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("Sample");
            window.Show();
            Gtk.Application.Run();
        }
    }
}
