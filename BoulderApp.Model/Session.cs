namespace BoulderApp.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    ///     Model of a bouldering session at a climbing center.
    /// </summary>
    public class Session : BoulderAppData
    {
        /// <summary>
        ///     Date the session was completed.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        ///     Center the session was completed at.
        /// </summary>
        public Center Center { get; set; }

        /// <summary>
        ///     User who completed the session.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// The problem attempts
        /// </summary>
        public ICollection<ProblemAttempt> ProblemAttempts { get; set; } = new List<ProblemAttempt>();

        /// <summary>
        /// Compare objects for equality
        /// </summary>
        /// <param name="obj">The other object</param>
        /// <returns>Whether the objects are equivalent</returns>
        public override bool Equals(object obj)
        {
            return (obj is Session session) ? Equals(session) : false;
        }

        /// <summary>
        /// Get the hash code of the object
        /// </summary>
        /// <returns>The object hash code</returns>
        public override int GetHashCode() =>
            (Id, Date, Center, User, ProblemAttempts).GetHashCode();

        private bool Equals(Session other)
        {
            return base.Equals(other)
                && Date == other.Date
                && Center.Equals(other.Center)
                && User.Equals(other.User)
                && ProblemAttempts.All(other.ProblemAttempts.Contains);
        }
    }
}
