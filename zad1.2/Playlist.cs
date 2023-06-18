using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1_bondyrev
{
    internal class Playlist
    {
        private List<Song> list;
        private int currentIndex;

        public Playlist()
        {
            list = new List<Song>();
            currentIndex = 0;
        }
        public Song CurrentSong()
        {
            if (list.Count > 0)
                return list[currentIndex];
            else
                throw new IndexOutOfRangeException("Невозможно получить текущую аудиозапись для пустого плейлиста!");
        }
        public void Add(string author, string track, string path)
        {
            Song song = new Song
            {
                Author = author,
                Filename = path,
                Title = track
            };
            list.Add(song);
        }
        public int CountOfTracks
        {
            get { return list.Count; }
            set
            {
            }
        }
        public string GetTrack(int index)
        {
            return list[index].Filename;
        }
        public string GetTitle(int index)
        {
            return $"Название трека:{list[index].Title}\nИсполнитель: {list[index].Author}";
        }
        public void DeleteTrack(int index)
        {
            list.RemoveAt(index);
        }
        public void ClearPlayList()
        {
            list.Clear();
        }
    }
}
