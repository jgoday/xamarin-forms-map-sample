using Xamarin.Forms.Platform.WPF;

namespace XMap.WPF
{
    public partial class MainWindow : FormsApplicationPage
    {
        public MainWindow()
        {
            InitializeComponent();
            Xamarin.Forms.Forms.Init();
            Xamarin.FormsMaps.Init("AooDfbidciPLTzASsvnQdvvqMUHwBzcpWNoRA4sjNAKziV8kNq1MhxIWTsUZXRFG");
            XMap.XMapServices.Init();


            LoadApplication(new XMap.App());
        }
    }
}