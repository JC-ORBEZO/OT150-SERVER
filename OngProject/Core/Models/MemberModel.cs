﻿using OngProject.Entities;

namespace OngProject.Core.Models
{
    public class MemberModel : EntityBase
    {
        public string Name { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedinUrl { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
