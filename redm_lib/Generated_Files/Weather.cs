// made by Ronald#1000 using his automated composing software
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedLib
{
	public struct WeatherType
	{
		public readonly uint Hash;
		public readonly string Name;
		public WeatherType(uint _Hash, string _Name)
		{
			this.Hash = _Hash;
			this.Name = _Name;
		}
		public override string ToString() => $"{this.Name}";
	}
	public struct WeatherVariation
	{
		public readonly string Name;
		public WeatherVariation(string _Name)
		{
			this.Name = _Name;
		}
		public override string ToString() => $"{this.Name}";
	}
	public static class Weather
	{
		public static WeatherType BLIZZARD = new WeatherType(0x27EA2814, "BLIZZARD");
		public static WeatherType CLOUDS = new WeatherType(0x30FDAF5C, "CLOUDS");
		public static WeatherType DRIZZLE = new WeatherType(0x995C7F44, "DRIZZLE");
		public static WeatherType FOG = new WeatherType(0xD61BDE01, "FOG");
		public static WeatherType GROUNDBLIZZARD = new WeatherType(0x7F622122, "GROUNDBLIZZARD");
		public static WeatherType HAIL = new WeatherType(0x75A9E268, "HAIL");
		public static WeatherType HIGHPRESSURE = new WeatherType(0xF5A87B65, "HIGHPRESSURE");
		public static WeatherType HURRICANE = new WeatherType(0x320D0951, "HURRICANE");
		public static WeatherType MISTY = new WeatherType(0x5974E8E5, "MISTY");
		public static WeatherType OVERCAST = new WeatherType(0xBB898D2D, "OVERCAST");
		public static WeatherType OVERCASTDARK = new WeatherType(0x19D4F1D9, "OVERCASTDARK");
		public static WeatherType RAIN = new WeatherType(0x54A69840, "RAIN");
		public static WeatherType SANDSTORM = new WeatherType(0xB17F6111, "SANDSTORM");
		public static WeatherType SHOWER = new WeatherType(0xE72679D5, "SHOWER");
		public static WeatherType SLEET = new WeatherType(0x0CA71D7C, "SLEET");
		public static WeatherType SNOW = new WeatherType(0xEFB6EFF6, "SNOW");
		public static WeatherType SNOWLIGHT = new WeatherType(0x23FB812B, "SNOWLIGHT");
		public static WeatherType SUNNY = new WeatherType(0x614A1F91, "SUNNY");
		public static WeatherType THUNDER = new WeatherType(0xB677829F, "THUNDER");
		public static WeatherType THUNDERSTORM = new WeatherType(0x7C1C4A13, "THUNDERSTORM");
		public static WeatherType WHITEOUT = new WeatherType(0x2B402288, "WHITEOUT");
		public static WeatherType SNOWCLEARING = new WeatherType(0x641DFC11, "SNOWCLEARING");
		// BLIZZARD
		public static WeatherVariation BLIZZARD_winter2 = new WeatherVariation("BLIZZARD_winter2");
		// CLOUDS
		public static WeatherVariation CLOUDS_mudtown3B = new WeatherVariation("CLOUDS_mudtown3B");
		// DRIZZLE
		public static WeatherVariation DRIZZLE_finale1 = new WeatherVariation("DRIZZLE_finale1");
		public static WeatherVariation DRIZZLE_finale1B = new WeatherVariation("DRIZZLE_finale1B");
		// FOG
		public static WeatherVariation FOG_guama = new WeatherVariation("FOG_guama");
		public static WeatherVariation Fog_MP_Pred = new WeatherVariation("Fog_MP_Pred");
		// GROUNDBLIZZARD
		public static WeatherVariation GROUNDBLIZZARD_odriscols = new WeatherVariation("GROUNDBLIZZARD_odriscols");
		public static WeatherVariation GROUNDBLIZZARD_winter2 = new WeatherVariation("GROUNDBLIZZARD_winter2");
		// HIGHPRESSURE
		public static WeatherVariation HIGHPRESSURE_guama = new WeatherVariation("HIGHPRESSURE_guama");
		// HURRICANE
		public static WeatherVariation HURRICANE_guama = new WeatherVariation("HURRICANE_guama");
		// MISTY
		public static WeatherVariation MISTY_braithwaites3 = new WeatherVariation("MISTY_braithwaites3");
		public static WeatherVariation MISTY_finale1 = new WeatherVariation("MISTY_finale1");
		public static WeatherVariation MISTY_finale1B = new WeatherVariation("MISTY_finale1B");
		public static WeatherVariation MISTY_finale2 = new WeatherVariation("MISTY_finale2");
		public static WeatherVariation MISTY_guama = new WeatherVariation("MISTY_guama");
		public static WeatherVariation MISTY_MP_intro = new WeatherVariation("MISTY_MP_intro");
		public static WeatherVariation MISTY_MP_Pred = new WeatherVariation("MISTY_MP_Pred");
		public static WeatherVariation MISTY_train1 = new WeatherVariation("MISTY_train1");
		// OVERCASTDARK
		public static WeatherVariation OVERCASTDARK_finale2 = new WeatherVariation("OVERCASTDARK_finale2");
		public static WeatherVariation OVERCASTDARK_Gang2 = new WeatherVariation("OVERCASTDARK_Gang2");
		public static WeatherVariation OVERCASTDARK_native3 = new WeatherVariation("OVERCASTDARK_native3");
		public static WeatherVariation OVERCASTDARK_STD1 = new WeatherVariation("OVERCASTDARK_STD1");
		// SHOWER
		public static WeatherVariation SHOWER_finale2 = new WeatherVariation("SHOWER_finale2");
		public static WeatherVariation SHOWER_guama = new WeatherVariation("SHOWER_guama");
		public static WeatherVariation shower_MP_Pred = new WeatherVariation("shower_MP_Pred");
		// SNOW
		public static WeatherVariation SNOW_Odriscolls1 = new WeatherVariation("SNOW_Odriscolls1");
		public static WeatherVariation SNOW_Pearson1 = new WeatherVariation("SNOW_Pearson1");
		// SNOWLIGHT
		public static WeatherVariation SNOWLIGHT_finale2 = new WeatherVariation("SNOWLIGHT_finale2");
		public static WeatherVariation SNOWLIGHT_Odriscolls1 = new WeatherVariation("SNOWLIGHT_Odriscolls1");
		public static WeatherVariation SNOWLIGHT_Pearson1 = new WeatherVariation("SNOWLIGHT_Pearson1");
		// SUNNY
		public static WeatherVariation Sunny_odriscols4 = new WeatherVariation("Sunny_odriscols4");
		// THUNDERSTORM
		public static WeatherVariation THUNDERSTORM_MP_Pred = new WeatherVariation("THUNDERSTORM_MP_Pred");
		public static WeatherVariation THUNDERSTORM_nativeSon3 = new WeatherVariation("THUNDERSTORM_nativeSon3");
		// WHITEOUT
		public static WeatherVariation WHITEOUT_winter1 = new WeatherVariation("WHITEOUT_winter1");
		// SNOWCLEARING
		public static WeatherVariation SNOWCLEARING_mud1 = new WeatherVariation("SNOWCLEARING_mud1");
		public static WeatherVariation SNOWCLEARING_winter4 = new WeatherVariation("SNOWCLEARING_winter4");
	}
}