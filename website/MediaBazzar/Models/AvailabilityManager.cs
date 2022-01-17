using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaBazaarWebsite
{
    public class AvailabilityManager : IAvailabilityManager
    {
        IDBAvailabilityManager DBAvailabilityManager { get; set; }
        public AvailabilityManager()
        {
            DBAvailabilityManager = new DBAvailabilityManager();
        }
        public bool EnterAvailability()
        {
            return DBAvailabilityManager.EnterAvailability();
        }
    }
}
