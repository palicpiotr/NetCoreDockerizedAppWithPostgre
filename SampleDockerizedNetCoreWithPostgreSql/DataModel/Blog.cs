using System.ComponentModel.DataAnnotations;

namespace SampleDockerizedNetCoreWithPostgreSql.DataModel
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
