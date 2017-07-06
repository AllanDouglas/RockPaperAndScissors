using System;

namespace RockPaperAndScissors.Src.Game.Utils
{
    /// <summary>
    /// Provide a Random numbers methods
    /// </summary>
    static class Random
    {
        /// <summary>
        /// Unique instance
        /// </summary>
        static System.Random _random;

        /// <summary>
        /// Get a random number between from and to like:
        /// from<=return<to
        /// </summary>
        /// <param name="from">included</param>
        /// <param name="to">excluded</param>
        /// <returns></returns>
        public static int Range(int from, int to)
        {
            if (_random == null)
                _random = new System.Random();

            return _random.Next(from, to);
        }


    }
}
