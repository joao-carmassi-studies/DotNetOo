namespace ConsoleApp1;

public class Music
{
  public string Name { get; private set; }
  public Album Album { get; private set; }
  public Band Band { get; private set; }
  public int Duration { get; private set; }

  public Music(string name, Album album, Band band, int duration)
  {
    Name = name;
    Album = album;
    Band = band;
    Duration = duration;
  }
}
