using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLib
{
    /// <summary>
    /// Replaces CitizenFX.Core.Player "CitizenFX.Core.Player is not valid with redm's dll???"
    /// //
    /// ServerEvent([FromSource] string source_str)
    /// Player player = source_str;
    /// </summary>
    public struct Player // RedLib version of CitizenFX.Core.Player
    {
        public int ServerId { get { return Source.Int; } }
        public Source Source { get; private set; }
        public UUID Uuid { get; private set; }
        public Player(Source _source)
        {
            this.Source = _source;
            this.Uuid = new UUID();
        }
        public override string ToString() => this.Source.Int.ToString();
        //
        public static implicit operator Player(Source _source)  // implicit Source to Player conversion operator
        {
            return new Player(_source); // implicit conversion
        }
        public static implicit operator Player(string _source_str)  // implicit string to Player conversion operator
        {
            return new Player(_source_str); // implicit conversion
        }
        public static implicit operator Source(Player _player)  // implicit Player to Source conversion operator
        {
            return _player.Source; // implicit conversion
        }
        public static implicit operator string(Player _player)  // implicit Player to string conversion operator
        {
            return _player.Source.String; // implicit conversion
        }
        public static implicit operator int(Player _player)  // implicit Player to int conversion operator
        {
            return _player.Source.Int; // implicit conversion
        }
        public static implicit operator UUID(Player _player)  // implicit Player to UUID conversion operator
        {
            return _player.Uuid; // implicit conversion
        }
    }
    /// <summary>
    /// ServerEvent([FromSource] string source_str)
    /// Source source = source_str;
    /// </summary>
    public struct Source // Used with [FromSource] in server events
    {
        public string String { get; private set; }
        public int Int { get; private set; }
        public Source(string _source_str)
        {
            String = _source_str;
            if (Int32.TryParse(_source_str.Substring(4), out int i)) Int = i;
            else { Print.Error($"Failed to parse Source: {_source_str}"); Int = -1; }
        }
        public override string ToString() => this.String;
        //
        public static implicit operator Source(string _source_str)  // implicit string to Source conversion operator
        {
            return new Source(_source_str); // implicit conversion
        }
        public static implicit operator string(Source _source)  // implicit Source to string conversion operator
        {
            return _source.String; // implicit conversion
        }
        public static implicit operator int(Source _source)  // implicit Source to int conversion operator
        {
            return _source.Int; // implicit conversion
        }
    }
    /// <summary>
    /// Unique User Identifier
    /// //
    /// Nullable UUID Struct
    /// </summary>
    public struct UUID // Unique User Identifier
    {
        private readonly uint? Uint;
        public bool Valid { get { return this.Uint.HasValue; } }
        public UUID(uint? _uuid = null)
        {
            this.Uint = _uuid;
        }
        public override string ToString() => this.Uint.HasValue ? this.Uint.Value.ToString() : "null";
        //
        public static implicit operator UUID(uint _uuid)  // implicit uint to uuid conversion operator
        {
            return new UUID(_uuid); // implicit conversion
        }
        public static implicit operator uint(UUID _uuid)  // implicit uuid to uint conversion operator
        {
            return _uuid.Uint.GetValueOrDefault(0); // implicit conversion
        }
    }
}
