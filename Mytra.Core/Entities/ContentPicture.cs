﻿namespace Mytra.Core
{
    public class ContentPicture : Base<ContentPicture>, IEntity
    {
        public Guid? Content { get; set; }
        public byte[]? Picture { get; set; }   

        public virtual Content? ContentNavigation { get; set; }
    }
}