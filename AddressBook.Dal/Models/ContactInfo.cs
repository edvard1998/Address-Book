using System;
using System.Collections.Generic;

namespace AddressBook.Dal.Models
{
    public partial class ContactInfo
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string? PhysicalAddress { get; set; }
    }
}
