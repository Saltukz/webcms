namespace entity
{
    public class DokumanMnMRel
    {

        public int DokumanId { get; set; }

        public Dokuman Dokuman { get; set; }

        public int DokumanCategoryId { get; set; }

        public DokumanCategory DokumanCategory { get; set; }
    }
}