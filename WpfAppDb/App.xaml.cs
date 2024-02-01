using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using WpfAppDb.Data;
using WpfAppDb.Models;
using WpfAppDb.ViewModels;
using WpfAppDb.Views;
using WpfEmployees.Repositories;

namespace WpfAppDb;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        ServiceCollection serviceCollection = new();
        ConfigureServices(serviceCollection);
        var serviceProvider = serviceCollection.BuildServiceProvider();

        var view = serviceProvider.GetService<MainView>();
        view.DataContext = serviceProvider.GetService<MainViewModel>();
        view.Show();
    }

    private static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<MainView>();
        services.AddScoped<MainViewModel>();
        services.AddSingleton<IRepository<Item>, ItemRepository>();
        services.AddSingleton<IRepository<Category>, CategoryRepository>();
        services.AddDbContext<AppDbContext>(options => options.UseSqlServer("Server=localhost,1433;Database=TuBaseDeDatos;User Id=sa;Password=StrongPassw0rd;TrustServerCertificate=true;"));
    }
}
