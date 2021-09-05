using entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace web.Models
{

    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }


        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
    }
    public class KariyerModel
    {

        [Required(ErrorMessage = "Ad ve Soyad zorunlu bir alan.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "E-Mail zorunlu bir alan.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Telefon numarası :")]
        [Required(ErrorMessage = "Telefon numarası zorunludur.")]
        
       
        public string Telephone { get; set; }

        [Display(Name = "Mesajınız :")]
        
        public string Message { get; set; }


        [Display(Name = "Özgeçmiş :")]
        [Required(ErrorMessage = "Cv Zorunludur.")]
        [DataType(DataType.Upload)]
        public IFormFile file { get; set; }

        public DateTime BasvuruTarihi { get; set; }

        public List<Kariyer> Kariyers { get; set; }
        public PageInfo PageInfo { get; set; }
    }

    public class MaxFileSizeAttribute : ValidationAttribute
    {
        private readonly int _maxFileSize;
        public MaxFileSizeAttribute(int maxFileSize)
        {
            _maxFileSize = maxFileSize;
        }

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            //var extension = Path.GetExtension(file.FileName);
            //var allowedExtensions = new[] { ".jpg", ".png" };`enter code here`
            if (file != null)
            {
                if (file.Length > _maxFileSize)
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"Maximum allowed file size is { _maxFileSize} bytes.";
        }
    }



    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string[] _extensions;
        public AllowedExtensionsAttribute(string[] extensions)
        {
            _extensions = extensions;
        }

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            var file = value as IFormFile;
            if (file != null)
            {
                var extension = Path.GetExtension(file.FileName);
                if (!_extensions.Contains(extension.ToLower()))
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }

            return ValidationResult.Success;
        }

        public string GetErrorMessage()
        {
            return $"This photo extension is not allowed!";
        }
    }



}
