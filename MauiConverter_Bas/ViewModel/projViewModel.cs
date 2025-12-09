using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiConverter_Bas.Model;
using MauiConverter_Bas.View;

namespace MauiConverter_Bas.ViewModel
{
    public partial class projViewModel:ObservableObject
    {
        public ObservableCollection<projModel> Categories { get; }

        public projViewModel()
        {
            // The dark purple background color used in your design
            var darkPurple = Color.FromArgb("#320E60");
            var darkPurpleAlt = Color.FromArgb("#190730"); // Slightly darker for contrast

            // Initialize the list of categories
            Categories = new ObservableCollection<projModel>
            {
                new projModel { Name = "Information", Icon = "\uf1c0", NavigationTarget = nameof(ConversionPage), BackgroundColor = darkPurple },
                new projModel { Name = "Volume", Icon = "\uf49e", NavigationTarget = nameof(ConversionPage), BackgroundColor = darkPurpleAlt },
                new projModel { Name = "Length", Icon = "\uf543", NavigationTarget = nameof(ConversionPage), BackgroundColor = darkPurple },

                new projModel { Name = "Mass", Icon = "\uf496", NavigationTarget = nameof(ConversionPage), BackgroundColor = darkPurpleAlt },
                new projModel { Name = "Temperature", Icon = "\uf2c9", NavigationTarget = nameof(ConversionPage), BackgroundColor = darkPurple },
                new projModel { Name = "Energy", Icon = "\uf06d", NavigationTarget = nameof(ConversionPage), BackgroundColor = darkPurpleAlt },

                new projModel { Name = "Area", Icon = "\uf201", NavigationTarget = nameof(ConversionPage), BackgroundColor = darkPurple },
                new projModel { Name = "Speed", Icon = "\uf1e3", NavigationTarget = nameof(ConversionPage), BackgroundColor = darkPurpleAlt },
                new projModel { Name = "Duration", Icon = "\uf2f2", NavigationTarget = nameof(ConversionPage), BackgroundColor = darkPurple }
            };

           
            Routing.RegisterRoute(nameof(ConversionPage), typeof(ConversionPage));
        }

       
        [RelayCommand]
        private async Task NavigateToConversion(projModel category)
        {
            if (category != null)
            {

                await Shell.Current.GoToAsync($"{category.NavigationTarget}?category={category.Name}");
            }
        }
    }
}
