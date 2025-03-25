namespace SpotifyVPU322.Models;

public class Album
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string PhotoUrl{ get; set; }
    public required DateOnly ReleaseDate { get; set; }
    public required Artist Artist { get; set; }
    public required List<AlbumSong> AlbumSongs { get; set; }
}
