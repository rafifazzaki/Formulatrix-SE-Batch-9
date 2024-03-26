using APITutorial.Data;
using Microsoft.AspNetCore.Mvc;
using APITutorial.Model;
using Microsoft.EntityFrameworkCore;
using APITutorial.Model.DTOs;
namespace APITutorial.Controller;

public class CategoryController : APIBaseController
{
    private readonly DataContext _db;

    public CategoryController(DataContext db)
    {
        _db = db;
    }


    [HttpGet]
    public IActionResult GetAllCategory(){
        // var categories = _db.Categories.ToList();
        // var categories = _db.Categories.Include(c => c.Products).ToList();
        
        // using DTO (Data Transfer Object)
        List<CategoryDTO> categoryResponds = new();
        foreach (var category in categoryResponds)
        {
            categoryResponds.Add(new CategoryDTO{
                CategoryName = category.CategoryName,
                Description = category.Description
            });
        }

        return Ok(categoryResponds);
    }

    [HttpGet("{id}")]
    public IActionResult GetCategory(int id){
        var category = _db.Categories.Include(c => c.Products).FirstOrDefault(c => c.CategoryId == id);
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
        Category category = new Category();
        // mapping to DTO
        category.CategoryName = categoryRequest.CategoryName;
        category.Description = categoryRequest.Description;
        _db.Categories.Add(category);
        _db.SaveChanges();
        return Ok(category);
    }
    [HttpPut("{id}")]
    public IActionResult UpdateCategory(int id, Category? category){
        if(category is null){
            return NotFound("Category not found!");
        }
        var existingCategory = _db.Categories.FirstOrDefault(c => c.CategoryId == id);
        if(existingCategory is null){
            return NotFound($"Category with id {id} not found!");
        }
        if(category.CategoryName != null){
            existingCategory.CategoryName = category.CategoryName;
        }
        if(category.Description != null){
            existingCategory.Description = category.Description;
        }
        _db.SaveChanges();
        return Ok(existingCategory);
    }
}
