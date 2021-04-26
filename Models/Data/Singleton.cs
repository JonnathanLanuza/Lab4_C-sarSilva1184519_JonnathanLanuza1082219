using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4_CésarSilva1184519_JonnathanLanuza1082219.Models.Data
{
    public class Singleton
    {
        private readonly static Singleton MCInstance = new Singleton();
        public List<Developer> MDeveloperList;
        public List<DevData> MDevDataList;

        private Singleton()
        {
            MDeveloperList = new List<Developer>();
            MDevDataList = new List<DevData>();
        }

        public static Singleton Instance
        {
            get
            {
                return MCInstance;
            }
        }

    }
}
