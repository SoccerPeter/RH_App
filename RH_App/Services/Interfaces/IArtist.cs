using RH_App.Models;
using RH_App.Models.Spotify;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH_App.Servises.Interfaces
{
    internal interface IArtist
    {
        Task<ArtistInfo> GetArtist(string artist);
        Task <IEnumerable<Bilder>> GetArtistPhoto(string artist);
        Task<IEnumerable<Models.Albums>> GetTopAlbums(string artist);
        Task<IEnumerable<SimilarArtists>> GetSimilarArtists(string artist);
        Task<IEnumerable<SpotifyArtist>> GetSpotifyArtists(string artist);
        Task<IEnumerable<SpotifyAlbum>> GetSpotifyAlbums(string id);
    }
}
