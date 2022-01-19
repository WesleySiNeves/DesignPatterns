using System;
using System.Collections.Generic;
using System.Text;

namespace VideoLibrary
{
    public interface IRepository
    {

        IList<VideoDTO> GetAllVideoDetails();

        string GetVideoPath(int id);

        bool IsHdRequest { get; set; }
    }
}
