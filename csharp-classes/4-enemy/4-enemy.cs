﻿using System;

namespace Enemies
{
    
    
    ///<summary>
    /// This is an empty public Class.
    ///</summary>
    
    public class Zombie
    {
        private int health;
        private string name;        
        
        ///<summary>
        /// int health = 0
        ///</summary>


        ///<summary>
        /// public constructor
        /// </summary>

        public Zombie()
        {

        }

        ///<summary>
        /// new public constructor that specifies a value for
        /// the zombie health.
        ///</summary>

        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            health = value;
            name = "(No name)";
        }


        ///<summary>
        /// getting or setting the Zombies name
        ///</summary>

        public string Name
        {
            get { return name == null ? "(No name)" : name; }
            set { name = value; }
        }


        ///<summary>
        /// Getter for da health.
        /// Returns the value of health.
        ///</summary>

        public int GetHealth()
        {
            return health;
        }
    }
}
