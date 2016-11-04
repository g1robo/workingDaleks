using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TARDIS
{
    public class GallifrianMirror : GameObject
    {
        public override int GameObjectID { get; set; }

        public override string Name { get; set; }

        public override string Description { get; set; }

        public override int SpaceTimeLocationID { get; set; }

        public override bool HasValue { get; set; }

        public override int Value { get; set; }

        public override bool CanAddToInventory { get; set; }

        public bool TransportEmpty { get; set; }

        public int TransportObjectID { get; set; }

        public string SpaceTimeTransporterMessage()
        {
            string message = null;

            if (this.TransportEmpty)
            {
                message = "No object currently in transport."; 
            }
            else
            {
                // TODO Get transporter object
                message = "The transport is currently holding ";
            }

            return message;
        }

        public string InitiateSpaceTimeTransport()
        {
            string resultMessage = null;

            return resultMessage;
        }
    }
}
