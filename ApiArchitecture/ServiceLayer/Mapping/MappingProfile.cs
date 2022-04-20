using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Customer;

namespace ServiceLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookListDto>();
        }
    }
}
