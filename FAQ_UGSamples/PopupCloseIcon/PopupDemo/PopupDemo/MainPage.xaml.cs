using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();            
        }

        private void isOpenButton_Clicked(object sender, EventArgs e)
        {
            popupLayout.Show();
        }
    }

    public class CustomStyle : PopupStyle
    {
        public CustomStyle()
        {
            this.CloseButtonIcon = ImageSource.FromResource("PopupDemo.Images.RedDown.png");
        }
    }
}
