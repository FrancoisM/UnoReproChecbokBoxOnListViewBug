using System.Collections.Generic;
using ReproApp.ViewModels.Interfaces;

namespace ReproApp.ViewModels
{
    public class MainPageViewModel : BasePageViewModel, IMainPageViewModel
    {
        private IEnumerable<IMainCellViewModel> _items;
        public IEnumerable<IMainCellViewModel> Items
        {
            get => _items;
            private set
            {
                if (_items == value) return;
                _items = value;
                OnPropertyChanged(nameof(Items));
            }
        }

        public MainPageViewModel()
        {
            _items = new List<IMainCellViewModel>
            {
                new MainCellViewModel("Bank A", 100),
                new MainCellViewModel("Bank B", -150)
            };
        }

        private class MainCellViewModel : IMainCellViewModel
        {
            public string Bank { get; }
            public decimal Value { get; }
            public bool IsValuePositive => Value > 0;

            public MainCellViewModel(string banque, decimal budget)
            {
                Bank = banque;
                Value = budget;
            }
        }
    }
}
