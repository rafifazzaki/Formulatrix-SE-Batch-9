using Microsoft.AspNetCore.Mvc;
using MVCTutorial.Data;
using MVCTutorial.Models;

namespace MVCTutorial.Controllers;

public class CategoryController : Controller
{
    private readonly DataContext _context;

    // yg memberikan akses ke database dbyanto adalah middleware
    public CategoryController(DataContext context){
        _context = context;
    }
    public IActionResult Index()
    {
        var categories = _context.Categories;
        return View(categories);
    }

    // Untuk nampilin
    public IActionResult Create(){
        return View();
    }

    // untuk nerima dari form method post
    [HttpPost]
    public IActionResult Create(Category category){
        _context.Categories.Add(category);
        _context.SaveChanges();
        return RedirectToAction("Index"); //sama seperti return View("Index", category) 
    }

    public IActionResult Update(int? id){
        if(id is null || id is 0){
            return RedirectToAction("Index");
        }
        var category = _context.Categories.Find(id);
        if(category is null){
            TempData["error"] = "Category not found";
            return RedirectToAction("Index");
        }
        return View(category);
    }

    [HttpPost]
    public IActionResult Update(Category category){
        _context.Categories.Update(category);
        _context.SaveChanges();
        TempData["success"] = "Category has been updated successfully";
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int? id){
        if(id is null || id is 0){
            return RedirectToAction("Index");
        }
        var category = _context.Categories.Find(id);
        if(category is null){
            return RedirectToAction("Index");
        }
        TempData["delete"] = $"Category {category.CategoryName} has been deleted";
        _context.Categories.Remove(category);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }
}
