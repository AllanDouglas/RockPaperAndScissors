using System;
using System.Runtime.Serialization;

namespace RockPaperAndScissors.Src.Game.Core.Exceptions
{
    /// <summary>
    /// Throw when a weapon is no selected
    /// </summary>
    [Serializable]
    internal class WeaponNotSelectedExeption : Exception
    {
        #region Constructors Auto Generated ;)
        public WeaponNotSelectedExeption()
        {
        }

        public WeaponNotSelectedExeption(string message) : base(message)
        {
        }

        public WeaponNotSelectedExeption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeaponNotSelectedExeption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        } 
        #endregion
    }
}