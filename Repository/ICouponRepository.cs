using Mango.Service.CouponApi.Models.Dto;

namespace Mango.Service.CouponApi.Repository;

public interface ICouponRepository
{
    Task<CouponDto> GetCouponByCode(string couponCode);
}