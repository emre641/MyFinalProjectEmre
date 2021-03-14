using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public class AccessToken
    {
        public string Token { get; set; }    //jasonWeb değeri oluyor ve AccessToken da eşsiz bir kod üretiyor (KulAdı ve şifreyi alıp token veriyoruz. 
        public DateTime Expiration { get; set; }  //Bu da süresi ne zaman olacağını belirtir.
    }
}
