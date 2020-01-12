using System;

namespace BoulderApp.Model
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    /// <summary>
    ///     BoulderApp Data
    /// </summary>
    public abstract class BoulderAppData
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        /// <summary>
        ///     Id of the item.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Description of the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Compare objects for equality
        /// </summary>
        /// <param name="obj">The other object</param>
        /// <returns>Whether the objects are equivalent</returns>
        public override bool Equals(object obj)
        {
            return (obj is BoulderAppData data) ? Equals(data) : false;
        }

        private bool Equals (BoulderAppData other)
        {
            return Id == other.Id && Name == other.Name;
        }
    }
}
