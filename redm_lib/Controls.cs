using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLib
{
    public struct GameControl
    {
        public readonly uint Hash;
        public readonly string Name;
        public readonly string QWERTY;
        public readonly string GameVersion;

        public GameControl(uint _Hash, string _Name, string _QWERTY = "", string _GameVersion = "")
        {
            this.Hash = _Hash;
            this.Name = _Name;
            this.QWERTY = _QWERTY;
            this.GameVersion = _GameVersion;
        }

        public override string ToString() => $"{Name}";
    }
    public static class Controls
    {
        public static GameControl INPUT_FRONTEND_RIGHT_AXIS_X = new GameControl(0x3D23549A, "INPUT_FRONTEND_RIGHT_AXIS_X", "[", "1207.80");
    }
}
