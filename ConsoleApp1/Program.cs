using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Fields fields in Enum.GetValues(typeof(Fields)))
            {

                HttpWebRequest requestImpretion = (HttpWebRequest)WebRequest.Create("https://beta.hybrid.ru/core/agencyStatistic/GetSplit");
                requestImpretion.Headers.Add("Cookie: _ym_d=1571742834; _ym_uid=1571742834880121003; _ga=GA1.2.1464991307.1571742834; intercom-id-m6k66xn2=1017a0d9-152b-4d7e-947e-74f80156dce6; intercom-session-m6k66xn2=L3dScFQvV095NkNuTU0wQmMvWFltNU9hR1lNKzViV0hneUlRRkhxSDhaR051T2VRZ3IzU2VRaTExcndXaWZoOS0tV2tHL01GMVJNeDJCUFR0YW4xVEZoUT09--ac93ae516dea5334ce8b9b4944434867f83ae1e5; aft=jLr6tjvOv0RCYx8L4eUXMkeMxFE8xmuS3AgqpI0MXmYMAj_Ff_qZH4iwuos1BzOSBA-uRDGh84yvEvPG31i9SYmQ_P81; _gid=GA1.2.2028751387.1576653529; _ym_isad=2; csid=c8KKSACB1ikLrl-OMoboF9FNTlyfcsEWQMsNyQEWr_foU2SmKv35tbFLI3OY7_8YsoGZGR3lOzm5fI3CKUyfQxDPCUYQZOh6IK1Wxwqi4X68ak7_kydRHVQlYqz9P3uKS40KmSH5y2uV3LqtCu6X3sk3gdU5OFxDinhEZ-xYYJ2uK46X-jpDyrrvR9-E2hCPe-KDoItVjciInydL3Fb37kv13v8hWOIjdAFJ7-e7Kvy6nOnaAFzD5pJNY_IuKNNxAkZR7TjHvB2DlOT-tGPpE4M39BFg-ao9q_60LKEyA4nrbXzE");
                requestImpretion.ContentType = "application/json";
                requestImpretion.Method = "POST";
                using (var request = new StreamWriter(requestImpretion.GetRequestStream()))
                {
                    request.Write($"{{\"startDate\":\"2019-12-18T00:00:00\",\"endDate\":\"2019-12-18T23:59:59\",\"sortField\":2,\"sortDirection\":0,\"page\":0,\"limit\":100,\"filters\":{{}},\"fields\":[{(int)fields}],\"split\":\"1\"}}");
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
                        case Fields.TotalSum:
                            Console.WriteLine(item.TotalSum + " " + Fields.TotalSum);
                            break;
                        case Fields.Reach:
                            Console.WriteLine(item.Reach + " " + Fields.Reach);
                            break;
                        //case Fields.WinsSumWithComission:
                        //    Console.WriteLine(item.SumWinningPrice + " " + Fields.WinsSumWithComission);
                        //    break;
                            /*if (Clickhouse.ImpressionsCount != item.ImpressionsCount)
                                Console.WriteLine("Показы не совпали.")
                            break;*/
                            //case Fields.ViewsCount:
                            //    Console.WriteLine();
                            //item.ViewsCount
                    }
                    
                }
            }
            Console.WriteLine("END!");
            Console.ReadLine();

        }
    }
}
