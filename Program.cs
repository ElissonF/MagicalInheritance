using MagicalInheritance;

Storm s = new("wind", false, "Zul'rajas");
Console.WriteLine(s.Announce());
Pupil p = new("Mezil-kree");
Storm windStorm = p.CastWindstorm();
Console.WriteLine(windStorm.Announce());
Mage m = new("Gul'dan");
Storm rainStorm = m.CastRainStorm();
Console.WriteLine(rainStorm.Announce());
ArchMage ac = new("Nielas Aran");
Storm lightningStorm = ac.CastLightningStorm();
Console.WriteLine(lightningStorm.Announce());