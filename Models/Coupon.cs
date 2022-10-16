using System.ComponentModel.DataAnnotations;

namespace Mango.Service.CouponApi.Models;

public class Coupon
{
    [Key]
    public int CouponId { get; set; }
    public string CouponCode { get; set; }
    public double DiscountAmount { get; set; }
}