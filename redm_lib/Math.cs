using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;

namespace RedLib
{
    /// <summary>
    /// Basic Math Operation's
    /// </summary>
    public static class Math
    {
        // Lerp Function's
        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        /// <param name="A">The start value.</param>
        /// <param name="B">The end value.</param>
        /// <param name="T">The interpolation value between the two.</param>
        /// <returns>A+(B-A)*T</returns>
        public static float Lerp(float A, float B, float T)
        {
            return A + (B - A) * T;
        }
        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        /// <param name="A">The start value.</param>
        /// <param name="B">The end value.</param>
        /// <param name="T">The interpolation value between the two.</param>
        /// <returns>A+(B-A)*T</returns>
        public static Vector2 Lerp(Vector2 A, Vector2 B, float T)
        {
            return A + (B - A) * T;
        }
        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        /// <param name="A">The start value.</param>
        /// <param name="B">The end value.</param>
        /// <param name="T">The interpolation value between the two.</param>
        /// <returns>A+(B-A)*T</returns>
        public static Vector3 Lerp(Vector3 A, Vector3 B, float T)
        {
            return A + (B - A) * T;
        }
        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        /// <param name="A">The start value.</param>
        /// <param name="B">The end value.</param>
        /// <param name="T">The interpolation value between the two.</param>
        /// <returns>A+(B-A)*T</returns>
        public static Vector4 Lerp(Vector4 A, Vector4 B, float T)
        {
            return A + (B - A) * T;
        }

        // SIN SAN SON BING BANG BONG ...

    }
}
