using ConsoleApp1;

var band = new Band("Bring Me The Horizon");

// Album 1: Sempiternal
var sempAlbum = band.AddAlbum("Sempiternal", band);
sempAlbum.AddMusic("Can You Feel My Heart", sempAlbum, band, 232);
sempAlbum.AddMusic("Sleepwalking", sempAlbum, band, 230);
sempAlbum.AddMusic("Shadow Moses", sempAlbum, band, 267);

// Album 2: That's the Spirit
var umbrellaAlbum = band.AddAlbum("That's the Spirit", band);
umbrellaAlbum.AddMusic("Drown", umbrellaAlbum, band, 242);
umbrellaAlbum.AddMusic("Throne", umbrellaAlbum, band, 213);
umbrellaAlbum.AddMusic("Happy Song", umbrellaAlbum, band, 223);

// Execute
band.SetList();
Console.ReadKey();