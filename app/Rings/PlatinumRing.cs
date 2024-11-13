using Application.Enums;

namespace Application.Rings {
    class PlatinumRing : Ring {
        public PlatinumRing() {
            Metal = MetalType.Platinum;
            Inscription = "Mín forgot i parv";
            Gem = [Gems.Ruby];
            Size = 7;
        }
    }
}