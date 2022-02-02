using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio_1.Helpers
{
    public class DataManagement
    {
        private static DataManagement _instance = null;

        public static DataManagement Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DataManagement();
                }
                return _instance;
            }
            
        }

    }
}
