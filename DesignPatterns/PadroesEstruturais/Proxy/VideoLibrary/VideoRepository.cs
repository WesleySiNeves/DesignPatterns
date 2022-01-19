using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace VideoLibrary
{
    public class VideoRepository : IRepository
    {
        List<VideoDTO> _videos;

        public VideoRepository()
        {

            _videos = new List<VideoDTO>()
            {
                 new VideoDTO { Id =1 , Name = "Primeiro Video" , Description ="Primeiro Video" , Path ="~/Videos/HD/Escalator - 2304.mp4"},
                 new VideoDTO { Id =2 , Name = "Segundo Video" , Description ="Segundo Video" , Path ="~/Videos/HD/Synthesizer - 3239.mp4"},
                 new VideoDTO { Id =3 , Name = "Terceiro Video" , Description ="Terceiro Video" , Path ="~/Videos/HD/Train Tracks - 29462.mp4"}
                 
            };
        }

        public bool IsHdRequest { get; set; }

        public IList<VideoDTO> GetAllVideoDetails()
        {
            return _videos;
        }

        public string GetVideoPath(int id)
        {
            return _videos.First(x => x.Id == id).Path;
        }
    }
}
