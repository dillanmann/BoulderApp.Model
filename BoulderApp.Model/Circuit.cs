namespace BoulderApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    ///     Representation of a bouldering circuit with a list of problems.
    /// </summary>
    public class Circuit : BoulderAppData
    {
        /// <summary>
        ///     Date the circuit was set.
        /// </summary>
        public DateTime DateUp { get; set; }

        /// <summary>
        ///     Date circuit will be taken down.
        /// </summary>
        public DateTime DateDown { get; set; }

        /// <summary>
        ///     List of problems within the circuit.
        /// </summary>
        public IEnumerable<Problem> Problems { get; set; } = new List<Problem>();

        /// <summary>
        /// Compare objects for equality
        /// </summary>
        /// <param name="obj">The other object</param>
        /// <returns>Whether the objects are equivalent</returns>
        public override bool Equals(object obj)
        {
            return (obj is Circuit circuit) ? Equals(circuit) : false;
        }

        /// <summary>
        /// Get the hash code of the object
        /// </summary>
        /// <returns>The object hash code</returns>
        public override int GetHashCode() =>
            (Id, Name, DateUp, DateDown, Problems).GetHashCode();

        private bool Equals(Circuit other)
        {
            return base.Equals(other)
                && DateUp == other.DateUp
                && DateDown == other.DateDown
                && Problems.All(other.Problems.Contains);
        }
    }
}
