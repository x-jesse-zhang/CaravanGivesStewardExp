using TaleWorlds.MountAndBlade;
using HarmonyLib;

namespace CaravanGivesStewardExp
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad()
        {
            base.OnSubModuleLoad();
            Harmony h = new Harmony("CaravanGivesStewardExp");
            h.PatchAll();

        }

        protected override void OnSubModuleUnloaded()
        {
            base.OnSubModuleUnloaded();

        }

        protected override void OnBeforeInitialModuleScreenSetAsRoot()
        {
            base.OnBeforeInitialModuleScreenSetAsRoot();

        }
    }
}