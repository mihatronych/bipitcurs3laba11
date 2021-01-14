using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using bipitcurs3semester1laba11.Models;
namespace bipitcurs3semester1laba11.Controllers
{
    public class ValuesController : ApiController
    {
        Journal journal = new Journal();
        ValuesController()
        {
            journal.Configuration.ProxyCreationEnabled = false;
        }

        [Route("~/api/GetOutputs")]
        [HttpGet]
        public IEnumerable<Outputs> GetOutputs()
        {
            return journal.Outputs;
        }

        [Route("~/api/GetBooks")]
        [HttpGet]
        public IEnumerable<Books> GetBooks()
        {
            return journal.Books;
        }

        [Route("~/api/GetReaders")]
        [HttpGet]
        public Readers GetReaders(int id)
        {
            return journal.Readers.FirstOrDefault(r => r.r_id==id);
        }

        [Route("~/api/GetOutput")]
        [HttpGet]
        public Outputs GetOutput(int id)
        {
            return journal.Outputs.FirstOrDefault(o => o.o_id == id);
        }

        [Route("~/api/GetBook")]
        [HttpGet]
        public Books GetBook(int id)
        {
            return journal.Books.FirstOrDefault(b => b.b_id == id);
        }

        [Route("~/api/GetReaders")]
        [HttpGet]
        public IEnumerable<Readers> GetReaders()
        {
            return journal.Readers;
        }

        [Route("~/api/CreateOutput")]
        [HttpPost]
        public void CreateOutput([FromBody] Outputs output)
        {
            output.o_id = journal.Outputs.Count() + 1;
            journal.Outputs.Add(output);
            journal.SaveChanges();
        }

        [Route("~/api/CreateBook")]
        [HttpPost]
        public void CreateBook([FromBody] Books book)
        {
            book.b_id = journal.Books.Count() + 1;
            journal.Books.Add(book);
            journal.SaveChanges();
        }

        [Route("~/api/CreateReader")]
        [HttpPost]
        public void CreateReader([FromBody] Readers reader)
        {
            reader.r_id = journal.Readers.Count() + 1;
            journal.Readers.Add(reader);
            journal.SaveChanges();
        }

        [Route("~/api/DeleteOutput")]
        [HttpDelete]
        public void DeleteOutput(int id)
        {
            Outputs outputs = new Outputs { o_id = id };
            var res = journal.Outputs.FirstOrDefault(o => o.o_id == id);
            if (res != null)
            {
                journal.Outputs.Remove(res);
                journal.SaveChanges();
            }
        }

        [Route("~/api/DeleteReader")]
        [HttpDelete]
        public void DeleteReader(int id)
        {
            Readers reader = new Readers { r_id = id };
            var res = journal.Readers.FirstOrDefault(r => r.r_id == id);
            if (res != null)
            {
                journal.Readers.Remove(res);
                journal.SaveChanges();
            }
        }

        [Route("~/api/DeleteBook")]
        [HttpDelete]
        public void DeleteBook(int id)
        {
            Books books = new Books { b_id = id };
            var res = journal.Books.FirstOrDefault(b => b.b_id == id);
            if (res != null)
            {
                journal.Books.Remove(res);
                journal.SaveChanges();
            }
        }
    }
}
