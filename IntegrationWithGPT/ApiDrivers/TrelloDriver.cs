using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrelloNet;

namespace IntegrationWithGPT.TrelloDriver
{
    public class TrelloDriver : IDriver
    {
        public string SendRequest()
        {
            string apiKey = "secret";
            string token = "secret";

            var trelloToken = new Trello(apiKey);

            var getBoards = trelloToken.Boards.ForMe();

            foreach (var item in getBoards)
            {
                Console.WriteLine(item.Name, item.Url, item.LabelNames);
            }
            return null;
        }
    }
}
