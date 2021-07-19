using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public interface ICrawlerService
    {
        List<Product> GetAll();
        void Add();
    }
}
