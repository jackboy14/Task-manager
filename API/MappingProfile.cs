using API.DTO;
using AutoMapper;
using Task = API.Models.Task;

namespace API;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Task, CreateDto>().ReverseMap();
    }
}