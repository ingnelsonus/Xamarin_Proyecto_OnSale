using OnSale.Common.Entities;
using OnSale.Common.Responses;
using Onsalefaneus.Prism.Helpers;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Onsalefaneus.Prism.ViewModels
{
	public class ProductDetailPageViewModel : ViewModelBase
	{
        private readonly INavigationService _navigationService;
        private ObservableCollection<ProductImage> _images;
        private ProductResponse _product;

        public ProductDetailPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
            Title = Languages.Product;
        }

        public ObservableCollection<ProductImage> Images
        {
            get => _images;
            set => SetProperty(ref _images, value);
        }


        public ProductResponse Product
        {
            get => _product;
            set => SetProperty(ref _product, value);
        }

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

            if(parameters.ContainsKey("product"))
            {
                Product = parameters.GetValue<ProductResponse>("product");
                Title = Product.Name;
                Images = new ObservableCollection<ProductImage>(Product.ProductImages);
            }
        }
    }
}
