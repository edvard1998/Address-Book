using AddressBook.Bll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook.Bll.Interfaces
{
    public interface IContactInfoService
    {
        public IEnumerable<ContactInfoModel> GetAllContactInfos();
        public ContactInfoModel GetContactInfo(int id);
        public ContactInfoModel AddContact(ContactInfoModel contactInfoModel);
        public int UpdateContactInfo(ContactInfoModel contactInfoModel, int id);
        public void DeleteContacInfo(int id);
    }
}
