using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TARDIS
{
    /// <summary>
    /// the Universe class manages all of the game elements
    /// </summary>
    public class Universe
    {
        #region ***** define all lists to be maintained by the Universe object *****

        //
        // list of all space-time locations
        //
        public List<SpaceTimeLocation> SpaceTimeLocations { get; set; }

        //
        // list of all items
        //
        public List<Item> Items { get; set; }


        //
        // list of all treasure
        //
        public List<Treasure> Treasures { get; set; }

        //
        // list of all Daleks
        //
        public List<Dalek> Daleks { get; set; }

        #endregion

        #region ***** constructor *****

        //
        // default Universe constructor
        //
        public Universe()
        {
            //
            // instantiate the lists of space-time locations and game objects
            //
            this.SpaceTimeLocations = new List<SpaceTimeLocation>();
            this.Items = new List<Item>();
            this.Treasures = new List<Treasure>();
            this.Daleks = new List<Dalek>();
            

            //
            // add all of the space-time locations and game objects to their lists
            // 
            IntializeUniverseSpaceTimeLocations();
            IntializeUniverseItems();
            IntializeUniverseTreasures();
            IntializeUniverseDaleks();
        }

        #endregion

        #region ***** define methods to get the next available ID for game elements *****

        /// <summary>
        /// return the next available ID for a SpaceTimeLocation object
        /// </summary>
        /// <returns>next SpaceTimeLocationObjectID </returns>
        private int GetNextSpaceTimeLocationID()
        {
            int MaxID = 0;

            foreach (SpaceTimeLocation STLocation in SpaceTimeLocations)
            {
                if (STLocation.SpaceTimeLocationID > MaxID)
                {
                    MaxID = STLocation.SpaceTimeLocationID;
                }
            }

            return MaxID + 1;
        }

        /// <summary>
        /// return the next available ID for an item
        /// </summary>
        /// <returns>next GameObjectID </returns>
        private int GetNextItemID()
        {
            int MaxID = 0;

            foreach (Item item in Items)
            {
                if (item.GameObjectID > MaxID)
                {
                    MaxID = item.GameObjectID;
                }
            }

            return MaxID + 1;
        }

        /// <summary>
        /// return the next available ID for a treasure
        /// </summary>
        /// <returns>next GameObjectID </returns>
        private int GetNextTreasureID()
        {
            int MaxID = 0;

            foreach (Treasure treasure in Treasures)
            {
                if (treasure.GameObjectID > MaxID)
                {
                    MaxID = treasure.GameObjectID;
                }
            }

            return MaxID + 1;
        }

        #endregion

        #region ***** define methods to return game element objects *****

        /// <summary>
        /// get a SpaceTimeLocation object using an ID
        /// </summary>
        /// <param name="ID">space-time location ID</param>
        /// <returns>requested space-time location</returns>
        public SpaceTimeLocation GetSpaceTimeLocationByID(int ID)
        {
            SpaceTimeLocation spt = null;

            //
            // run through the space-time location list and grab the correct one
            //
            foreach (SpaceTimeLocation location in SpaceTimeLocations)
            {
                if (location.SpaceTimeLocationID == ID)
                {
                    spt = location;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw and exception
            //
            if (spt == null)
            {
                string feedbackMessage = $"The Space-Time Location ID {ID} does not exist in the current Universe.";
                throw new ArgumentException(ID.ToString(), feedbackMessage);
            }

            return spt;
        }

        /// <summary>
        /// get an item using an ID
        /// </summary>
        /// <param name="ID">game object ID</param>
        /// <returns>requested item object</returns>
        public Item GetItemtByID(int ID)
        {
            Item requestedItem = null;

            //
            // run through the item list and grab the correct one
            //
            foreach (Item item in Items)
            {
                if (item.GameObjectID == ID)
                {
                    requestedItem = item;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw and exception
            //
            if (requestedItem == null)
            {
                string feedbackMessage = $"The item ID {ID} does not exist in the current Universe.";
                throw new ArgumentException(ID.ToString(), feedbackMessage);
            }

            return requestedItem;
        }

        /// <summary>
        /// get a treasure using an ID
        /// </summary>
        /// <param name="ID">game object ID</param>
        /// <returns>requested treasure object</returns>
        public Treasure GetTreasureByID(int ID)
        {
            Treasure requestedTreasure = null;

            //
            // run through the item list and grab the correct one
            //
            foreach (Treasure treasure in Treasures)
            {
                if (treasure.GameObjectID == ID)
                {
                    requestedTreasure = treasure;
                };
            }

            //
            // the specified ID was not found in the universe
            // throw and exception
            //
            if (requestedTreasure == null)
            {
                string feedbackMessage = $"The treasure ID {ID} does not exist in the current Universe.";
                throw new ArgumentException(ID.ToString(), feedbackMessage);
            }

            return requestedTreasure;
        }

        #endregion

        #region ***** define methods to get lists of game elements by location *****


        /// get a list of items using a space-time location ID
        /// </summary>
        /// <param name="ID">space-time location ID</param>
        /// <returns>list of items in the specified location</returns>
        public List<Item> GetItemtsBySpaceTimeLocationID(int ID)
        {
            // TODO validate SpaceTimeLocationID

            List<Item> itemsInSpaceTimeLocation = new List<Item>();

            //
            // run through the item list and put all items in the current location
            // into a list
            //
            foreach (Item item in Items)
            {
                if (item.SpaceTimeLocationID == ID)
                {
                    itemsInSpaceTimeLocation.Add(item);
                }
            }

            return itemsInSpaceTimeLocation;
        }

        /// get a list of treasures using a space-time location ID
        /// </summary>
        /// <param name="ID">space-time location ID</param>
        /// <returns>list of treasures in the specified location</returns>
        public List<Treasure> GetTreasuresBySpaceTimeLocationID(int ID)
        {
            // TODO validate SpaceTimeLocationID

            List<Treasure> treasuresInSpaceTimeLocation = new List<Treasure>();

            //
            // run through the treasure list and put all items in the current location
            // into a list
            //
            foreach (Treasure treasure in Treasures)
            {
                if (treasure.SpaceTimeLocationID == ID)
                {
                    treasuresInSpaceTimeLocation.Add(treasure);
                }
            }

            return treasuresInSpaceTimeLocation;
        }

        public List<Dalek> GetDaleksBySpaceTimeLocationID(int ID)
        {
            // TODO validate DaleksTimeLocationID

            List<Dalek> daleksInSpaceTimeLocation = new List<Dalek>();

            //
            // run through the item list and put all items in the current location
            // into a list
            //
            foreach (Dalek dalek in Daleks)
            {
                if (dalek.SpaceTimeLocationID == ID)
                {
                    daleksInSpaceTimeLocation.Add(dalek);
                }
            }

            return daleksInSpaceTimeLocation;
        }

        #endregion

        #region ***** define methods to initialize all game elements *****

        /// <summary>
        /// initialize the universe with all of the space-time locations
        /// </summary>
        private void IntializeUniverseSpaceTimeLocations()
        {
            SpaceTimeLocations.Add(new SpaceTimeLocation
            {
                Name = "TARDIS Base",
                SpaceTimeLocationID = 1,
                Description = "The Norlon Corporation's secret laboratory located deep underground, " +
                              " beneath a nondescript 7-11 on the south-side of Toledo, OH.",
                Accessable = true
            });

            SpaceTimeLocations.Add(new SpaceTimeLocation
            {
                Name = "Xantoria Market",
                SpaceTimeLocationID = 2,
                Description = "The Xantoria market, once controlled by the Thorian elite, is now an " +
                              "open market managed by the Xantorian Commerce Coop. It is a place " +
                              "where many races from various systems trade goods.",
                Accessable = true
            });

            SpaceTimeLocations.Add(new SpaceTimeLocation
            {
                Name = "Felandrian Plains",
                SpaceTimeLocationID = 3,
                Description = "The Felandrian Plains are a common destination for tourist. " +
                  "Located just north of the equatorial line on the planet of Corlon, they" +
                  "provide excellent habitat for a rich ecosystem of flora and fauna.",
                Accessable = true
            });
        }

        /// <summary>
        /// initialize the universe with all of the items
        /// </summary>
        private void IntializeUniverseItems()
        {
            Items.Add(new Item
            {
                Name = "Key",
                GameObjectID = 1,
                Description = "A gold encrusted chest with strange markings lay next to a strange blue rock.",
                SpaceTimeLocationID = 3,
                HasValue = false,
                Value = 0,
                CanAddToInventory = true
            });

            Items.Add(new Item
            {
                Name = "Mirror",
                GameObjectID = 2,
                Description = "A full sized mirror with jewels decorating the border.",
                SpaceTimeLocationID = 2,
                HasValue = false,
                Value = 0,
                CanAddToInventory = false
            });

            Items.Add(new Item
            {
                Name = "Encabulator",
                GameObjectID = 3,
                Description = "A multi-function device carried by all Time Lords.",
                SpaceTimeLocationID = 0,
                HasValue = true,
                Value = 500,
                CanAddToInventory = true
            });
        }

        /// <summary>
        /// initialize the universe with all of the treasures
        /// </summary>
        private void IntializeUniverseTreasures()
        {
            Treasures.Add(new Treasure
            {
                Name = "Trantorian Ruby",
                TreasureType = Treasure.Type.Ruby,
                GameObjectID = 1,
                Description = "A deep red ruby the size of an egg.",
                SpaceTimeLocationID = 2,
                HasValue = true,
                Value = 25,
                CanAddToInventory = true
            });

            Treasures.Add(new Treasure
            {
                Name = "Lodestone",
                TreasureType = Treasure.Type.Lodestone,
                GameObjectID = 2,
                Description = "A deep red ruby the size of an egg.",
                SpaceTimeLocationID = 3,
                HasValue = true,
                Value = 15,
                CanAddToInventory = true
            });
        }

            private void IntializeUniverseDaleks()
        {
            Daleks.Add(new Dalek
            {
                Name = "Jerimiah the Dalek",
                SpaceTimeLocationID = 1,
                Description = "Jerimiah is a friendly Dalek, unless you make him mad.",
                HasMessage = true,
                Message = "Hello, Do you have any peanut butter?",
                NiceMessage = true,

            });
            Daleks.Add(new Dalek
            {
                Name = "Bob the Dalek",
                SpaceTimeLocationID = 2,
                Description = "Bob is an ugly Dalek with big eyes and no teeth.",
                HasMessage = true,
                Message = "Why have you come to here. I don't like you! Leave here now!",
                NiceMessage = false,
                
            });

            Daleks.Add(new Dalek
            {
                Name = "Fred the Dalek",
                SpaceTimeLocationID = 3,
                Description = "This guy is big and dumb.",
                HasMessage = true,
                Message = ($"Welcome, I am glad you are here. Can you help me find my shoes."),
                NiceMessage = true,
                
            });
        }

        #endregion

    }
}

