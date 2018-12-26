using Syncfusion.SfDataGrid.XForms;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PopupDemo
{
    public partial class MainPage : ContentPage
    {
        //SfDataGrid dataGrid;
        //ViewModel viewModel;
        //SfPopupLayout popupLayout;

        public MainPage()
        {
            InitializeComponent();

            //Comment the xaml page content and uncomment the below code to get the same output in code behind

            //dataGrid = new SfDataGrid();
            //viewModel = new ViewModel();
            //// Set the ItemsSource for the SfDataGrid for loading the items.
            //dataGrid.ItemsSource = viewModel.OrdersInfo;
            //// Hook the GridTapped event, to display popup when an item in Grid is tapped.
            //dataGrid.GridTapped += DataGrid_GridTapped;
            //dataGrid.ColumnSizer = ColumnSizer.Star;
            //popupLayout = new SfPopupLayout();
            //// Set the HeaderTitle of the popup.
            //popupLayout.PopupView.HeaderTitle = "Popup";
            //// Load any view as the Template to show in Popup.
            //popupLayout.PopupView.ContentTemplate = new DataTemplate(() =>
            //{
            //    return new Label()
            //    {
            //        Text = "A pop-up is a graphical user interface display area that suddenly appears in the foreground of the visual interface. Pop-up can be initiated by single or double tap or can simply be timed to occur. A pop-up window should be smaller than the background window or interface; otherwise, its a replacement interface.",
            //        BackgroundColor = Color.White,
            //        TextColor = Color.Black
            //    };
            //});
            //popupLayout.Content = dataGrid;
            //this.Content = popupLayout;
        }

        private void DataGrid_GridTapped(object sender, GridTappedEventArgs e)
        {
            // Popup is opened at the Grid tapped event
            popupLayout.Show();
        }
    }
}
