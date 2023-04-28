using System.ComponentModel.DataAnnotations;

namespace Crop_deal_1.Models
{
    public class User
    {
        [Key]
        public int User_id { get; set; }

        //-----------------------------------------------------------------
        [Required(ErrorMessage = "Please enter your name"), MinLength(3), MaxLength(50)]
        public string? User_name { get; set; }

        //----------------------------------------------------------------- 
        [Required(ErrorMessage = "Please enter contact number")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Number")]
        public string? User_contact { get; set; }

        public string? User_roles { get; set; } = string.Empty;

        //-----------------------------------------------------------------
        [Required(ErrorMessage = "Please enter your email id")]
        [DataType(DataType.EmailAddress)]

        public string? Email_id { get; set; }

        //-----------------------------------------------------------------

        [Required]
        public byte[]? PasswordHash { get; set; }
        [Required]
        public byte[]? PasswordSalt { get; set; }

        //-----------------------------------------------------------------

        [Required(ErrorMessage = "Please enter your DOB")]
        public DateTime? DBO { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "Please enter your Address")]
        public string? Address { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "Please enter your Bank Name")]
        public string? Bank_name { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "Please enter your Bank Account number")]
        public string? Bank_account_no { get; set; }

        //-------------------------------------------------------------

        [Required(ErrorMessage = "Please enter  IFSC code")]
        public string? IFSC{ get; set; }

        //-------------------------------------------------------------

        public bool Is_subscribe { get; set; } = false;

        public bool Is_Active { get; set; } = false;

    }
}

