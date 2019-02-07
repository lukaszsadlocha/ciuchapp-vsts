using CiuchApp.Domain;

namespace CiuchApp.Dashboard.Services
{
    public interface IDropdownServices
    {
        ICrudService<Country> CountryService { get; }
        ICrudService<City> CityService { get; }
        ICrudService<Currency> CurrencyService { get; }
        ICrudService<Season> SeasonService { get; }
        ICrudService<Color> ColorService { get; }
        ICrudService<TopCategory> TopCategoryService { get; }
        ICrudService<MainCategory> MainCategoryService { get; }
        ICrudService<Group> GroupService { get; }
        ICrudService<Component> ComponentService { get; }
        ICrudService<CountryOfOrigin> CountryOfOriginService { get; }
        ICrudService<Supplier> SupplierService { get; }
        ICrudService<CodeCn> CodeCnService { get; }
        ICrudService<Set> SetService { get; }
        ICrudService<ColorName> ColorNameService { get; }
    }
}
