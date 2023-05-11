﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DeliveryProjectNuget.Models
{
    [Table("Purchases")]
    public class Purchase
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("UserId")]
        public int UserId { get; set; }
        [Column("RestaurantId")]
        public int RestaurantId { get; set; }
        [Column("Coupon")]
        public int Coupon { get; set; }
        [Column("ShippingFee")]
        public decimal? ShippingFee { get; set; }
        [Column("TotalPrice")]
        public decimal TotalPrice { get; set; }
        [Column("Status")]
        public string Status { get; set; }
        [Column("Delivery")]
        public bool Delivery { get; set; }
        [Column("RequestDate")]
        public DateTime RequestDate { get; set; }
        [Column("CompletedDate")]
        public DateTime? CompletedDate { get; set; }
        [Column("Code")]
        public string? Code { get; set; }
        [Column("DeliveryAddress")]
        public string? DeliveryAddress { get; set; }
        [Column("DeliveryMethod")]
        public string DeliveryMethod { get; set; }
        [Column("Products")]
        public string Products { get; set; }
        [Column("PaymentMethod")]
        public string? PaymentMethod { get; set; }
    }
}
