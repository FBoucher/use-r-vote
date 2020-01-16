using System;

namespace Use_R_Vote.Data
{
    public class UserIdea
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public Guid Creator { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TotalVoteCurrentPeriod { get; set; }
    }
}
