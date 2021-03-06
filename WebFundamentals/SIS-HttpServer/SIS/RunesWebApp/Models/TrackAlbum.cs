﻿namespace RunesWebApp.Models
{
    public class TrackAlbum : BaseEntity<int>
    {
        public string TrackId { get; set; }

        public virtual Track Track { get; set; }

        public string AlbumId { get; set; }

        public virtual Album Album { get; set; }
    }
}
