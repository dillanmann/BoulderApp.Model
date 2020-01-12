namespace BoulderApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    ///     Model of a bouldering center / gym.
    /// </summary>
    public class Center : BoulderAppData
    {
        /// <summary>
        ///     The circuits
        /// </summary>
        public IEnumerable<Circuit> Circuits { get; set; } = new List<Circuit>();

        /// <summary>
        /// Compare objects for equality
        /// </summary>
        /// <param name="obj">The other object</param>
        /// <returns>Whether the objects are equivalent</returns>
        public override bool Equals(object obj)
        {
            return (obj is Center center) ? Equals(center) : false;
        }

        /// <summary>
        /// Get the hash code of the object
        /// </summary>
        /// <returns>The object hash code</returns>
        public override int GetHashCode() =>
            (Id, Name, Circuits).GetHashCode();

        private bool Equals(Center other)
        {
            return base.Equals(other)
                && Circuits == null ? other.Circuits == null : false 
                ||  Circuits.All(other.Circuits.Contains);                
        }
    }
}
