using JsonBase64.ViewModel;
using Xamarin.Forms;

namespace JsonBase64
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel();
            BindingContext = new FotoViewModel();
        }
    }
}
