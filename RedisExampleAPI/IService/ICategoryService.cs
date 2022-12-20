using RedisExampleAPI.Models;

namespace RedisExampleAPI.IService
{
    public interface ICategoryService
    {
        List<CategoryModel> GetAllCategory();
    }
}
