﻿namespace VAgents.Info.Model
{
    using System.ComponentModel.DataAnnotations;

    public class ForumPostSubCategory
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "полето е задължително")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "полето  трябва да е между 3 и 200 символа")]

        public string Name { get; set; }
        public string CagoryId { get; set; }
        public ForumPostCategory Category { get; set; }

    }
}