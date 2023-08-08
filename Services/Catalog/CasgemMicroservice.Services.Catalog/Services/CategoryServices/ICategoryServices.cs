using CasgemMicroservice.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Catalog.Services.CategoryServices
{
    public interface ICategoryServices
    {
        Task<Response<List<ResultCategoryDto>>> GetAllCategoryAsync();
        Task<Response<ResultCategoryDto>> GetByIdCategoryAsync(string id);
        Task<Response<NoContent>> CreateCategoryAsync(CreateCategoryDto createCategoryDto);
        Task<Response<NoContent>> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
        Task<Response<NoContent>> DeleteCategoryAsync(string id);


    }
}
