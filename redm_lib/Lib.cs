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
    /// Replaces CitizenFX.Core.Native.API;
    /// </summary>
    public partial class Lib
    {
        // :####################: //
        // : namespace: BUILTIN : //
        // :####################: //
        /// <summary>
        /// Calculates the magnitude of a vector.
        /// </summary>
        public static float Vmag(Vector3 _vector) =>
            Vmag(_vector.X, _vector.Y, _vector.Z);
        /// <summary>
        /// Calculates the magnitude of a vector but does not perform Sqrt operations. (Its way faster)
        /// </summary>
        public static float Vmag2(Vector3 _vector) =>
            Vmag2(_vector.X, _vector.Y, _vector.Z);
        /// <summary>
        /// Calculates distance between vectors.
        /// </summary>
        public static float Vdist(Vector3 _vector1, Vector3 _vector2) =>
            Vdist(_vector1.X, _vector1.Y, _vector1.Z, _vector2.X, _vector2.Y, _vector2.Z);
        /// <summary>
        /// Calculates distance between vectors but does not perform Sqrt operations. (Its way faster)
        /// </summary>
        public static float Vdist2(Vector3 _vector1, Vector3 _vector2) =>
            Vdist2(_vector1.X, _vector1.Y, _vector1.Z, _vector2.X, _vector2.Y, _vector2.Z);
        // :#################: //
        // : namespace: MISC : //
        // :#################: //
        /// <summary>
        /// https://github.com/femga/rdr3_discoveries/blob/master/weather/weather_types.lua
        /// </summary>
        public static void SetWeatherType(WeatherType _weatherType, bool _p1 = true, bool _p2 = true, bool _transition = true, float _transitionTime = 15.0f, bool _p5 = false) =>
            SetWeatherType(_weatherType.Hash, _p1, _p2, _transition, _transitionTime, _p5);
        /// <summary>
        /// https://github.com/femga/rdr3_discoveries/blob/master/weather/weather_variations.lua
        /// </summary>
        public static void SetWeatherVariation(WeatherType _weatherType, WeatherVariation _variation) =>
            SetWeatherVariation(_weatherType.Name, _variation.Name);
        /// <summary>
        /// https://github.com/femga/rdr3_discoveries/blob/master/weather/weather_types.lua
        /// </summary>
        public static void ClearWeatherVariation(WeatherType _weatherType, bool _p1 = true) =>
            ClearWeatherVariation(_weatherType.Name, _p1);
    }
}
