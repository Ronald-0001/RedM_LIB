using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLib.Junk
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
        public IdentityTable Identity { get; private set; }
        public Player(Source _source)
        {
            this.Source = _source;
            this.Identity = new IdentityTable(_source);
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
    }
    /// <summary>
    /// Player identifier's
    /// </summary>
    public struct IdentityTable
    {
        public bool HasLicense { get; private set; }
        public string License { get; private set; }
        public bool HasLicense2 { get; private set; }
        public string License2 { get; private set; }
        public bool HasDiscord { get; private set; }
        public string Discord { get; private set; }
        public bool HasSteam { get; private set; }
        public string Steam { get; private set; }
        public bool HasEndpoint { get; private set; }
        public string Endpoint { get; private set; }
        public bool HasXboxLive { get; private set; }
        public string XboxLive { get; private set; }
        public bool HasMicrosoft { get; private set; }
        public string Microsoft { get; private set; }
        public IdentityTable(Source _source)
        {
            this.HasLicense = false;
            this.License = "";
            //
            this.HasLicense2 = false;
            this.License2 = "";
            //
            this.HasDiscord = false;
            this.Discord = "";
            //
            this.HasSteam = false;
            this.Steam = "";
            //
            this.HasEndpoint = false;
            this.Endpoint = "";
            //
            this.HasXboxLive = false;
            this.XboxLive = "";
            //
            this.HasMicrosoft = false;
            this.Microsoft = "";
            //
            FetchTable(_source);
        }
        private void FetchTable(Source _source)
        {
            for (int i = 0; i < Lib.GetNumPlayerIdentifiers(_source.Int.ToString()); i++)
            {
                string identifier = Lib.GetPlayerIdentifier(_source.Int.ToString(), i);
                string key = identifier.Substring(identifier.IndexOf(":") + 1);
                switch (identifier.Substring(0, identifier.IndexOf(":")))
                {
                    case "license":
                        this.HasLicense = true;
                        this.License = key;
                        break;
                    case "license2":
                        this.HasLicense2 = true;
                        this.License2 = key;
                        break;
                    case "discord":
                        this.HasDiscord = true;
                        this.Discord = key;
                        break;
                    case "steam":
                        this.HasSteam = true;
                        this.Steam = key;
                        break;
                    case "ip":
                        this.HasEndpoint = true;
                        this.Endpoint = key;
                        break;
                    case "xbl":
                        this.HasXboxLive = true;
                        this.XboxLive = key;
                        break;
                    case "live":
                        this.HasMicrosoft = true;
                        this.Microsoft = key;
                        break;
                    default:
                        Print.Error($"Unknown Identifier: {identifier}");
                        break;
                }
            }
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
            if (Int32.TryParse(_source_str.Substring(_source_str.IndexOf(":") + 1), out int i)) Int = i;
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
}
