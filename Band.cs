namespace ConsoleApp1;

public class Band
{
  public string Name { get; private set; }
  public List<Album> Albuns { get; private set; }

  public Band(string name)
  {
    Name = name;
    Albuns = [];
  }

  public Album AddAlbum(string name, Band band)
  {
    var album = new Album(name, band);
    Albuns.Add(album);
    return album;
  }

  public void SetList()
  {
    var points = "".PadRight(Name.Length, '*');

    Console.WriteLine(points);
    Console.WriteLine(Name);
    Console.WriteLine(points);

    foreach (Album album in Albuns)
    {
      var totalDuration = album.Musics.Sum(music => music.Duration);
      Console.WriteLine($"\n{album.Name} - {totalDuration / 60}:{totalDuration % 60}");
      foreach (Music music in album.Musics)
      {
        Console.WriteLine($"- {music.Name}");
      }
    }
  }
}
