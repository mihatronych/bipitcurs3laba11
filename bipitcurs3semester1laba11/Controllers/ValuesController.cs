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

        [Route("~/api/CreatetOutput")]
        [HttpPost]
        public void CreateOutput([FromBody] Outputs output)
        {
            journal.Outputs.Add(output);
            journal.SaveChanges();
        }

        [Route("~/api/CreatetBook")]
        [HttpPost]
        public void CreateBook([FromBody] Books book)
        {
            journal.Books.Add(book);
            journal.SaveChanges();
        }

        [Route("~/api/CreatetReader")]
        [HttpPost]
        public void CreateReader([FromBody] Readers reader)
        {
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
            Outputs outputs = new Outputs { o_id = id };
            var res = journal.Outputs.FirstOrDefault(o => o.o_id == id);
            if (res != null)
            {
                journal.Outputs.Remove(res);
                journal.SaveChanges();
            }
        }

        [Route("~/api/DeleteBook")]
        [HttpDelete]
        public void DeleteBook(int id)
        {
            Outputs outputs = new Outputs { o_id = id };
            var res = journal.Outputs.FirstOrDefault(o => o.o_id == id);
            if (res != null)
            {
                journal.Outputs.Remove(res);
                journal.SaveChanges();
            }
        }
    }
}
