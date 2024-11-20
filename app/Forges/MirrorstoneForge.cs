using Application.Rings;
using Application.Interfaces;

namespace Application.Forges {
    class MirrorstoneForge : IForge {
        public IRing forgeRing()
        {
            return new PlatinumRing();
        }
    }
}
