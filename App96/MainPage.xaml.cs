using System.Linq;
using System.Reflection;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App96
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MissingMethod_OnClick(object sender, RoutedEventArgs e)
        {
            var typeInfo = typeof (Windows.UI.Xaml.Controls.ContentControl).GetTypeInfo();
            var customAttributes = typeInfo.CustomAttributes;

            var contentProperty = customAttributes.FirstOrDefault(a => a.AttributeType == typeof(ContentPropertyAttribute));
        }
    }
}
