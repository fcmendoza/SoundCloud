using SoundCloud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoundCloud.DataAccess.Repositories
{
    public class SongRepository
    {   
        public List<Song> GetSongs() {
            List<Song> songs = _db.GetSongs().ExecuteTypedList<Song>();
            return songs;
        }

        public List<Song> GetTop5() {
            List<Song> songs = _db.GetTop5().ExecuteTypedList<Song>();
            return songs;
        }

        public void SaveSong(Song song) {
            _db.CreateSong(song.Title, song.ArtistName, song.Genre, song.AlbumName, song.Year, song.FileName).Execute();
        }

        private SoundCloudDB _db = new SoundCloudDB();
    }
}