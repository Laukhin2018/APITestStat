using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class ClickHouse
    {
        public void GetStatClickHouse(string param)
        {
            HttpWebRequest requestImpretion = (HttpWebRequest)WebRequest.Create($"http://37.18.16.97:9123/?query=/*reports.hybrid.ru.local*/select%20toMonth(EventDate)%20AS%20Month,%20{{param}}%20AS%20SumWithComission%20FROM%20statistic.DistributedMembranaSessions%20%20%20WHERE%20EventDate%20=%20'2019-12-30'%20%20AND%20AdvertiserId%20IN%20('5ca1b7ff4d506e5c9425561f','5cab38364d506e43704dfbed','5c7e8ae24d506e4e1c4718b9','5c3748337bc72f52cca76da5','5c3c4bf67bc72fee74cd0b7d','5c3da7b07bc72f8714f4f518','5c1790fa7bc72fbbdcf91ad2','5d5d2e277bc72f22a0d85432','5d96ff6b4d506e24785379e6','5db696634d506e101413315d','5d8b34017bc72f693cd13195','5d550eab4d506e5decc14571','5d5510b27bc72f36f0cef3a2','5d64cc377bc72f31b4f2f0e4','5d64d7844d506e8998d0f4ed','5d5400f77bc72f41807b7652','5d5411547bc72f59a0d9a04b','5d5404f97bc72f41807b7668','5d540baf51665a09641900d1','5d5413207bc72f59a0d9a05c','5db1a2ef4d506e7484e847fb','5c1c99954d506ee3c8ab65bd','5c4820f94d506e4c78a98124','5c4832504d506e4c78a98712','5e09ac6d7bc72fc080038b4d','5c5828294d506e328cc7b43a','5da55f517bc72ff458ace8e3','5dde352a4d506e6c94a230eb','5db29f3c7bc72f04886aa67f','5c77f4354d506ec138a9fcc6','5c63ccad7bc72f217cd47fcd','5c98e1c24d506ee52839ab06','5e09ea3e7bc72f0c7cdaa633','5c77e0057bc72f1574d472f4','5c77b3374d506e5ab038b65e','5c987b1d7bc72fa3f8fcf267','5ca20e347bc72fa0cc36a428','5da6bebc4d506e85504f2081','5c98dd887bc72f7d4c087854','5c78e5474d506e82e85457e7','5e09f7267bc72f0c7cdad741','5ca3447b7bc72ff14c22db51','5cb055d14d506eac98bb7a30','5c4720a64d506e5c7064d69a','5e09f53a4d506efe4c7aaf45','5e09f41c4d506efe4c7aaf19','5e0b05604d506ef7906b61d4','5c6d1dbb4d506e8670470e5e','5e09b5e14d506efe4c7a368b','5e09faa17bc72f0c7cdaeb5f','5c4584837bc72f604cbbb55b','5e09bed14d506efe4c7a8b1b','5c98d93b4d506e2558dc7763','5e0491174d506ec0b0153eed','5cdd2d164d506e3e24695734','5cdd2f5b4d506e3e24695833','5cdd2f894d506e3e2469583f','5ce7a7957bc72fc2b0ed08cd','5ce7a7f74d506e57948f2be1','5cebe9987bc72f93200585d2','5cecf2534d506e1eec7d9d46','5cef72b94d506edbd4477f26','5d15d79c7bc72fc65898b059','5d15ecd04d506eb7cc309ec1','5d4128cd4d506e61b02d206c','5d63c6887bc72f5a70e35214','5d652e7c7bc72f3524fee3de','5d661fdb7bc72f0ac092aa15','5d6622717bc72f0ac092aa84','5d6676014d506e21602446e5','5d6cf5d97bc72f3280774a11','5d6d0df04d506ebb2c26f7b6','5d8a0a734d506e47c460f8d1','5d8dc1f64d506ecd7000b76e','5d8de7f07bc72ffa645deea4','5d9b17887bc72f88644a1821','5da97a777bc72fab68a69418','5db1c22b4d506e3298bc1ed9','5db1cf274d506e4a5cbf1cbe','5db284ef7bc72f04886aa279','5ddcd1c94d506ebf30c907ab','5ddce2607bc72fddc4ec2f7e','5e04af937bc72fb92c236349','5c74f55a4d506ee22003c8a9','5c7e8b9c7bc72fde44970de3','5c3eec367bc72f8714f4faa4','5c937c957bc72f13f84c6b5e','5cfa1d084d506ec1046538bd','5c4835367bc72ff79cd4da2c','5b11436e4d506ef0ac77c71f','5be9807d4d506e26b08c8f38','5c4eb1e24d506eec8ceb7b49','5c4ed6f84d506e0034d15f34','5c45916d4d506ec044d4cff5','5c4972b84d506e0894eb155e','5c4abc324d506e7a6cf9ca69','5c4abc974d506e7a6cf9ca79','5c4abd537bc72f54341f186d','5c6e51787bc72f99d02b2e36','5d9b330f4d506e0f84d8ae79')%20group%20BY%20Month%20FORMAT%20JSONEachRow");
            HttpWebResponse responseImpretion = (HttpWebResponse)requestImpretion.GetResponse();
            string response = null;
            using (Stream stream = responseImpretion.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    //response = reader.ReadToEnd();
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            responseImpretion.Close();
            //ResponseCollection<Statistics> statistics = JsonConvert.DeserializeObject<ResponseCollection<Statistics>>(response);

        }
    }
}
