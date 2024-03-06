﻿using System.ComponentModel.DataAnnotations;

namespace GuestBook.Models
{
    // класс модели-представления (view-model)
    public class LoginModel
    {
        [Required]
        public string? Login { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}