﻿namespace VAgents.Info.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    
    public class ForumPostAnswer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(2000, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 2000 символа")]

        public string Name { get; set; }
        public DateTime CreationTime { get; set; }
        public string UserId { get; set; }
        public ApplicationUser  User { get; set; }
        public int ForumPostsId { get; set; }
        public ForumPost ForumPosts { get; set; }
    }
}