namespace SpotifyVPU322.Models;

public class Song
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string SongUrl { get; set; }
    public required List<AlbumSong> AlbumSongs { get; set; }
}
