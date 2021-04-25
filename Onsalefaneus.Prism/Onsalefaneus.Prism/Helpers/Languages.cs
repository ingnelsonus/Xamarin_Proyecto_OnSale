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

        public static string Login => Resource1.Login;

        public static string ShowShoppingCar => Resource1.ShowShoppingCar;

        public static string ShowPurchaseHistory => Resource1.ShowPurchaseHistory;

        public static string ModifyUser => Resource1.ModifyUser;

        public static string Email => Resource1.Email;

        public static string EmailError => Resource1.EmailError;

        public static string EmailPlaceHolder => Resource1.EmailPlaceHolder;

        public static string Password => Resource1.Password;

        public static string PasswordError => Resource1.PasswordError;

        public static string PasswordPlaceHolder => Resource1.PasswordPlaceHolder;

        public static string ForgotPassword => Resource1.ForgotPassword;

        public static string LoginError => Resource1.LoginError;

        public static string Logout => Resource1.Logout;

        public static string LoginFirstMessage => Resource1.LoginFirstMessage;

        public static string Qualification => Resource1.Qualification;

        public static string Qualifications => Resource1.Qualifications;

        public static string QualificationNumber => Resource1.QualificationNumber;

        public static string Details => Resource1.Details;

        public static string RemarksPlaceHolder => Resource1.RemarksPlaceHolder;

        public static string QualificationError => Resource1.QualificationError;

        public static string NewQualification => Resource1.NewQualification;

        public static string Save => Resource1.Save;


    }

}
