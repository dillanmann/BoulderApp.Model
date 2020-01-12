namespace BoulderApp.Model
{
    /// <summary>
    ///     Model of a user.
    /// </summary>
    public class User : BoulderAppData
    {
        /// <summary>
        ///     Users email address
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Compare objects for equality
        /// </summary>
        /// <param name="obj">The other object</param>
        /// <returns>Whether the objects are equivalent</returns>
        public override bool Equals(object obj)
        {
            return (obj is User user) ? Equals(user) : false;
        }

        /// <summary>
        /// Get the hash code of the object
        /// </summary>
        /// <returns>The object hash code</returns>
        public override int GetHashCode() =>
            (Id, Email, Name).GetHashCode();

        private bool Equals(User other)
        {
            return base.Equals(other)
                && Email == other.Email;
        }
    }
}
