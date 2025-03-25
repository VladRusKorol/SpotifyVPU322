namespace SpotifyVPU322.Models;

public class AlbumSong
{
    public required int Id { get; set; }   
    public required Song Song { get; set; }
    public required Album Album { get; set; }
    public required DateOnly CreateDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
}
