namespace BoulderApp.Model
{
    /// <summary>
    ///     Model of a bouldering problem.
    /// </summary>
    public class Problem : BoulderAppData
    {
        /// <summary>
        ///     The difficulty of the problem in V grade.
        /// </summary>
        public VGrade Grade { get; set; }

        /// <summary>
        /// Compare objects for equality
        /// </summary>
        /// <param name="obj">The other object</param>
        /// <returns>Whether the objects are equivalent</returns>
        public override bool Equals(object obj)
        {
            return (obj is Problem problem) ? Equals(problem) : false;
        }

        /// <summary>
        /// Get the hash code of the object
        /// </summary>
        /// <returns>The object hash code</returns>
        public override int GetHashCode() =>
            (Id, Name, Grade).GetHashCode();

        private bool Equals(Problem other)
        {
            return base.Equals(other)
                && Grade == other.Grade;
        }
    }
}