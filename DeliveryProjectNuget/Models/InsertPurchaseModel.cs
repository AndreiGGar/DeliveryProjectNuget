namespace DeliveryProjectNuget.Models
{
    public class InsertPurchaseModel
    {
        public int UserId { get; set; }
        public int RestaurantId { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }
        public bool Delivery { get; set; }
        public string RequestDate { get; set; }
        public string? DeliveryAddress { get; set; }
        public string DeliveryMethod { get; set; }
        public string? Code { get; set; }
        public string Products { get; set; }
        public string PaymentMethod { get; set; }
    }
}
