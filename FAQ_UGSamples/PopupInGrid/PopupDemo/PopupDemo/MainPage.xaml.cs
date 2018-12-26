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
            //dataGrid = new SfDataGrid();
            //viewModel = new ViewModel();
            //dataGrid.ItemsSource = viewModel.OrdersInfo;
            //dataGrid.GridTapped += DataGrid_GridTapped;
            //dataGrid.ColumnSizer = ColumnSizer.Star;
            //popupLayout = new SfPopupLayout();
            //popupLayout.PopupView.HeaderTitle = "Popup";
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

        private void DataGrid_GridTapped(object sender, Syncfusion.SfDataGrid.XForms.GridTappedEventArgs e)
        {
            // Popup is opened at the Grid tapped event
            popupLayout.Show();
        }
    }
}
