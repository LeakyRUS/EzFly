using MelonLoader;
using HarmonyLib;

using ABI.CCK.Components;
using ABI_RC.Systems.MovementSystem;

namespace EzFly
{
    public class FlyFix : MelonMod
    {
        [HarmonyPatch(typeof(CVRWorld), "SetupWorldRules")]
        public class Fix
        {
            static void Postfix()
            {
                var msi = MovementSystem.Instance;

                msi.canFly = true;
                msi.floatSpeedMultiplier = 5f;
            }
        }
    }
}
