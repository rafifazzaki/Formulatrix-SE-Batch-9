using APITutorial.Model;
using APITutorial.Model.DTOs;
using AutoMapper;

namespace APITutorial.Map;

public class MyMapper : Profile
{
    public MyMapper(){
        // CreateMap<Destination, Source>
        CreateMap<CategoryDTO, Category>().ReverseMap();
        // sama kyk:
        // CreateMap<CategoryDTO, Category>();
        // CreateMap<Category, CategoryDTO>();
    }
}
