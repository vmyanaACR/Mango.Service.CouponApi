using AutoMapper;
using Mango.Service.CouponApi.Models;
using Mango.Service.CouponApi.Models.Dto;

namespace Mango.Service.CouponApi;

public class MappingConfig
{
    public static MapperConfiguration RegisterMap()
    {
        var mapperConfig = new MapperConfiguration(config =>
        {
            config.CreateMap<CouponDto, Coupon>().ReverseMap();
        });

        return mapperConfig;
    }
}