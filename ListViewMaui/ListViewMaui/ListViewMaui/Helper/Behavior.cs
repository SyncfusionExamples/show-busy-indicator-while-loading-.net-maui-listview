using Microsoft.Maui.Controls;
using Syncfusion.Maui.ListView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewMaui
{
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
}
