using System;
using Application.Enums;
using Application.Interfaces;

namespace Application {
    abstract class Ring : IRing
    {
        public MetalType Metal;
        public List<Gems> Gem = [];
        public List<Powers> Powers = [];
        public string? Inscription;
        public int? Size;

        public void RandomizePower()
        {
            throw new NotImplementedException();
        }
    }
}