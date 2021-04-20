﻿using OnSale.Common.Services;
using OnSale.Common.Entities;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Essentials;
using OnSale.Common.Responses;
using Onsalefaneus.Prism.ItemViewModels;

namespace Onsalefaneus.Prism.ViewModels
{
    public class ProductsPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private readonly IApiService _apiService;
        private ObservableCollection<ProductItemViewModel> _products;
        private bool _isRunning;
        private string _search;
        private List<ProductResponse> _myProducts;
        private int _cartNumber;
        private DelegateCommand _showCartCommand;
        private DelegateCommand _searchCommand;

        public ProductsPageViewModel(INavigationService navigationService,IApiService apiServices)
            :base(navigationService)
        {
            _navigationService = navigationService;
            Title = "Products";
            _apiService = apiServices;
            LoadProductsAsync();
        }

        public DelegateCommand SearchCommand => _searchCommand ?? (_searchCommand = new DelegateCommand(ShowProducts));


        public int CartNumber
        {
            get => _cartNumber;
            set => SetProperty(ref _cartNumber, value);
        }

        public string Search
        {
            get => _search;
            set
            {
                SetProperty(ref _search, value);
                ShowProducts();
            }
        }

        public bool IsRunning
        {
            get => _isRunning;
            set => SetProperty(ref _isRunning, value);
        }

        public ObservableCollection<ProductItemViewModel> Products 
        { 
            get =>_products;
            set =>SetProperty(ref _products,value); 
        }

        private async void LoadProductsAsync()
        {
            if(Connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Check the internet connection.", "Accept");
                return;
            }

            IsRunning = true;
            string url = App.Current.Resources["UrlAPI"].ToString();
            Response response = await _apiService.GetListAsync<ProductResponse>(url,"/api","/Products");
            IsRunning = false;

            if (!response.IsSuccess)
            {
                await App.Current.MainPage.DisplayAlert("Error",response.Message,"Accept");
                return;
            }

            _myProducts = (List<ProductResponse>)response.Result;
            ShowProducts();

        }

        private void ShowProducts()
        {
            if (string.IsNullOrEmpty(Search))
            {
                Products = new ObservableCollection<ProductItemViewModel>(_myProducts.Select(p => new ProductItemViewModel(_navigationService)
                {
                    Category = p.Category,
                    Description = p.Description,
                    Id = p.Id,
                    IsActive = p.IsActive,
                    IsStarred = p.IsStarred,
                    Name = p.Name,
                    Price = p.Price,
                    ProductImages = p.ProductImages,
                    Qualifications = p.Qualifications
                })
                    .ToList());
            }
            else
            {
                Products = new ObservableCollection<ProductItemViewModel>(_myProducts.Select(p => new ProductItemViewModel(_navigationService)
                {
                    Category = p.Category,
                    Description = p.Description,
                    Id = p.Id,
                    IsActive = p.IsActive,
                    IsStarred = p.IsStarred,
                    Name = p.Name,
                    Price = p.Price,
                    ProductImages = p.ProductImages,
                    Qualifications = p.Qualifications
                })
                    .Where(p => p.Name.ToLower().Contains(Search.ToLower()))
                    .ToList());
            }
        }


    }
}