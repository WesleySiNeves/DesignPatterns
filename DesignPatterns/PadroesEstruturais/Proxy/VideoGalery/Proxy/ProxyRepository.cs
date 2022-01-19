using System;
using System.Collections.Generic;
using System.Linq;
using VideoLibrary;

namespace VideoGalery.Proxy
{
    public class ProxyRepository : IRepository
    {

        public bool IsHdRequest { get; set; }


        List<VideoDTO> _videos;

        public ProxyRepository()
        {

            _videos = new List<VideoDTO>()
            {
                 new VideoDTO { Id =1 , Name = "Primeiro Video" , Description ="Primeiro Video" , Path ="~/Videos/Escalator - 2304.mp4"},
                 new VideoDTO { Id =2 , Name = "Segundo Video" , Description ="Segundo Video" , Path ="~/Videos/Synthesizer - 3239.mp4"},
                 new VideoDTO { Id =3 , Name = "Terceiro Video" , Description ="Terceiro Video" , Path ="~/Videos/Train Tracks - 29462.mp4"}

            };
        }
        public IList<VideoDTO> GetAllVideoDetails()
        {
            return _videos;
        }

        public string GetVideoPath(int id)
        {

            string path = string.Empty;

            if (IsHdRequest)
            {
                var hdRepository = new VideoRepository();

                path = hdRepository.GetVideoPath(id);
            }
            else
            {
                path = _videos.First(x => x.Id == id).Path;
            }

            return path;
        }
    }
}
