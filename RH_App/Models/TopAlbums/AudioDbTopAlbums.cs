using System;
namespace RH_App.Models
{
    public class Album
    {
        public string idAlbum { get; set; }
        public string idArtist { get; set; }
        public string idLabel { get; set; }
        public string intLoved { get; set; }
        public string intSales { get; set; }
        public string intScore { get; set; }
        public string intScoreVotes { get; set; }
        public string intYearReleased { get; set; }
        public string strAlbum { get; set; }
        public string strAlbum3DCase { get; set; }
        public string strAlbum3DFace { get; set; }
        public string strAlbum3DFlat { get; set; }
        public object strAlbum3DThumb { get; set; }
        public string strAlbumCDart { get; set; }
        public object strAlbumSpine { get; set; }
        public string strAlbumStripped { get; set; }
        public string strAlbumThumb { get; set; }
        public string strAlbumThumbBack { get; set; }
        public object strAlbumThumbHQ { get; set; }
        public string strAllMusicID { get; set; }
        public object strAmazonID { get; set; }
        public string strArtist { get; set; }
        public string strArtistStripped { get; set; }
        public string strBBCReviewID { get; set; }
        public object strDescriptionCN { get; set; }
        public object strDescriptionDE { get; set; }
        public string strDescriptionEN { get; set; }
        public string strDescriptionES { get; set; }
        public string strDescriptionFR { get; set; }
        public object strDescriptionHU { get; set; }
        public object strDescriptionIL { get; set; }
        public object strDescriptionIT { get; set; }
        public object strDescriptionJP { get; set; }
        public object strDescriptionNL { get; set; }
        public object strDescriptionNO { get; set; }
        public object strDescriptionPL { get; set; }
        public object strDescriptionPT { get; set; }
        public object strDescriptionRU { get; set; }
        public object strDescriptionSE { get; set; }
        public string strDiscogsID { get; set; }
        public string strGeniusID { get; set; }
        public string strGenre { get; set; }
        public object strItunesID { get; set; }
        public string strLabel { get; set; }
        public object strLocation { get; set; }
        public string strLocked { get; set; }
        public object strLyricWikiID { get; set; }
        public string strMood { get; set; }
        public string strMusicBrainzArtistID { get; set; }
        public string strMusicBrainzID { get; set; }
        public object strMusicMozID { get; set; }
        public string strRateYourMusicID { get; set; }
        public string strReleaseFormat { get; set; }
        public string strReview { get; set; }
        public string strSpeed { get; set; }
        public string strStyle { get; set; }
        public string strTheme { get; set; }
        public string strWikidataID { get; set; }
        public string strWikipediaID { get; set; }
        public object strDescription { get; set; }
    }

    public class AudioDbTopAlbums
    {
        public List<Album> album { get; set; }
    }
}

