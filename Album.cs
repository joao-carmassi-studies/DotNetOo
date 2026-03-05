namespace ConsoleApp1;

public class Album
{
  public string Name { get; private set; }
  public Band Band { get; private set; }
  public List<Music> Musics { get; private set; }

  public Album(string name, Band band)
  {
    Name = name;
    Band = band;
    Musics = [];
  }

  public Music AddMusic(string name, Album album, Band band, int duration)
  {
    var music = new Music(name, album, band, duration);
    Musics.Add(music);
    return music;
  }
}