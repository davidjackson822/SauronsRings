using Application.Enums;

namespace Application.Rings {
    class GoldRing : Ring {
        public GoldRing() {
            Metal = MetalType.Gold;
            Inscription = "Im'll gar- i gwanod leben haer";
            Gem = [Gems.Diamond];
            Size = 10;
        }
    }
}