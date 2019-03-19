using FluentAPI;

namespace EFTest
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    
    public partial class Course
    {
        
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Level { get; set; }

        public float FullPrice { get; set; }

        public int AuthorId { get; set; }

        public  Author Author { get; set; }

        public  ICollection<Tag> Tags { get; set; }

        public  Cover Cover { get; set; }
    }
}
