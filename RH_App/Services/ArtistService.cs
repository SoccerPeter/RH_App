using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using RH_App.Models;
using RH_App.Models.Spotify;
using RH_App.Servises.Interfaces;
//using static Microsoft.Maui.Controls.PlatformConfiguration.Android.Provider.DocumentsContract;

namespace RH_App.Services
{
    public class ArtistService : IArtist
    {
        public async Task<ArtistInfo> GetArtist(string artist)
        {
            try
            {
                var clientHandler = new HttpClientHandler
                {
                    UseCookies = false,
                };
                var client = new HttpClient(clientHandler);
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://rockhubbackend2023.azurewebsites.net/artist?artist=" + artist),
                    Headers =
                {
                    { "XApiKey", "pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp" },
                },
                };
                using (var response = await client.SendAsync(request))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        {
                            var content = await response.Content.ReadAsStringAsync();
                            var artistInfo = JsonConvert.DeserializeObject<ArtistInfo>(content);
                            return artistInfo;
                        }
                    }

                    else
                    {
                        ArtistInfo artistInfo = new ArtistInfo();
                        artistInfo.result.group = "No results found";
                        return artistInfo;
                    }

                }
            }
            catch (Exception ex)
            {
                ArtistInfo artistInfo = new ArtistInfo();
                artistInfo.result.group = "No results found";
                return artistInfo;
            }
            
        }

        public async Task<IEnumerable<Bilder>> GetArtistPhoto(string artist)
        {

            var clientHandler = new HttpClientHandler {
                UseCookies = false,
            };
            var client = new HttpClient(clientHandler);
            var request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rockhubbackend2023.azurewebsites.net/pictures?artist=" + artist),
                Headers =
                {
                    { "XApiKey", "pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp" },
                },
            };
            using (var response = await client.SendAsync(request)) {
                if (response.IsSuccessStatusCode) {
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var pic = JsonConvert.DeserializeObject<IEnumerable<Bilder>>(content);
                        return pic;
                    }
                }

                else {
                    return null;
                }

            }
        }

        public async Task<IEnumerable<SimilarArtists>> GetSimilarArtists(string artist)
        {
            var clientHandler = new HttpClientHandler
            {
                UseCookies = false,
            };
            var client = new HttpClient(clientHandler);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rockhubbackend2023.azurewebsites.net/similar?artist=" + artist),
                Headers =
                {
                    { "XApiKey", "pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var similar = JsonConvert.DeserializeObject<IEnumerable<SimilarArtists>>(content);
                        var S = new List<SimilarArtists>();
                        return similar;
                    }
                }

                else
                {
                    return null;
                }

            }
        }

        public async Task<IEnumerable<SpotifyAlbum>> GetSpotifyAlbums(string id) {
            int last = id.LastIndexOf(":");
            int langd = id.Length;
            var albumId = id.Substring(14, 22);

            var clientHandler = new HttpClientHandler
            {
                UseCookies = false,
            };
            var client = new HttpClient(clientHandler);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rockhubbackend2023.azurewebsites.net/spotifyalbum?albumId=" + albumId),
                Headers =
                {
                    { "XApiKey", "pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var Artist = JsonConvert.DeserializeObject<IEnumerable<SpotifyAlbum>>(content);
                        return Artist;
                    }
                }

                else
                {
                    return null;
                }

            }
        }

        public async Task<IEnumerable<SpotifyArtist>> GetSpotifyArtists(string artist) {
            var clientHandler = new HttpClientHandler {
                UseCookies = false,
            };
            var client = new HttpClient(clientHandler);
            var request = new HttpRequestMessage {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rockhubbackend2023.azurewebsites.net/spotifyartist?artist=" + artist),
                Headers =
                {
                    { "XApiKey", "pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp" },
                },
            };
            using (var response = await client.SendAsync(request)) {
                if (response.IsSuccessStatusCode) {
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var Artist = JsonConvert.DeserializeObject<IEnumerable<SpotifyArtist>>(content);
                        return Artist;
                    }
                }

                else {
                    return null;
                }

            }
        }

        public async Task<IEnumerable<Albums>> GetTopAlbums(string artist)
        {
           
            var a = HttpUtility.UrlEncode(artist);
            var clientHandler = new HttpClientHandler
            {
                UseCookies = false,
            };
            var client = new HttpClient(clientHandler);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://rockhubbackend2023.azurewebsites.net/topalbums?artist=" + a),
                Headers =
                {
                    { "XApiKey", "pgH7QzFHJx4w46fI~5Uzi4RvtTwlEXp" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var albums = JsonConvert.DeserializeObject<IEnumerable<Albums>>(content);
                        return albums;
                    }
                }

                else
                {
                    return null;
                }

            }
        }
    }

    internal record NewRecord();
}
