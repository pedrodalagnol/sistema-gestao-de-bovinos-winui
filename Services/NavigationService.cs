using Microsoft.UI.Xaml.Controls;
using System;

namespace SistemaGestaoDeBovinos.Services
{
    public static class NavigationService
    {
        public static Frame Frame { get; set; }

        public static void Navigate(Type page)
        {
            Frame?.Navigate(page);
        }
    }
}
