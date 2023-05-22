using System;

namespace Enemies
{
    ///<summary>
    /// This is an empty public Class
    ///</summary>
    public class Zombie
    {
        ///<summary>
        /// int health = 0
        ///</summary>

        public int health;

        ///<summary>
        /// public constructor
        /// </summary>

        public Zombie()
        {

        }

        ///<summary>
        /// new public constructor that specifies a value for
        /// the zombie health
        ///</summary>

        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }
    }
}
