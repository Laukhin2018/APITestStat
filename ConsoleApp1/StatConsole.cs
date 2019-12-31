using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class StatConsole
    {
        public void GetStatConsole()
        {
            foreach (Fields fields in Enum.GetValues(typeof(Fields)))
            {

                HttpWebRequest requestImpretion = (HttpWebRequest)WebRequest.Create("https://beta.hybrid.ru/core/agencyStatistic/GetSplit");
                requestImpretion.Headers.Add("Cookie: _ym_d=1571742834; _ym_uid=1571742834880121003; _ga=GA1.2.1464991307.1571742834; intercom-id-m6k66xn2=1017a0d9-152b-4d7e-947e-74f80156dce6; _gid=GA1.2.1799630091.1577705016; intercom-session-m6k66xn2=aFoxVlVkSzNWVmN0QWtiU0VOclM0Wm82YlhianJDdEtudlpRV2VmSGp2UEgwd1lodVR3ejNueFI5Z0dPWkhJeS0tcnNnSHU2bWhUYnBEOXEzVTBNdzhhdz09--363e27326bc2a9e52dcfdcbad875829e7f7a2acd; csid=_MFWBIJidPq53i7tnc0fx_Q2U9Y7uTHqqyillmeB0SwDxr14ccBE4KWF4SRtW_i-pWIp-Mg-6r_Ufmkh5TRn-f0AsBPbktMTiRf5OplxCUfWqBxFeRI6BEeofjHgxOFCU66pXugjxuIscMwPjJIbPR0yM8xOyKrwdSwdimxtOJmBQ3LEjM_UdJZ48T6o9fw42eNtpsu9yQAmWjTwxOPlHBPmX7gXm0i6M3xt1e9kt_fC0z0ziHhXBAn1IOTo5YMmTwDgt_cL3ZWOoWPThpe6o0Ffrr6AMMrQXtFoMoc6fjZqOGX0");
                requestImpretion.ContentType = "application/json";
                requestImpretion.Method = "POST";
                using (var request = new StreamWriter(requestImpretion.GetRequestStream()))
                {
                    request.Write($"{{\"startDate\":\"2019-12-30T00:00:00\",\"endDate\":\"2019-12-30T23:59:59\",\"sortField\":2,\"sortDirection\":0,\"page\":0,\"limit\":100,\"filters\":{{}},\"fields\":[{(int)fields}],\"split\":\"30\"}}");
                }


                HttpWebResponse responseImpretion = (HttpWebResponse)requestImpretion.GetResponse();
                string response = null;
                using (Stream stream = responseImpretion.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        response = reader.ReadToEnd();
                        //Console.WriteLine(reader.ReadToEnd());
                    }
                }
                responseImpretion.Close();
                ResponseCollection<Statistics> statistics = JsonConvert.DeserializeObject<ResponseCollection<Statistics>>(response);

                foreach (var item in statistics.Items)
                {
                    switch (fields)
                    {
                        case Fields.ImpressionsCount:
                            Console.WriteLine(item.ImpressionCount + " " + Fields.ImpressionsCount);
                            break;
                        case Fields.ClicksCount:
                            Console.WriteLine(item.ClickCount + " " + Fields.ClicksCount);
                            break;                        
                        case Fields.Reach:
                            Console.WriteLine(item.Reach + " " + Fields.Reach);
                            break;
                        case Fields.WinsSumWithComission:
                            Console.WriteLine(item.TotalSum + " " + Fields.WinsSumWithComission);
                            break;
                            /*if (Clickhouse.ImpressionsCount != item.ImpressionsCount)
                                Console.WriteLine("Показы не совпали.")
                            break;*/
                            //case Fields.ViewsCount:
                            //    Console.WriteLine();
                            //item.ViewsCount
                    }
                }
            }
        }
    }
}
