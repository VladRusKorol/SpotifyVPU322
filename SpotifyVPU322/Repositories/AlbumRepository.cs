using Microsoft.EntityFrameworkCore;
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
    //public async Task<Album> GetDetailsAsync(int id)
    //{
    //    //return await context
    //    //            .Albums
    //    //            .Include(x => x.)
    //    //            .Select(album => new GetAllAlbumDTO()
    //    //            {
    //    //                Id = album.Id,
    //    //                Title = album.Title,
    //    //                PhotoUrl = album.PhotoUrl
    //    //            }).SingleAsync(x => x.Id == id)
                  
    //}
}
