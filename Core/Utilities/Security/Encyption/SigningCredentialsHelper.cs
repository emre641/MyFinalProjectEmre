using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)  //Credention Kullanıcı adı.. Hangi anahtarı kullanacağı securityKey
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature); // Burada da kullanacağı algoritmayı belirtiyorum (SecurityAlgorithms.HmacSha512Signature)
        }
    }
}
