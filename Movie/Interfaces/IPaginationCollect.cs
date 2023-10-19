namespace Movie.Interfaces
{
    public interface IPaginationCollect
    {
        public int TotalPages { get; set; }
        public int CurrentPage { get; set; }
    }
}
