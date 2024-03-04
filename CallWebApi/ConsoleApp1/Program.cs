using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.IO;
using System.Security.Policy;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string apiURL = "https://dvp-api.royal-holiday.com/Outlet-Orion/api/payment/onlinePmntCC";

            StringBuilder requestBody = new StringBuilder();

            requestBody.Append("{ " +
                "           \"totalAmnt\": 100," +
                "           \"typeCurrency\": 484," +
                "           \"numMerchant\": \"0000005\"," +
                "           \"lead\": 1516236," +
                "           \"creditCardNumber\": \"4512101234784546\"," +
                "           \"creditCardCVC\": \"054\"," +
                "           \"creditCardExpYear\": 2025," +
                "           \"creditCardExpMonth\": 10," +
                "           \"creditCardType\": 1," +
                "           \"idApplication\": 1," +
                "           \"idApplTrx\": 0," +
                "           \"idBank\": 23," +
                "           \"numMonths\": 1," +
                "           \"userName\": \"usr_appMovil\"," +
                "           \"pwdUser\": \"usr_appMovil\"," +
                "           \"oc\": \"401-735787\"," +
                "           \"typePayment\": 1," +
                "           \"ipAddress\": \"127.0.0.1\"," +
                "           \"invoiceNumb\": \"0\"," +
                "           \"codApp\": \"1\"," +
                "           \"creditCardHolder\": \"Carlos Barajas Rusk\"," +
                "           \"serviceCenterId\": 586," +
                "           \"countryId\": 52," +
                "           \"resortsAdv_PaymentType\": 9037," +
                "           \"amountFixRate\": 0," +
                "           \"currencyFixRateId\": 0," +
                "           \"fixRate\": 0," +
                "           \"currentRate\": 0," +
                "           \"comments\": \"\"," +
                "           \"companyId\": \"0\"," +
                "           \"checkOwnerName\": \"\"," +
                "           \"resortsAdvTransactionCode\": 0," +
                "           \"resortsAdvABA\": \"\"," +
                "           \"resortsAdvBankAccount\": \"\"," +
                "           \"resortsAdvBankAccountType\": \"\"," +
                "           \"languageDesc\": \"ESP\"," +
                "           \"diveceSeasonID\": \"\", " +
                "           \"name\": \"Hector\"," +
                "           \"lastName\": \"Hernandez Carbajal\"," +
                "           \"email\": \"mlopezc@royal-holiday.com\"," +
                "           \"phone\": \"5532322231\"," +
                "           \"ownerCurrencySymbol\": \"MXN\"," +
                "           \"creditCardToken\": \"42d95ef55d853b6a0fe433b3bd81e1f9\"," +
                "           \"description\": \"dues-37\",\r\n  \"accessTokenMercadoPago\": \"\"," +
                "           \"redirectUrl\": \"https://dvp-ngn-modules.royal-holiday.com/es/pago?idMerchant=8219&countryId=52&serviceCenter=SX&idApp=2&currencyId=2\"," +
                "           \"use3dSecure\": true " +
            "} ");

            HttpClient client = new HttpClient();   
            client.PosAs


            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(apiURL);
            webrequest.Method = "POST";
            webrequest.ContentType = "application/json";
            webrequest.Headers.Add("Authorization", "Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJVc2VySUQiOiI2OWJkOWMyMy03NzExLTQ2MmItOTVjNS0xYTQ2N2JjMDgxNTUiLCJVc2VyTmFtZSI6InVzcl9wYXltZW50cyIsIk5hbWUiOiJVc3IiLCJMYXN0TmFtZSI6InBheW1lbnRzIiwiRW1haWwiOiJ1c3JfcGF5bWVudHNAcm95YWwtaG9saWRheS5jb20iLCJDbGllbnRJRCI6IjQ2YTgxOGQ3LTI4NDQtNGE4NS1hNDkyLWI2ODE3MWMyNWNhZSIsIm5iZiI6MTcwODY0OTM5MSwiZXhwIjoxNzA5OTQ1MzkxLCJpYXQiOjE3MDg2NDkzOTF9.P-yBZYPjfznm7RDJMbodaT8KRmzg_0tAlL7oNWMd1Jg");
          
            HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();
            Encoding enc = System.Text.Encoding.GetEncoding("utf-8");
            StreamReader responseStream = new StreamReader(webresponse.GetResponseStream(), enc);
            string result = string.Empty;
            result = responseStream.ReadToEnd();
            webresponse.Close();


            Console.WriteLine( result );

        }
    }
}
