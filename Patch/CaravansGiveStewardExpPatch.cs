using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;

namespace CaravanGivesStewardExp
{
    [HarmonyPatch(typeof(DefaultMobilePartyFoodConsumptionModel), "DoesPartyConsumeFood")]
    internal class CaravansGiveStewardExpPatch
    {
        static void Postfix(MobileParty mobileParty, ref bool __result)
        {
            __result = mobileParty.IsActive &&
                   (mobileParty.LeaderHero == null || mobileParty.LeaderHero.IsLord || mobileParty.LeaderHero.Clan == Clan.PlayerClan || mobileParty.LeaderHero.IsMinorFactionHero) &&
                   !mobileParty.IsGarrison &&
                   !mobileParty.IsCommonAreaParty ||
                   mobileParty.IsCaravan &&
                   !mobileParty.IsBandit &&
                   !mobileParty.IsMilitia &&
                   !mobileParty.IsVillager;
        }
    }
}
