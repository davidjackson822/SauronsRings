using Application.Enums;

namespace Application.Rings {
    class SilverRing : Ring {
        public SilverRing() {
            Metal = MetalType.Silver;
            Inscription = "estel i aes doesn't nor- awaui";
            Gem = [Gems.Emerald, Gems.Sapphire];
            Size = 1;
        }
    }
}