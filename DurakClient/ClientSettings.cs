using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DurakClient;

namespace DurakClient
{
    public class ClientSettings
    {
        private static readonly Lazy<ClientSettings> settings =
            new Lazy<ClientSettings>(() => new ClientSettings());
        public static ClientSettings Instance {
            get
            { return settings.Value; }
        }

        public string PlayerName { get; set; }
        public int PlayerAmount { get; set; }
        public int GameDeckSize { get; set; }
        public string Difficulty { get; set; }


        private ClientSettings() 
        {
            
            
        }
    }
}
