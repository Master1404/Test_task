using CryptocurrencyWpf.Models;
using CryptocurrencyWpf.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CryptocurrencyWpf.ViewModels
{
    public class CryptocurrencyViewModel : INotifyPropertyChanged
    {
        private ApiService _apiService;
        private ObservableCollection<Cryptocurrency> _cryptocurrencies;
        private Cryptocurrency selectedCryptocurrency;
        public Cryptocurrency SelectedCryptocurrency
        {
            get { return selectedCryptocurrency; }
            set
            {
                selectedCryptocurrency = value;
                OnPropertyChanged("SelectedCryptocurrency");
            }
        }
        public ObservableCollection<Cryptocurrency> Cryptocurrencies
        {
            get { return _cryptocurrencies; }
            set
            {
                _cryptocurrencies = value;
                OnPropertyChanged();
            }
        }
        public CryptocurrencyViewModel()
        {
            Cryptocurrencies = new ObservableCollection<Cryptocurrency>();
             _apiService = new ApiService();
             LoadCryptocurrenciesAsync();
        }

        private async Task LoadCryptocurrenciesAsync()
        {
            try
            {
                {
                    List<Cryptocurrency> result = await _apiService.GetCryptocurrencies();

                    // Добавляем полученные криптовалюты в коллекцию Cryptocurrencies
                    foreach (Cryptocurrency cryptocurrency in result)
                    {
                        Cryptocurrencies.Add(cryptocurrency);
                    }
                }
               
            }
            catch (Exception ex)
            {
                // Обработка ошибки при выполнении запроса или десериализации данных
                MessageBox.Show(ex.Message);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
