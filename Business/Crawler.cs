using DataAccess;
using Entities;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Business
{
    public class Crawler
    {
        IProductDal _productDal;
        public Crawler(IProductDal productDal)
        {
            _productDal = productDal;
        }


        public async void Add()
        {

            var url = "https://bayi.ustundaglastik.com/products";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            var htmlDocument = new HtmlDocument();
            htmlDocument.LoadHtml(html);
            var divs = htmlDocument.DocumentNode.Descendants("div")
                .Where(a => a.GetAttributeValue("class", "")
                .Equals("view-table row-id Row row-id-tablet ProductID_4494_0")).ToList();

            //Eşlemiyor çekilemedi bilgi
            foreach (var div in divs)
            {
                var a = div.Descendants("a").First().Attributes[2].Value;
            }

            //Alınacak her bilgi ayrı foreach ile dönüp sutunlara yazılacak
            //Gelen veriyi list e at sonra sonu tablolara yazdır mantık bu 

        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

    }
}
