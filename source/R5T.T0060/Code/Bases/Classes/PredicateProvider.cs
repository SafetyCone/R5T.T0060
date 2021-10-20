using System;


namespace R5T.T0060
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class PredicateProvider : IPredicateProvider
    {
        #region Static
        
        public static PredicateProvider Instance { get; } = new();

        #endregion
    }
}