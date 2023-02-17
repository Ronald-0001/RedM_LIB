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
    public class Lib : Natives
    {
        /// <summary>
        /// Waits in x seconds.
        /// </summary>
        /// <param name="_sec">Seconds to wait in.</param>
        public override void Wait(int _sec)
        {
            base.Wait(_sec * 1000);
        }

        /// <summary>
		/// Calculates the magnitude of a vector.
		/// </summary>
        public virtual float Vmag(Vector3 _vector)
        {
            return base.Vmag(_vector.X, _vector.Y, _vector.Z);
        }

        /// <summary>
		/// Calculates the magnitude of a vector but does not perform Sqrt operations. (Its way faster)
		/// </summary>
        public virtual float Vmag2(Vector3 _vector)
        {
            return base.Vmag2(_vector.X, _vector.Y, _vector.Z);
        }

        /// <summary>
		/// Calculates distance between vectors.
		/// </summary>
        public virtual float Vdist(Vector3 _vector1, Vector3 _vector2)
        {
            return base.Vdist(_vector1.X, _vector1.Y, _vector1.Z, _vector2.X, _vector2.Y, _vector2.Z);
        }

        /// <summary>
		/// Calculates distance between vectors but does not perform Sqrt operations. (Its way faster)
		/// </summary>
        public virtual float Vdist2(Vector3 _vector1, Vector3 _vector2)
        {
            return base.Vdist2(_vector1.X, _vector1.Y, _vector1.Z, _vector2.X, _vector2.Y, _vector2.Z);
        }
    }
}
