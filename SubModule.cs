using TaleWorlds.MountAndBlade;
using TaleWorlds.Core;

namespace CaravanGivesStewardExp
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            base.OnGameStart(game, gameStarterObject);
            gameStarterObject.AddModel(new CaravansGiveStewardExpBehavior());
        }
    }
}