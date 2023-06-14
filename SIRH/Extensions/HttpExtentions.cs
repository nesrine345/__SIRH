using Microsoft.AspNetCore.Http;
using System.Text.Json;


namespace SIRH.Extensions
{
    public static class HttpExtentions
    {
        public static void AddPaginationHeader(this HttpResponse response, int currentPage, int itemsPerPage, int totalItems, int totalPages)
        {
            var paginationHeader = new
            {
                currentPage,
                itemsPerPage,
                totalItems,
                totalPages,
            };
            response.Headers.Add("Pagination", JsonSerializer.Serialize(paginationHeader));

            //This message will be displayed in the response header
            // response.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}
