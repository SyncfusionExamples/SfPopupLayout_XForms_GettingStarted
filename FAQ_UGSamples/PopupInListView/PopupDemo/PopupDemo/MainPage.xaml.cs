using Syncfusion.ListView.XForms;
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
        //SfListView listView;
        //ContactsViewModel viewModel;
        //SfPopupLayout popupLayout;

        public MainPage()
        {
            InitializeComponent();
            //listView = new SfListView() { ItemSpacing = 5 };
            //listView.ItemTemplate = new DataTemplate(() =>
            //{
            //    ViewCell viewCell = new ViewCell();
            //    var grid = new Grid() { RowSpacing = 1 };
            //    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 50 });
            //    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 200 });
            //    grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = 50 });
            //    var contactImage = new Image()
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        HorizontalOptions = LayoutOptions.Center,
            //        HeightRequest = 50
            //    };
            //    contactImage.SetBinding(Image.SourceProperty, new Binding("ContactImage"));
            //    var contactName = new Label()
            //    {
            //        HorizontalTextAlignment = TextAlignment.Center,
            //        LineBreakMode = LineBreakMode.NoWrap,
            //        FontSize = Font.SystemFontOfSize(NamedSize.Medium).FontSize,
            //    };
            //    contactName.SetBinding(Label.TextProperty, new Binding("ContactName"));
            //    var contactType = new Image()
            //    {
            //        VerticalOptions = LayoutOptions.End,
            //        HorizontalOptions = LayoutOptions.End,
            //        HeightRequest = 50,
            //    };
            //    contactType.SetBinding(Image.SourceProperty, new Binding("ContactType"));
            //    grid.Children.Add(contactImage,0,0);
            //    grid.Children.Add(contactName,1,0);
            //    grid.Children.Add(contactType,2,0);
            //    viewCell.View = grid;
            //    return viewCell;
            //});
            //viewModel = new ContactsViewModel();
            //listView.ItemsSource = viewModel.Items;
            //listView.SelectionMode = SelectionMode.None;
            //listView.ItemTapped += ListView_ItemTapped;
            //popupLayout = new SfPopupLayout();
            //popupLayout.PopupView.HeightRequest = 120;
            //popupLayout.PopupView.WidthRequest = 220;
            //popupLayout.PopupView.ShowFooter = false;
            //popupLayout.PopupView.ContentTemplate = new DataTemplate(() =>
            //{
            //    return new Label()
            //    {
            //        Text = "ListView item is tapped",
            //        BackgroundColor = Color.White,
            //        TextColor = Color.Black,
            //        HorizontalTextAlignment = TextAlignment.Center
            //    };
            //});
            //popupLayout.Content = listView;
            //this.Content = popupLayout;
        }

        private void ListView_ItemTapped(object sender, Syncfusion.ListView.XForms.ItemTappedEventArgs e)
        {
            popupLayout.Show();
        }
    }
}
