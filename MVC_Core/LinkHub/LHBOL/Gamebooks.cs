using System;
using System.Collections.Generic;

namespace LHBOL
{
    public partial class Gamebooks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public IEnumerable<Episodes> LHEpisodes { get; set; }
    }



}
