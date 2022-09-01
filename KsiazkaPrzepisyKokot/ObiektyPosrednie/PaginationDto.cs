namespace KsiazkaPrzepisyKokot.ObiektyPosrednie
{
    public class PaginationDto
    {
        public string SortColumn { get; set; } = "name";
        public int Page { get; set; } = 1;
        public int RowsPerPage { get; set; } = 10;
        public bool SortAscending { get; set; } = false;
    }
}
