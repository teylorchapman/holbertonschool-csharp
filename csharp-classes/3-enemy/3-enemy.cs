using System;

namespace Enemies
{
    private int health;
    
    ///<summary>
    /// This is an empty public Class.
    ///</summary>
    public class Zombie
    {
        ///<summary>
        /// int health = 0
        ///</summary>

        private int health;

        ///<summary>
        /// public constructor
        /// </summary>

        public Zombie()
        {
            health = 0;
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
