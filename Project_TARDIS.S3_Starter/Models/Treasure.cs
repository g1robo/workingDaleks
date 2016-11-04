using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TARDIS
{
    /// <summary>
    /// define all treasure objects
    /// </summary>
    public class Treasure : GameObject
    {
        public enum Type
        {
            Diamond,
            Ruby,
            Emerald,
            Lodestone,
            GoldCoin,
            SilverCoin,
            BronzeCoin
        }

        public override int GameObjectID { get; set; }

        public override string Name { get; set; }

        public Type TreasureType { get; set; }

        public override string Description { get; set; }

        public override int SpaceTimeLocationID { get; set; }

        public override bool HasValue { get; set; }

        public override int Value { get; set; }

        public override bool CanAddToInventory { get; set; }

    }
}
