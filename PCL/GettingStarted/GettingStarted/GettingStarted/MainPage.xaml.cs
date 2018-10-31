using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GettingStarted
{
    public partial class MainPage : ContentPage
    {
        DataTemplate templateView;
        Label popupContent;
        public MainPage()
        {
            InitializeComponent();

            // Set the required content template

            // templateView = new DataTemplate(() =>
            // {
            //    popupContent = new Label();
            //    popupContent.Text = "This is the Customized view for SfPopupLayout";
            //    popupContent.BackgroundColor = Color.LightSkyBlue;
            //    popupContent.HorizontalTextAlignment = TextAlignment.Center;
            //    return popupContent;
            // });
            // popupLayout.PopupView.ContentTemplate = templateView;

            // Set the desired AnimationMode
            // popupLayout.PopupView.AnimationMode = AnimationMode.None;

            // Set the desired AppearanceMode
            // popupLayout.PopupView.AppearanceMode = Syncfusion.XForms.PopupLayout.AppearanceMode.TwoButton;

            clickToShowPopup.Clicked += ClickToShowPopup_Clicked;
        }

        private void ClickToShowPopup_Clicked(object sender, EventArgs e)
        {
            popupLayout.IsOpen = true;

            // Shows SfPopupLayout at the center.
            //popupLayout.Show();

            // Shows SfPopupLayout at the specified X and y position.
            //popupLayout.Show(100, 100);

            // Shows SfPopupLayout at the touch point.
            //popupLayout.ShowAtTouchPoint();

            // Shows SfPopupLayout at the position relative to the specified view.
            //popupLayout.ShowRelativeToView(label, RelativePosition.AlignBottom);
        }
    }
}
