using SpotifyVPU322.DTO;
using SpotifyVPU322.Models;

namespace SpotifyVPU322.Repositories.Interfaces;

public interface IAlbumRepository {
   Task<List<GetAllAlbumDTO>> GetAllAsync();
   Task<List<Album>> GetFullAlbums();
    Task<Album> GetDetailsAsync(int id);
}

