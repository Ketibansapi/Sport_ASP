using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SportTransfer4.Dtos;
using SportTransfer4.Models;

namespace SportTransfer4.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}