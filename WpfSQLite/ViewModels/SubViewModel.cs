using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using WpfSQLite.Models;

namespace WpfSQLite.ViewModels
{
    public class SubViewModel : ViewModelBase, IParameterReceiver
    {
        private readonly ModelContext? _context;
        private IList<Category> _categoryList;
        private IList<Product> _productList;

        public SubViewModel(ModelContext context)
        {
            _context = context;
        }

        public SubData SubData { get; set; } = default!;
        public IList<Product> ProductList 
        {
            get { return _productList; }
            set { SetProperty(ref _productList, value); }
        }
        public IList<Category> CategoryList 
        { 
            get { return _categoryList; }
            set { SetProperty(ref _categoryList, value); }
        }

        public void ReceiveParameter(object parameter)
        {
            if (parameter is SubData subData)
            {
                SubData = subData;
            }
        }

        private void ConnectDB(object? obj)
        {
            try
            {
                if (_context != null)
                {
                    _context.Database.EnsureCreated();

                    _context.Products.Load();
                    ProductList = _context.Products.Local.ToList();

                    _context.Categories.Load();
                    CategoryList = _context.Categories.Local.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}{Environment.NewLine}{ex.Source}");
                throw;
            }
            
        }

        protected override void OnWindowLoaded(object sender, RoutedEventArgs e)
        {
            
        }

        protected override void OnWindowClosing(object? sender, CancelEventArgs e)
        {
            //MessageBox.Show("SubWindow Closing");
        }


        public ICommand ConnectCommand => new RelayCommand<object>(ConnectDB);

        public ICommand CloseCommand => new RelayCommand<object>(_ => Window?.Close());
    }
}
