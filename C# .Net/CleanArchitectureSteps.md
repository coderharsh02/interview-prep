1.  Create a blank solution.
2.  inside it add three class library
        - Application
        - Domain
        - Infrastructure
    add one web api project
        - WebAPI (Presentation)

3.  Adding References
    Remember DAI
    D 
    A - Add Domain as reference
    I - Add Application as reference
    P - Add Application and Infrstructure as reference
    
4.  Dependency Injection
    - Create folder DependencyInjection in Application and Infrastructure Library
    - Add ServiceContainer Class
    ```
    public static class ServiceContainer {
        public static IServiceCollection AddTypeService(this IServiceCollection services) {
            return services;
        }
    }
    ```
    IServiceCollection - Microsoft.Extenstions.DependencyInjection

5.  In Domain
    - Create folder for ProductEntity and Add Product Class with it's properties
    - Create folder for RepositoryInterface and Add IProductRepository with it's methods
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync();
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);

6.  In Application
    - Create folder for ProductDTOs and add class for 
        - ProductDto - CreateProductDto - UpdateProductDto

    - Create folder for MappingInterface and add interface IProductMapper
        ProductDto MapToDto (Product product);
        Product MapToEntity(CreateProductDto);
        Product MapToEntity(UpdateProductDto);

    - Create folder for MappingImplementation and add class
        ProductMapper : IProductMapper 

    - Create folder for UseCaseInterface and add class for IProductService 
        Task<IEnumerable<ProductDto>> GetAllProductsAsync();
        Task<ProductDto> GetProductByIdAsync();
        Task AddProductAsync(CreateProductDto product);
        Task UpdateProductAsync(UpdateProductDto product);
        Task DeleteProductAsync(int id);

    - Create folder for UseCaseImplementation and add class for 
        ProductService : IProductService
            Inject IProductRepository and IProductMapper

    
7.  In Infrastructure
    - Create DatabaseContext Folder and 
        class AppDbContext : DbContext (Microsoft.EntityFrameWorkCore)

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }

        public DbSet<Product> Products { get; set; }

    - Create RepositoryImplementation Folder and add a 
        class ProductRepository : IProductRepository 
        
        ProductRepository(AppDbContext context) => _context = context;

8.  