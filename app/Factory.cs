using Application.Interfaces;
using Application.Forges;

namespace Application {
    public class Factory : IFactory { 
        public IForge createForge(string? ringToCreate)
        {
            IForge forge;

            switch (ringToCreate.ToLower())
            {
                case "silver":
                    forge = new MirkwoodForge();
                    break;
                case "gold":
                    forge = new MindolluinForge();
                    break;
                case "platinum":
                    forge = new MirrorstoneForge();
                    break;
                default:
                    Console.WriteLine("Please My Lord enter a metal that we have the capability to use");
                    throw new Exception();
            }

            return forge;
        }
    }
}