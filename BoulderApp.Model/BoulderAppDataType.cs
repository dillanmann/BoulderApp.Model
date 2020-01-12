namespace BoulderApp.Model
{
    /// <summary>
    /// Enumeration of types of <see cref="BoulderAppData"/>.
    /// </summary>
    public enum BoulderAppDataType
    {
        /// <summary>
        /// A center.
        /// </summary>
        Center = 0,

        /// <summary>
        /// A circuit.
        /// </summary>
        Circuit,
        
        /// <summary>
        /// A problem attempt.
        /// </summary>
        ProblemAttempt,

        /// <summary>
        /// A problem.
        /// </summary>
        Problem,

        /// <summary>
        /// A session.
        /// </summary>
        Session,

        /// <summary>
        /// A user.
        /// </summary>
        User
    }
}
