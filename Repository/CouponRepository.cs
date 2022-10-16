using AutoMapper;
using Mango.Service.CouponApi.Data;
using Mango.Service.CouponApi.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace Mango.Service.CouponApi.Repository;

public class CouponRepository : ICouponRepository
{
    private readonly ApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public CouponRepository(ApplicationDbContext applicationDbContext, IMapper mapper)
    {
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }
    public async Task<CouponDto> GetCouponByCode(string couponCode)
    {
        var couponFromDb = await _applicationDbContext.Coupons.FirstOrDefaultAsync(u => u.CouponCode == couponCode);
        return _mapper.Map<CouponDto>(couponFromDb);
    }
}