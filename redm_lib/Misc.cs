using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLib
{
    public struct SID // Server Identifier
    {
        private readonly int sid;
        public SID(int _id)
        {
            this.sid = _id;
        }
        public override string ToString() => $"{this.sid}";
        //
        public static implicit operator SID(int _sid)  // explicit int to sid conversion operator
        {
            return new SID(_sid); // explicit conversion
        }
        public static implicit operator int(SID _sid)  // implicit sid to int conversion operator
        {
            return _sid.sid; // implicit conversion
        }
    }
    public struct UUID // Unique User Identifier
    {
        private readonly uint uuid;
        public UUID(uint _uuid)
        {
            this.uuid = _uuid;
        }
        public override string ToString() => $"{this.uuid}";
        //
        public static implicit operator UUID(int _uuid)  // explicit uint to uuid conversion operator
        {
            return new UUID((uint)_uuid); // explicit conversion
        }
        public static implicit operator UUID(uint _uuid)  // explicit uint to uuid conversion operator
        {
            return new UUID(_uuid); // explicit conversion
        }
        public static implicit operator uint(UUID _uuid)  // implicit uuid to uint conversion operator
        {
            return _uuid.uuid; // implicit conversion
        }
    }
}
