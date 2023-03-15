
using KiemTraEntity.DTO;
using KiemTraEntity.Models;
using KiemTraEntity.Repository;
using KiemTraEntity.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KiemTraEntity.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public List<ProductReponseDto> GetAll()
        {
            try
            {
                var products = _unitOfWork.ProductRepository.GetAll().Select(x => new ProductReponseDto
                {
                    Id = x.Id,
                    Name = x.Name,
                    Price = x.Price,
                    Code = x.Code
                }).ToList();
                return products;
            }
            catch (Exception e)
            {
                return new List<ProductReponseDto>();
            }
        }

        [HttpGet]
        [Route("{id}")]
        public ProductReponseDto GetById(int IdProduct)
        {
            try
            {
                var categories = _unitOfWork.ProductRepository.Get(IdProduct);
                var product = new ProductReponseDto
                {
                    Id = categories.Id,
                    Name = categories.Name,
                    Code = categories.Code,
                    Price = categories.Price,
                    DateUpdate = categories.UpdatedDate
                };
                return product;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPost]
        public ProductRequestDto Create(ProductRequestDto inp)
        {
            try
            {
                var category = _unitOfWork.CategoryRepository.Get(inp.CategoryId);
                var product = new Product
                {
                    Name = inp.Name,
                    Code = inp.Code,
                    Price = inp.Price,
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    CategoryId = inp.CategoryId,
                    Category = category
                };
                var data = _unitOfWork.ProductRepository.Create(product);
                _unitOfWork.SaveChanges();
                return inp;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        [HttpPut]
        [Route("{id}")]
        public ProductRequestDto Update(int IdProduct, ProductRequestDto inp )
        {
            try
            {
                var product = new Product
                {
                    Id = IdProduct,
                    Name = inp.Name,
                    Code = inp.Code,
                    Price = inp.Price,
                    UpdatedDate = inp.DateUpdate ?? DateTime.Now,
                    CategoryId = inp.CategoryId,
                };
                var data = _unitOfWork.ProductRepository.Update(product, IdProduct);
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
                var product = _unitOfWork.ProductRepository.Get(id);
                _unitOfWork.ProductRepository.Delete(product);
                return "Delete success";
                
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
