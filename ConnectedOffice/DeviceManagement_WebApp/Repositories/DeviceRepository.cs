using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Linq;

namespace DeviceManagement_WebApp.Repositories
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {

        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {
        }

        public Device GetMostRecentService()
        {
            return _context.Device.OrderByDescending(device => device.DateCreated).FirstOrDefault();
        }

    }
}
