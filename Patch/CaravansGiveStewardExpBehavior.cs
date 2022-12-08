using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.GameComponents;
using TaleWorlds.CampaignSystem.Party;

namespace CaravanGivesStewardExp
{
    internal class CaravansGiveStewardExpBehavior : DefaultMobilePartyFoodConsumptionModel
    {
        public override int NumberOfMenOnMapToEatOneFood
        {
            get
            {
                return base.NumberOfMenOnMapToEatOneFood;
            }
        }

        public override bool DoesPartyConsumeFood(MobileParty mobileParty)
        {
            if (mobileParty.LeaderHero != null && mobileParty.LeaderHero.Clan == Clan.PlayerClan)
            {
                if (mobileParty.IsCaravan)
                {
                    if (mobileParty.IsActive)
                    {
                        return true;
                    }
                }
            }

            return mobileParty.IsActive && 
                   (mobileParty.LeaderHero == null || mobileParty.LeaderHero.IsLord || mobileParty.LeaderHero.Clan == Clan.PlayerClan || mobileParty.LeaderHero.IsMinorFactionHero) && 
                   !mobileParty.IsGarrison && 
                   !mobileParty.IsCommonAreaParty && 
                   !mobileParty.IsBandit && 
                   !mobileParty.IsMilitia && 
                   !mobileParty.IsVillager;
        }

        public override ExplainedNumber CalculateDailyBaseFoodConsumptionf(MobileParty party, bool includeDescription = false)
        {
            return base.CalculateDailyBaseFoodConsumptionf(party, includeDescription);
        }

        public override ExplainedNumber CalculateDailyFoodConsumptionf(MobileParty party, ExplainedNumber baseConsumption)
        {
            return base.CalculateDailyFoodConsumptionf(party, baseConsumption);
        }

    }
}