using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using WpfAppDb.Data;
using WpfAppDb.Models;
using WpfEmployees.Repositories;

namespace WpfAppDb.ViewModels;

internal partial class MainViewModel(IRepository<Item> itemRepoitory,
                                     IRepository<Category> categoryRepoitory) : ObservableObject
{
    [ObservableProperty]
    private ObservableCollection<Item> items = new(itemRepoitory.GetAll());
    [ObservableProperty]
    private ObservableCollection<Category> categories = new(categoryRepoitory.GetAll());
}
