using entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{
    public class FormModelContact
    {
     

        [Required(ErrorMessage ="Adi Soyadi girilmesi zorunludur.")]
        public string AdiSoyadi { get; set; }
        
        
        [Required(ErrorMessage = "Telefon girilmesi zorunlu alan.")]
        [Phone(ErrorMessage = "Lütfen geçerli bir numara giriniz.")]
        public string Telefon { get; set; }
        
        
        [Required(ErrorMessage = "E-mail girilmesi zorunludur.")]
        [EmailAddress(ErrorMessage = "Lütfen geçerli bir E-mail adresi giriniz.")]
        public string Email { get; set; }

        
        
        [Required(ErrorMessage = "Mesaj zorunlu alan.")]
        [MaxLength(500)]
        public string Mesaj { get; set; }


        [Required]
        public int Kampanya { get; set; }


        public List<Contact> Contacts { get; set; }
        public PageInfo PageInfo { get; set; }

    }
}
