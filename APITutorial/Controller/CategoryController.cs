using APITutorial.Data;
using Microsoft.AspNetCore.Mvc;
using APITutorial.Model;
using Microsoft.EntityFrameworkCore;
using APITutorial.Model.DTOs;
using AutoMapper;
using APITutorial.Repositories;
namespace APITutorial.Controller;

public class CategoryController : APIBaseController
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly DataContext _db;
    private readonly IMapper _mapper;

    // sebelum diabstraksi
    // public CategoryController(DataContext db, IMapper mapper)
    // {
    //     _db = db;
    //     _mapper = mapper;
    // }

    // sesudah diabstraksi
    public CategoryController(IMapper mapper, ICategoryRepository categoryRepository){
        _mapper = mapper;
        _categoryRepository = categoryRepository;
    }


    [HttpGet]
    public IActionResult GetAllCategory(){
        
        // sebelum diabstraksi
        // var categories = _db.Categories.ToList();

        // setelah diabstraksi
        var categories = _categoryRepository.GetAll().ToList();


        // var categories = _db.Categories.Include(c => c.Products).ToList(); //nampilin produk didalamnya
        
        // using DTO (Data Transfer Object)
        // List<CategoryDTO> categoryResponds = new();
        // foreach (var category in categoryResponds)
        // {
        //     categoryResponds.Add(new CategoryDTO{
        //         CategoryName = category.CategoryName,
        //         Description = category.Description
        //     });
        // }
        List<CategoryDTO> categoryResponds = _mapper.Map<List<CategoryDTO>>(categories);

        return Ok(categoryResponds);
    }

    [HttpGet("{id}")]
    public IActionResult GetCategory(int id){
        // sebelum diabstraksi
        // var category = _db.Categories.Include(c => c.Products).FirstOrDefault(c => c.CategoryId == id);
        
        // setelah diabstraksi
        var category = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();

        if(category == null){
            return NotFound();
        }
        return Ok(category);
    }
    [HttpPost]
    public IActionResult AddCategory([FromBody]CategoryDTO? categoryRequest){
        if(categoryRequest is null){
            return NotFound();
        }
        // Category category = new Category();
        // // mapping to DTO
        // category.CategoryName = categoryRequest.CategoryName;
        // category.Description = categoryRequest.Description;
        Category category = _mapper.Map<Category>(categoryRequest);

        // sebelum diabstraksi
        // _db.Categories.Add(category);
        // _db.SaveChanges();

        // setelah diabstraksi
        _categoryRepository.Add(category);
        _categoryRepository.Save();

        return Ok(category);
    }
    [HttpPut("{id}")]

    // [HttpPut]
	// [Route("{id}")]
    public IActionResult UpdateCategory([FromRoute]int id, [FromBody]Category? category){
        if(category is null){
            return NotFound("Category not found!");
        }
        
        // sebelum diabstraksi
        // var existingCategory = _db.Categories.FirstOrDefault(c => c.CategoryId == id);
        
        // setelah diabstraksi
        var existingCategory = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();
        
        if(existingCategory is null){
            return NotFound($"Category with id {id} not found!");
        }
        if(category.CategoryName != null){
            existingCategory.CategoryName = category.CategoryName;
        }
        if(category.Description != null){
            existingCategory.Description = category.Description;
        }
        _categoryRepository.Save();
        return Ok(existingCategory);
    }

    [HttpDelete("{id}")]
    public IActionResult UpdateCategory(int? id){
        if(id == null || id < 1){
            return NotFound();
        }
        // sebelum diabstraksi
        // var deleteCategory = _db.Categories.FirstOrDefault(c => c.CategoryId == id);
        
        // setelah diabstraksi
        var deleteCategory = _categoryRepository.Get(c => c.CategoryId == id).FirstOrDefault();
        
        if(deleteCategory == null){
            return NotFound();
        }
        // sebelum diabstraksi
        // _db.Categories.Remove(deleteCategory);
        // _db.SaveChanges();

        // setelah diabstraksi
        _categoryRepository.Remove(deleteCategory);
        _categoryRepository.Save();
        return Ok(deleteCategory);
    }
}
