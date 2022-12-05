# show-busy-indicator-while-loading-.net-maui-listview
How to show the busy indicator while loading the .NET MAUI ListView (SfListView) ?

 . NET MAUI ListView (SfListView) allows you to displaying the SfBusyIndicator while loading the bounded items. The busy indicator can be enabled and disabled by using IsRunning property.
XAML
Bind the value of ViewModel.IsLoading property to SfBusyIndicator.IsRunning property, to enable or disable busy indicator into the view until items loaded in the SfListView

<ContentPage xmlns:listview="clr-namespace:Syncfusion.Maui.ListView;assembly=Syncfusion.Maui.ListView"
             xmlns:busyIndicator="clr-namespace:Syncfusion.Maui.Core;assembly=Syncfusion.Maui.Core”>
  <Grid>
     <listview:SfListView x:Name="listView" 
                             ItemsSource="{Binding BookInfo}" 
                             ItemSize="110">
     </listview:SfListView>

     <busyIndicator:SfBusyIndicator x:Name="busyIndicator" 
                                       AnimationType="SingleCircle" 
                                       IsRunning="{Binding IsLoading, Mode=TwoWay}" 
                                       TextColor="Magenta"
                                       SizeFactor="0.5"/>
  </Grid>
</ContentPage>

C#
In behavior class set IsLoading property value to true and false based items generation using Loaded event.

public class Behavior:Behavior<ContentPage>
    {
        SfListView listView;
        BookInfoViewModel viewModel;
        protected override void OnAttachedTo(ContentPage bindable)
        {
            base.OnAttachedTo(bindable);
            listView = bindable.FindByName<SfListView>("listView");
            viewModel = new BookInfoViewModel();
            bindable.BindingContext = viewModel;
            listView.Loaded += ListView_LoadedAsync;

        }

        private async void ListView_LoadedAsync(object sender, ListViewLoadedEventArgs e)
        {
            viewModel.IsLoading = true;
            await Task.Delay(2000);
            viewModel.GenerateItems();
            if (listView.IsLoaded)
            {
                viewModel.IsLoading = false;
            }
        }

        protected override void OnDetachingFrom(ContentPage bindable)
        {
            base.OnDetachingFrom(bindable);
            listView = null;
            viewModel = null;
            listView.Loaded -= ListView_LoadedAsync;
        }
    }

Please take a moment to peruse the documentation to learn more about SfListView and its related operations with code examples.