using Microsoft.AspNetCore.Mvc;
using SpotifyVPU322.Repositories;
using SpotifyVPU322.Repositories.Interfaces;

namespace SpotifyVPU322.Controllers
{
    public class AlbumController(IAlbumRepository albumRepository) : Controller
    {
        public async Task<IActionResult> Details(int id)
        {
            var album = await albumRepository.GetDetailsAsync(id);
            return View(album);
        }
    }
}
