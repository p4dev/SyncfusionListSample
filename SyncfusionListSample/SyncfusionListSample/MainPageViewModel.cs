using Prism.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SyncfusionListSample
{
    public class MainPageViewModel
    {
        public List<FruitModel> Fruits { get; set; }
        public DelegateCommand<FruitModel> ShowFruitPriceCommand { get; }
        public bool CanExecute { get; private set; }

        public MainPageViewModel()
        {
            CanExecute = true;
            Fruits = new List<FruitModel>
            {
                new FruitModel
                {
                    Name = "Apple",
                    Price = "0.75"
                },
                new FruitModel
                {
                    Name = "Orange",
                    Price = "0.45"
                },
                new FruitModel
                {
                    Name = "Pear",
                    Price = "0.89"
                },
                new FruitModel
                {
                    Name = "Banana",
                    Price = "0.50"
                },
            };

            ShowFruitPriceCommand = new DelegateCommand<FruitModel>(ShowPrice);
        }

        private void ShowPrice(FruitModel model)
        {
            Application.Current.MainPage.DisplayAlert($"The {model.Name} costs", model.Price, "OK");
        }
    }
}
