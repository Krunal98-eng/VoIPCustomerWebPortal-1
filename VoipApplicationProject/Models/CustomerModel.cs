﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VoipApplicationProject.Models
{
    public class CustomerModel
    {
        public string Id { get; set; }

        [Required]
        public string CustomerName { get; set; }

        public string UserName { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$",
            ErrorMessage = "Password must be between 8 and 15 characters and with one upper case alphabet, one number and one special character required.")]

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool ISMigrated { get; set; }     
        public CustomerType CustomerTypeID { get; set; } //enum
        public bool ISTrialBalanceOpted { get; set; }

        [Required]
        public string OrganisationName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string token { get; set; }
        public string refreshtoken { get; set; }
        public string refreshTokenExpiration { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Message { get; set; }
    }
    public enum CustomerType
    {
        User = 0,
        Agents = 1,
        Demo = 2,
        Admin = 3
    }
}
