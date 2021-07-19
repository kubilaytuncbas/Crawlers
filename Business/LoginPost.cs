using DataAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Business
{
    public class LoginPost:ILogInService
    {

        IUserDal _userDal;
        public LoginPost(IUserDal userDal)
        {
            userDal = _userDal;
        }



        //Parametre email ve password iste

        public void LogIn()
        {


            var tampon = Encoding.UTF8.GetBytes("email = info@coskunlastik.com.tr & password = ia3vubx5");
            var webRequest = (HttpWebRequest)WebRequest.Create("https://bayi.ustundaglastik.com/");
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = tampon.Length;
            webRequest.Proxy = new WebProxy((string)null, true);
            using (var istekStream = webRequest.GetRequestStream())
            {
                istekStream.Write(tampon, 0, tampon.Length);
            }
            var yanit = (HttpWebResponse)webRequest.GetResponse();
            var yanitIcerigi = string.Empty;
            using (var responseStream = yanit.GetResponseStream())
            {
                var streamReader = new StreamReader(responseStream);
                yanitIcerigi = streamReader.ReadToEnd();
            }



        }
    }
}
