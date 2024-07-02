

namespace Oyster.Models
{
    public class Zone
    {
        private readonly string _zone;

        public Zone(string zone)
        {
            _zone = zone;
        }

        public string GetZone()
        {
            return _zone;
        }
    }
}
