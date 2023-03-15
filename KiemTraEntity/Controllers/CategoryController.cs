using KiemTraEntity.DTO;
using KiemTraEntity.Models;
using KiemTraEntity.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KiemTraEntity.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public List<CategoryReponseDto> GetAll()
        {
            try
            {
                var categories = _unitOfWork.CategoryRepository.GetAll().Select(x => new CategoryReponseDto
                {
                    Id = x.Id,
                    Name = x.Name
                }).ToList();
                return categories;

            }
            catch (Exception e)
            {
                return new List<CategoryReponseDto>();
            }
        }

        [HttpGet]
        [Route("{id}")]
        public CategoryReponseDto GetById(int id)
        {
            try
            {
                var category = _unitOfWork.CategoryRepository.Get(id);
                var categoryDto = new CategoryReponseDto
                {
                    Id = category.Id,
                    Name = category.Name
                };
                return categoryDto;
;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPost]
        public CategoryRequestDto Create(CategoryRequestDto inp)
        {
            try
            {
                var category = new Category
                {
                    Name = inp.Name,
                    CreatedDate = inp.DateCreated ?? DateTime.Now
                };
                var data = _unitOfWork.CategoryRepository.Create(category);
                return inp;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("{id}")]
        public CategoryRequestDto Update(int id, CategoryRequestDto inp)
        {
            try
            {
                var category = new Category
                {
                    Id = id,
                    Name = inp.Name,
                    CreatedDate = inp.DateUpdate ?? DateTime.Now,
                };
                var data = _unitOfWork.CategoryRepository.Update(category, id);
                return inp;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public String Delete(int id)
        {
            try
            {
                var category = _unitOfWork.CategoryRepository.Get(id);
                _unitOfWork.CategoryRepository.Delete(category);
                return "Delete success";
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
