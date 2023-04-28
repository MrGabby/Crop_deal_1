using System.ComponentModel.DataAnnotations;

namespace Crop_deal_1.Models
{
    public class Invoice
    {

        [Key]
        public int Invoice_id { get; set; }

        [Required]
        //-----------------------------------------------------------------
        public string User_id { get; set; } = string.Empty;
        [Required]

        public string CropDetails_id{ get; set; } = string.Empty;

        [Required]
        public int  Quantity { get; set; }

        [Required]
        public string Payment_Mode { get; set; } = string.Empty;

        [Required]
        public string Status { get; set; } = string.Empty;

        [Required]
        public DateTime  Date_created { get; set; }

    }
}
