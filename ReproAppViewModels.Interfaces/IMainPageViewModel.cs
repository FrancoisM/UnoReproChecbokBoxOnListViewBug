using System.Collections.Generic;

namespace ReproApp.ViewModels.Interfaces
{
    public interface IMainPageViewModel
    {
        IEnumerable<IMainCellViewModel> Items { get; }
    }

    public interface IMainCellViewModel
    {
        string Bank { get; }
        decimal Value { get; }
        bool IsValuePositive { get; }
    }
}