using System;
using System.Runtime.Serialization;

namespace RockPaperAndScissors.Src.Game.Core.Exceptions
{
    [Serializable]
    internal class BadGameModeSetupException : Exception
    {
        public BadGameModeSetupException()
        {
        }

        public BadGameModeSetupException(string message) : base(message)
        {
        }

        public BadGameModeSetupException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected BadGameModeSetupException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}