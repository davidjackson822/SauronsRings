using Application;
using Application.Interfaces;

Factory factory = new Factory();

Console.WriteLine("\nEnter Metal Type: ");
string inputRingMetal = Console.ReadLine();

if(inputRingMetal.ToLower() == "all") {
    List<string> ringsToCreate = ["gold", "silver", "platinum", "BLOOD"];
    foreach (string ringAsString in ringsToCreate)
    {
        IForge nextForge = factory.createForge(ringAsString);
        IRing nextRing = nextForge.forgeRing();
        Console.WriteLine(nextRing.ToString());
    }
}

IForge forge = factory.createForge(inputRingMetal);
IRing ring = forge.forgeRing();
Console.WriteLine(ring.ToString());
Console.WriteLine();

