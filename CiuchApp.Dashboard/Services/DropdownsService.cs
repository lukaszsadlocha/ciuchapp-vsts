using CiuchApp.Domain;

namespace CiuchApp.Dashboard.Services
{
    public class DropdownServices : IDropdownServices
    {
        public ICrudService<Country> CountryService { get; }
        public ICrudService<City> CityService { get; }
        public ICrudService<Currency> CurrencyService { get; }
        public ICrudService<Season> SeasonService { get; }
        public ICrudService<Color> ColorService { get; }
        public ICrudService<TopCategory> TopCategoryService { get; }
        public ICrudService<MainCategory> MainCategoryService { get; }
        public ICrudService<Group> GroupService { get; }
        public ICrudService<Component> ComponentService { get; }
        public ICrudService<CountryOfOrigin> CountryOfOriginService { get; }
        public ICrudService<Supplier> SupplierService { get; }
        public ICrudService<CodeCn> CodeCnService { get; }
        public ICrudService<Set> SetService { get; }
        public ICrudService<ColorName> ColorNameService { get; }

        public DropdownServices(
            ICrudService<Country> countryService,
            ICrudService<City> cityService,
            ICrudService<Currency> currencyService,
            ICrudService<Season> seasonService,
            ICrudService<Color> colorServices,
            ICrudService<TopCategory> topCategoryService,
            ICrudService<MainCategory> mainCategoryService,
            ICrudService<Group> groupService,
            ICrudService<Component> componentService,
            ICrudService<CountryOfOrigin> countryOfOriginService,
            ICrudService<Supplier> supplierService,
            ICrudService<CodeCn> codeCnService,
            ICrudService<Set> setService,
            ICrudService<ColorName> colorNameService)
        {

            CountryService = countryService;
            CityService = cityService;
            CurrencyService = currencyService;
            SeasonService = seasonService;
            ColorService = colorServices;
            TopCategoryService = topCategoryService;
            MainCategoryService = mainCategoryService;
            GroupService = groupService;
            ComponentService = componentService;
            CountryOfOriginService = countryOfOriginService;
            SupplierService = supplierService;
            CodeCnService = codeCnService;
            SetService = setService;
            ColorNameService = colorNameService;
        }
    }
}

    ////public class CountryService : BaseDropdownService<Country>, ICrudService<Country>
    ////{
    ////    public CountryService(ApplicationDbContext context) : base(context)
    ////    {
    ////    }
    ////}
    ////public class CountryService : BaseService, ICrudService<Country>
    ////{
    ////    public CountryService(ApplicationDbContext context) : base(context) { }
    ////    public bool Add(Country item)
    ////    {
    ////        _context.Countries.Add(item);
    ////        return _context.SaveChanges() > 0;
    ////    }

    ////    public bool Delete(Country item)
    ////    {
    ////        _context.Countries.Remove(item);
    ////        return _context.SaveChanges() > 0;
    ////    }

    ////    public IList<Country> GetAll()
    ////    {
    ////        return _context.Countries.ToList();
    ////    }

    ////    public Country GetById(int id)
    ////    {
    ////        return _context.Countries.GetById(id);
    ////    }

    ////    public bool Update(Country item)
    ////    {
    ////        _context.Entry(item).State = EntityState.Modified;
    ////        return _context.SaveChanges() > 0;
    ////    }
    ////}

    //public class CityService : BaseService, ICrudService<City>
    //{
    //    public CityService(ApplicationDbContext context) : base(context) { }
    //    public bool Add(City item)
    //    {
    //        _context.Cities.Add(item);
    //        return _context.SaveChanges() > 0;
    //    }

    //    public bool Delete(City item)
    //    {
    //        _context.Cities.Remove(item);
    //        return _context.SaveChanges() > 0;
    //    }

    //    public IList<City> GetAll()
    //    {
    //        return _context.Cities.ToList();
    //    }

    //    public City GetById(int id)
    //    {
    //        return _context.Cities.GetById(id);
    //    }

    //    public bool Update(City item)
    //    {
    //        _context.Entry(item).State = EntityState.Modified;
    //        return _context.SaveChanges() > 0;
    //    }
    //}

    //public class CurrencyService : BaseService, ICrudService<Currency>
    //{
    //    public CurrencyService(ApplicationDbContext context) : base(context) { }
    //    public bool Add(Currency item)
    //    {
    //        _context.Currencies.Add(item);
    //        return _context.SaveChanges() > 0;
    //    }

    //    public bool Delete(Currency item)
    //    {
    //        _context.Currencies.Remove(item);
    //        return _context.SaveChanges() > 0;
    //    }

    //    public IList<Currency> GetAll()
    //    {
    //        return _context.Currencies.ToList();
    //    }

    //    public Currency GetById(int id)
    //    {
    //        return _context.Currencies.GetById(id);
    //    }

    //    public bool Update(Currency item)
    //    {
    //        _context.Entry(item).State = EntityState.Modified;
    //        return _context.SaveChanges() > 0;
    //    }
    //}

    //public class SeasonService : BaseService, ICrudService<Season>
    //{
    //    public SeasonService(ApplicationDbContext context) : base(context) { }
    //    public bool Add(Season item)
    //    {
    //        _context.Seasons.Add(item);
    //        return _context.SaveChanges() > 0;
    //    }

    //    public bool Delete(Season item)
    //    {
    //        _context.Seasons.Remove(item);
    //        return _context.SaveChanges() > 0;
    //    }

    //    public IList<Season> GetAll()
    //    {
    //        return _context.Seasons.ToList();
    //    }

    //    public Season GetById(int id)
    //    {
    //        return _context.Seasons.GetById(id);
    //    }

    //    public bool Update(Season item)
    //    {
    //        _context.Entry(item).State = EntityState.Modified;
    //        return _context.SaveChanges() > 0;
    //    }
    //}