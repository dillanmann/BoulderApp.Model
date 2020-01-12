namespace BoulderApp.Model
{
    /// <summary>
    ///     Model of an attempt at a problem.
    /// </summary>
    public class ProblemAttempt : BoulderAppData
    {
        /// <summary>
        ///     The problem that was attempted.
        /// </summary>
        public Problem ProblemAttempted { get; set; }

        /// <summary>
        ///     Whether the problem was sent or not.
        /// </summary>
        public bool Sent { get; set; }

        /// <summary>
        /// Compare objects for equality
        /// </summary>
        /// <param name="obj">The other object</param>
        /// <returns>Whether the objects are equivalent</returns>
        public override bool Equals(object obj)
        {
            return (obj is ProblemAttempt attempt) ? Equals(attempt) : false;
        }

        /// <summary>
        /// Get the hash code of the object
        /// </summary>
        /// <returns>The object hash code</returns>
        public override int GetHashCode() =>
            (Id, ProblemAttempted, Sent).GetHashCode();

        private bool Equals(ProblemAttempt other)
        {
            return 
                ProblemAttempted.Equals(other.ProblemAttempted) 
                && Sent == other.Sent;
        }
    }
}
