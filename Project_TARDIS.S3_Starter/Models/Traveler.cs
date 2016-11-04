using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TARDIS
{
    public class Traveler : Character
    {
        #region FIELDS

        private List<Item> _travelersItems;
        private List<Treasure> _travelersTreasures;

        #endregion

        public List<Item> TravelersItems
        {
            get { return _travelersItems; }
            set { _travelersItems = value; }
        }

        public List<Treasure> TravelersTreasures
        {
            get { return _travelersTreasures; }
            set { _travelersTreasures = value; }
        }

        #region PROPERTIES



        #endregion


        #region CONSTRUCTORS

        public Traveler()
        {
            _travelersItems = new List<Item>();
            _travelersTreasures = new List<Treasure>();
        }

        public Traveler(string name, RaceType race, int spaceTimeLocationID) : base(name, race, spaceTimeLocationID)
        {

        }

        #endregion


        #region METHODS



        #endregion
    }
}
