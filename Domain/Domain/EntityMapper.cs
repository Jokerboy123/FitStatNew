using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public static class EntityMapperDefault
    {
        public static IMapper ObjectMapper { get; } = Configure();
        private static IMapper Configure()
        {
            var config = new MapperConfiguration(cfg =>
                cfg.AddProfile<DatabaseProfile>()
            );
            return config.CreateMapper();
        }
    }
    public class DatabaseProfile : Profile
    {
        public DatabaseProfile()
        {
            //CreateMap<Product, ProductQueryModel>();
        }
    }
}
