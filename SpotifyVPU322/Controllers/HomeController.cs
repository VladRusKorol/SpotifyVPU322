using Microsoft.AspNetCore.Mvc;
using SpotifyVPU322.Models;
using SpotifyVPU322.Repositories;
using SpotifyVPU322.Repositories.Interfaces;

namespace SpotifyVPU322.Controllers;


public class HomeController(IAlbumRepository albumRepository) : Controller
{

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> Albums()
    {
        //List<DTO.GetAllAlbumDTO> album = await albumRepository.GetAllAsync();
        List<Album> album = await albumRepository.GetFullAlbums();
        return View(album);
    }
}
