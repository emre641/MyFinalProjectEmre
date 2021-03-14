using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)   //Parametre ile gönderilen iş kurallarını olumluysa haberdar ediyoruz.
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)// Eğer hata varsa logicte bunu haberdar edip döndürüyor. Yani hatayı yakalıyor.
                {
                    return logic;           // Logic = kural demektir. 
                }
            }
            return null;            //Sorun varsa zaten onaylamamıştır. boş döner
        }
    }
}
