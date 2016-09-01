using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinkCareMobile
{
    public static class utility
        
    {
       public static String zeut;
       public static String GenerteZeut()
        {
            Random random = new Random();
            int indexOfNumber = random.Next(10000, 100000000);
            var id = string.Format("{0:00000000}", indexOfNumber);
            int mone = 0, incNum = 0;
            for (var i = 0; i < 8; i++)
            {
                incNum = int.Parse(id[i].ToString());
                incNum *= (i % 2) + 1;
                if (incNum > 9)
                    incNum -= 9;
                mone += incNum;
            }
            var checkdigit = 10 - (mone % 10);
            if (checkdigit == 10) checkdigit = 0;
            var personalId = id + checkdigit.ToString();
            return personalId;

        }  
        //ToDo - finish generator code
        public static String generatePatientMail() {
              Random random = new Random();
            int number = random.Next(1000, 10000);
            var mail = "hore"+number+"@yopmail.com";
            return mail;
        }
    }
}
