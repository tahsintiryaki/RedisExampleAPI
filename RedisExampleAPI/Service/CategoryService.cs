using RedisExampleAPI.IService;
using RedisExampleAPI.Models;

namespace RedisExampleAPI.Service
{
    public class CategoryService : ICategoryService
    {
        static List<CategoryModel> categories => new()
        {
             new CategoryModel { Id = 1, Name = "Electronic" },
             new CategoryModel { Id = 2, Name = "Clothes" },
             new CategoryModel { Id = 3, Name = "Shoes" }
        };

        public ICacheService CacheService { get; }

        public CategoryService(ICacheService cacheService)
        {
            CacheService = cacheService;
        }
        public List<CategoryModel> GetAllCategory()
        {
            return GetCategoriesFromCache();
        }
        private List<CategoryModel> GetCategoriesFromCache()
        {
            return CacheService.GetOrAdd("allcategories", () => { return categories; });
        }
    }
}
