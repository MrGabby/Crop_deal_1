using System.ComponentModel.DataAnnotations;

namespace Crop_deal_1.Models
{
    public class Crop_detail
    {
        [Key]
        [Required] 
        public int CropDetail_id { get; set;}
        [Required]
        public string? Crop_id { get; set;}
        [Required]
        public string? User_id { get; set;}
        [Required]
        public string? Crop_name { get; set;}
        [Required]
        public string? CropDetail_description { get; set;}
        [Required]  
        public int Crop_type { get; set;}
        [Required]  
        public int Quantity { get; set;}
        [Required]  
        public int Price { get; set;}
        [Required]
        public string? Location { get; set;}

    }
}
