# VISearch
VISearch is a advance and fast search library that is simple to use

## Main Summary of VISearch

VISearch will be an intensive search library with advanced features like search filters, search, search strings that can be written in different formats such as a filter string or object notation. VISearch will have AI features to that will use popular algorithms to do so though the AI version of VISearch will be released as a different package and will as an extension to VISearch library. 

VISearch will be at the moment only available for .NET environments. These environments include ASP.NET, WPF, Xamarin and even console. The base one being ASP.NET as VISearch is an API that is mainly for database tables for example. 

VISearch will take in a IEnumerable or a IQueryable(depending if the database is stored local or global server) which will most likely be a casted DbSet since I think Entity Framework(EF) is the best ORM for ASP.NET and EF is also Database cross-platform so it can be used with Microsoft SQL, MySQl, SqlLite and more.

The main class for the most of VISearch operations will be the SearchContext. The SearchContext will contain the main methods to start and manipulate the Search Pipeline. The SearchContext will take in a generic type TSearchType which will be the type of the collection to search through during the Search Pipeline. TSearchType will most likely and probably should the same type of the TSet type of the DbSet being used by the 
Search Pipeline to be searched through or some other table representation model. If you are using VISearch to update a current application to only modification you have to do current models is to update the table representation model(aka, the TSet of the DbSet being used by the Search Pipeline) in which you need to decorate at least property or field in the model with the SearchItemAttribute or decorate the model itself with SearchObjectAttribute. 

VISearch will depend on .NET Core dependency injection(DI) which is mostly likely to be setup in the Startup class in a ASP.NET project. There will also be extension classes to help with setting up the DI. All of this will be included in the main library of VISearch.

## Main Features of VISearch
The will be many features of VISearch but the main features of it will include the following

- Different search formats that you can choose from for your application such as a regular search string, a filter string or an object notation string. You can either choose a specific format or use all of them and let VISearch decide what the format is.

- Different search types that you can use. These types include a strict search in which a search string(any format excluding the filter string) must be exactly match an item in a collection for that item to be added to the Search Results. The other search type is sectional in which a search string does not have to match an item for that item to be added to Search Results with some optimization in mind so the most relevant data can come back the user.

- Ways to split search process. This will be highly recommended for large collections. The way it will work is that you pass in the number of splits to do a collection of number of items per a split to do a collection. The Search Pipeline will store/cache the current position/index of the collection. 

- Very flexible search settings so you can customize the way VISearch works in your application. These settings can be set in different areas of VISearch but most likely should be set using DI.

- Different attribute that you can use to decorate the search type model such as the SearchItemAttribute, SearchIgnoreAttribute and SearchObjectAttribute. The SearchItemAttribute will be the most important as that tell the VISearch that you want that property or field to be added to the Search Pipeline. You can also add base class properties and fields to the Search Pipeline by passing a list of them in the SearchContext class constructor. This constructor will be probably be most used if you want the Search Pipeline to search properties in the IdentityUser class.
