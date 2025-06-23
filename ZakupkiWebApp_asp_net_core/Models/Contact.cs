using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace ZakupkiWebApp_asp_net_core.Models
{
    public class Contact
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя")]
       
        public string Name { get; set; }
        
        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string Surname { get; set; }

        [Display(Name = "Введите возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }

        [Display(Name = "Введите адрес электронной почты")]
        [Required(ErrorMessage = "Вам нужно ввести адрес электронной почты")]
        public string Email { get; set; }

        [Display(Name = "Введите сообщение")]
        [Required(ErrorMessage = "Вам нужно ввести текст сообщения")]
        [StringLength(1000, MinimumLength = 30, ErrorMessage = "Текст должен содержать минимум 30 символов")]
        //[StringLength(30, ErrorMessage = "Текст менее 30 символов")]
        public string Message { get; set; }

        public DateTime SubmittedAt { get; set; } = DateTime.Now;
    }
}
