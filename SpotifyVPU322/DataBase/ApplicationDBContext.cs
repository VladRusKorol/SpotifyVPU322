using Microsoft.EntityFrameworkCore;
using SpotifyVPU322.Models;

namespace SpotifyVPU322.DataBase;

public class ApplicationDBContext: DbContext 
{
    public DbSet<Album> Albums { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<AlbumSong> AlbumSongs { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=AplicationDB.db");
    }
}
