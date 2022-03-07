using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Bll.Models
{
    public class ContactInfoModel
    {
        private string email;
        private string phoneNumber;

        [Required]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        public string EmailAddress 
        { 
            get { return email; } 
            set { email = value.Trim().ToLower(); }
        }
        [Required]
        public string PhoneNumber 
        { 
            get { return phoneNumber; } 
            set { phoneNumber = value.Trim(); } 
        }
        public string? PhysicalAddress { get; set; }
    }
}
