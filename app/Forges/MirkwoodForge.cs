using Application.Rings;
using Application.Interfaces;

namespace Application.Forges {
    class MirkwoodForge : IForge {
        public IRing forgeRing()
        {
            return new SilverRing();
        }
    }
}
