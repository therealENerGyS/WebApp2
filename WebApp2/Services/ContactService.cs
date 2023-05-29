using WebApp2.Context;
using WebApp2.Models.Entities;
using WebApp2.ViewModels;

namespace WebApp2.Services
{
    public class ContactService
    {
        private readonly DataContext _context;

        public ContactService(DataContext context)
        {
            _context = context;
        }

        public void SaveContact(ContactFormViewModel viewModel)
        {
            ContactEntity contactEntity = new ContactEntity()
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                PhoneNumber = viewModel.PhoneNumber,
                CompanyName = viewModel.CompanyName,
                Comment = viewModel.Comment,
            };

            _context.Contacts.Add(contactEntity);
            _context.SaveChanges();
        }
    }
}
