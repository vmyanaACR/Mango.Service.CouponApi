using Mango.Service.CouponApi.Models.Dto;
using Mango.Service.CouponApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Service.CouponApi.Controllers;

[Route("api/coupon")]
public class CouponApiController : ControllerBase
{
    private readonly ICouponRepository _couponRepository;
    protected ResponseDto _responseDto;

    public CouponApiController(ICouponRepository couponRepository)
    {
        _couponRepository = couponRepository;
        _responseDto = new ResponseDto();
    }

    [HttpGet("{code}")]
    public async Task<object> GetDiscount(string code)
    {
        try
        {
            var coupon = await _couponRepository.GetCouponByCode(code);
            _responseDto.Result = coupon;
        }
        catch(Exception ex)
        {
            _responseDto.IsSuccess = false;
            _responseDto.ErrorMessages = new List<string>() { ex.ToString() };
        }

        return _responseDto;
    }
}