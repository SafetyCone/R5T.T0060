using System;


namespace R5T.T0060
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SelectorProivder : ISelectorProivder
    {
        #region Static
        
        public static SelectorProivder Instance { get; } = new();

        #endregion
    }
}