﻿using System;
using System.Collections.Generic;
using TrickingLibrary.Models.Abstractions;

namespace TrickingLibrary.Models
{
    public class Submission : BaseModel<int>
    {
        public string TrickId { get; set; }
        public int VideoId { get; set; }
        public Video Video { get; set; }
        public bool VideoProcessed { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public IList<SubmissionVote> UpVotes { get; set; } = new List<SubmissionVote>();
    }
}