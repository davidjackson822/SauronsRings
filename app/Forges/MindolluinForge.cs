using Application.Rings;
using Application.Interfaces;

namespace Application.Forges {
    class MindolluinForge : IForge {
        public IRing forgeRing()
        {
            return new GoldRing();
        }
    }
}
