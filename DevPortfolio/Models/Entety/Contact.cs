using System.ComponentModel.DataAnnotations;

namespace DevPortfolio.Models.Entety
{
    public class Contact
    {

        [Key]
        public int Id { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MinLength(3,ErrorMessage = "{0} نمیتوتند از {1} کاراکتر کمتر باشد")]
        [MaxLength(25,ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد")]
        public string Name { get; set; }
        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [EmailAddress]
        [MinLength(8, ErrorMessage = "{0} نمیتوتند از {1} کاراکتر کمتر باشد")]
        [MaxLength(250, ErrorMessage = "{0} نمی تواند از {1} کاراکتر بیشتر باشد")]
        public string Email { get; set; }
        [Display(Name = "موضوع")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Subject { get; set; }
        [Display(Name = "موضوع")]
        public string Description { get; set; }
    }
}
