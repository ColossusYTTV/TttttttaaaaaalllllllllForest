using System;
using System.Reflection;
using HarmonyLib;

namespace Colossal
{
	public class HarmonyPatches
	{
		public static bool IsPatched { get; private set; }

		internal static void ApplyHarmonyPatches()
		{
			bool flag = !HarmonyPatches.IsPatched;
			bool flag2 = flag;
			if (flag2)
			{
				bool flag3 = HarmonyPatches.instance == null;
				bool flag4 = flag3;
				if (flag4)
				{
					HarmonyPatches.instance = new Harmony("org.Colossal");
				}
				HarmonyPatches.instance.PatchAll(Assembly.GetExecutingAssembly());
				HarmonyPatches.IsPatched = true;
			}
		}

		internal static void RemoveHarmonyPatches()
		{
			bool flag = HarmonyPatches.instance != null && HarmonyPatches.IsPatched;
			bool flag2 = flag;
			if (flag2)
			{
				HarmonyPatches.instance.UnpatchSelf();
				HarmonyPatches.IsPatched = false;
			}
		}

		private static Harmony instance;

		public const string InstanceId = "org.Colossal";
	}
}
