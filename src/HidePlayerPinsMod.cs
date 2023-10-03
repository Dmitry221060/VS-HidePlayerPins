using Vintagestory.API.Common;

namespace HidePlayerPins {
    public class HidePlayerPinsMod : ModSystem {
        public override void Start(ICoreAPI api) {
            api.World.Config.SetBool("mapHideOtherPlayers", true);
        }
    }
}
