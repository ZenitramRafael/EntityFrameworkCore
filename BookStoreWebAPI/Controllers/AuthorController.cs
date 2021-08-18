using BookStoreWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Author> Get()
        {
            using (var context = new BookStoresDBContext())
            {
                //get all authors
                //return context.Authors.ToList();
                
                Author author = new Author();
                //add a author
                //author.FirstName = "John";
                //author.LastName = "Smith";
                //context.Authors.Add(author);

                //update author
                //author = context.Authors.Where(auth => auth.FirstName == "John").FirstOrDefault();
                //author.Phone = "777-777-7777";

                //remove author
                author = context.Authors.Where(auth => auth.FirstName == "John").FirstOrDefault();
                context.Authors.Remove(author);

                context.SaveChanges();

                //get author by id
                return context.Authors.Where(auth => auth.FirstName == "John").ToList();
            };
        }
    }
}
