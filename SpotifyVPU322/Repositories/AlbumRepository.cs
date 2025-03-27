using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using SpotifyVPU322.DataBase;
using SpotifyVPU322.DTO;
using SpotifyVPU322.Models;
using SpotifyVPU322.Repositories.Interfaces;

namespace SpotifyVPU322.Repositories;

public class AlbumRepository(ApplicationDBContext context) : IAlbumRepository
{
    public async Task<List<GetAllAlbumDTO>> GetAllAsync()
    {
        return await context
                    .Albums
                    .Select(album => new GetAllAlbumDTO() { 
                        Id = album.Id,
                        Title = album.Title,
                        PhotoUrl = album.PhotoUrl
                    }).ToListAsync();
    }

    public async Task<List<Album>> GetFullAlbums()
    {
        return await context.Albums.ToListAsync();

    }
    public async Task<Album> GetDetailsAsync(int id)
    {
        return await context.Albums
                    .Include(x => x.AlbumSongs)
                    .Include(x => x.Artist)
                    .Where(x => x.Id == id)
                    .DefaultIfEmpty()
                    .SingleAsync();

    }
}
