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

        public static string Register => Resource1.Register;

        public static string Document => Resource1.Document;

        public static string DocumentError => Resource1.DocumentError;

        public static string DocumentPlaceHolder => Resource1.DocumentPlaceHolder;

        public static string FirstName => Resource1.FirstName;

        public static string FirstNameError => Resource1.FirstNameError;

        public static string FirstNamePlaceHolder => Resource1.FirstNamePlaceHolder;

        public static string LastName => Resource1.LastName;

        public static string LastNameError => Resource1.LastNameError;

        public static string LastNamePlaceHolder => Resource1.LastNamePlaceHolder;

        public static string Address => Resource1.Address;

        public static string AddressError => Resource1.AddressError;

        public static string AddressPlaceHolder => Resource1.AddressPlaceHolder;

        public static string Phone => Resource1.Phone;

        public static string PhoneError => Resource1.PhoneError;

        public static string PhonePlaceHolder => Resource1.PhonePlaceHolder;

        public static string City => Resource1.City;

        public static string CityError => Resource1.CityError;

        public static string CityPlaceHolder => Resource1.CityPlaceHolder;

        public static string Department => Resource1.Department;

        public static string DepartmentError => Resource1.DepartmentError;

        public static string DepartmentPlaceHolder => Resource1.DepartmentPlaceHolder;

        public static string Country => Resource1.Country;

        public static string CountryError => Resource1.CountryError;

        public static string CountryPlaceHolder => Resource1.CountryPlaceHolder;

        public static string PasswordConfirm => Resource1.PasswordConfirm;

        public static string PasswordConfirmError1 => Resource1.PasswordConfirmError1;

        public static string PasswordConfirmError2 => Resource1.PasswordConfirmError2;

        public static string PasswordConfirmPlaceHolder => Resource1.PasswordConfirmPlaceHolder;

        public static string Error001 => Resource1.Error001;

        public static string Error002 => Resource1.Error002;

        public static string Error003 => Resource1.Error003;

        public static string Error004 => Resource1.Error004;

        public static string Ok => Resource1.Ok;

        public static string RegisterMessge => Resource1.RegisterMessge;

        public static string PictureSource => Resource1.PictureSource;

        public static string Cancel => Resource1.Cancel;

        public static string FromCamera => Resource1.FromCamera;

        public static string FromGallery => Resource1.FromGallery;

        public static string NoCameraSupported => Resource1.NoCameraSupported;

        public static string NoGallerySupported => Resource1.NoGallerySupported;


    }

}
