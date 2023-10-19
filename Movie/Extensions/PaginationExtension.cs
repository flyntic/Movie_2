using Microsoft.CodeAnalysis.CSharp.Syntax;
using Movie.Interfaces;

namespace Movie.Extensions
{
    public static class PaginationExtension
    {   const int numberPagination= 9;

        public static int BeginPaginationIndex(this IPaginationCollect collect  )
        {
            int count = (collect.TotalPages > numberPagination) ? numberPagination : collect.TotalPages;

            if (collect.CurrentPage > count / 2)
                if ((collect.CurrentPage + count / 2) <= collect.TotalPages) return collect.CurrentPage - count / 2;
                else return collect.TotalPages - count;

            if ((collect.CurrentPage - count / 2) >=1) return collect.CurrentPage - count / 2;
            
            return 1;
            
        }
        public static int EndPaginationIndex(this IPaginationCollect collect)
        {
            int count = (collect.TotalPages > numberPagination) ? numberPagination : collect.TotalPages;

            if (collect.CurrentPage < count / 2)
                if ((collect.CurrentPage - count / 2) >= 1) return (collect.CurrentPage + count / 2);
                else return ( count );

            if ((collect.CurrentPage + count / 2) <=collect.TotalPages) return (collect.CurrentPage + count / 2);

            return collect.TotalPages;

            
        }
    }
}
