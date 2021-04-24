using OnSale.Common.Helpers;
using Onsalefaneus.Prism.Resources;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Onsalefaneus.Prism.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            CultureInfo ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource1.Culture = ci;
            Culture = ci.Name;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Culture { get; set; }

        public static string Accept => Resource1.Accept;

        public static string ConnectionError => Resource1.ConnectionError;

        public static string Error => Resource1.Error;
        public static string Loading => Resource1.Loading;

        public static string SearchProduct => Resource1.SearchProduct;

        public static string Name => Resource1.Name;

        public static string Description => Resource1.Description;

        public static string Price => Resource1.Price;

        public static string Category => Resource1.Category;

        public static string IsStarred => Resource1.IsStarred;

        public static string AddToCart => Resource1.AddToCart;

        public static string Product => Resource1.Product;

        public static string Products => Resource1.Products;

    }

}
