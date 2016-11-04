using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TARDIS
{
    public abstract class GameObject
    {
        #region FIELDS

        #endregion

        #region PROPERTIES

        public abstract int GameObjectID { get; set; }

        public abstract string Name { get; set; }

        public abstract string Description { get; set; }

        public abstract int SpaceTimeLocationID { get; set; }

        public abstract bool HasValue { get; set; }

        public abstract int Value { get; set; }

        public abstract bool CanAddToInventory { get; set; }

        public virtual bool InInventory { get; set; }

        #endregion


        #region CONSTRUCTORS

        public GameObject() { }

        #endregion


        #region METHODS



        #endregion




    }
}
