using ConsoleApp1;

var band = new Band("Bring Me The Horizon");

// Album 1: Sempiternal
var sempAlbum = band.AddAlbum("Sempiternal");
sempAlbum.AddMusic("Can You Feel My Heart", 232);
sempAlbum.AddMusic("Sleepwalking", 230);
sempAlbum.AddMusic("Shadow Moses", 267);

// Album 2: That's the Spirit
var umbrellaAlbum = band.AddAlbum("That's the Spirit");
umbrellaAlbum.AddMusic("Drown", 242);
umbrellaAlbum.AddMusic("Throne", 213);
umbrellaAlbum.AddMusic("Happy Song", 223);

// Execute
band.SetList();
Console.ReadKey();