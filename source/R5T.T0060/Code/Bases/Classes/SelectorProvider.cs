using System;


namespace R5T.T0060
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class SelectorProvider : ISelectorProvider
    {
        #region Static
        
        public static SelectorProvider Instance { get; } = new();

        #endregion
    }
}