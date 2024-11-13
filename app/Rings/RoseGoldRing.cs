using Application.Enums;

namespace Application.Rings {
    class RoseGoldRing : Ring {
        public RoseGoldRing() {
            Metal = MetalType.RoseGold;
            Inscription = "Im'll gar- i gwanod leben haer";
            Gem = [Gems.Diamond];
            Size = 8;
        }
    }
}