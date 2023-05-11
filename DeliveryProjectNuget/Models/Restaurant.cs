﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryProjectNuget.Models
{
    [Table("Restaurants")]
    public class Restaurant
    {
        [Key]
        [Column("Id")]
        public int Id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
        [Column("Description")]
        public string? Description { get; set; }
        [Column("Address")]
        public string Address { get; set; }
        [Column("ZipCode")]
        public string ZipCode { get; set; }
        [Column("City")]
        public string City { get; set; }
        [Column("Country")]
        public string Country { get; set; }
        [Column("Maps")]
        public string Maps { get; set; }
        [Column("Phone")]
        public string? Phone { get; set; }
        [Column("ContactEmail")]
        public string? ContactEmail { get; set; }
        [Column("Website")]
        public string? Website { get; set; }
        [Column("MinimumAmount")]
        public decimal MinimumAmount { get; set; }
        [Column("DeliveryFee")]
        public decimal DeliveryFee { get; set; }
        [Column("DeliveryActive")]
        public bool DeliveryActive { get; set; }
        [Column("DeliveryMinTime")]
        public int DeliveryMinTime { get; set; }
        [Column("DeliveryMaxTime")]
        public int DeliveryMaxTime { get; set; }
        [Column("DateAdd")]
        public DateTime DateAdd { get; set; }
        [Column("DateEdit")]
        public DateTime? DateEdit { get; set; }
        [Column("CreatedBy")]
        public int CreatedBy { get; set; }
        [Column("EditedBy")]
        public int? EditedBy { get; set; }
        [Column("Image")]
        public string Image { get; set; }
    }
}
