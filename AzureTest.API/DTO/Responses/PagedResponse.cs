using System;
using System.Collections.Generic;
using System.Linq;
using VetClinic.API.DTO.Queries;

namespace VetClinic.API.DTO.Responses
{
    public class PagedResponse<T>
    {
        public PagedResponse() { }

        public PagedResponse(IEnumerable<T> data, PaginationQuery paginationQuery, int? totalCount = null)
        {
            Data = data;
            PageNumber = paginationQuery.PageNumber;
            PageSize = paginationQuery.PageSize;
            ObjectsCount = data.Count();
            if (totalCount != null)
            {
                TotalPages = (int) Math.Ceiling((int)totalCount / (double) PageSize);

            }
        }

        public IEnumerable<T> Data { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        public int? ObjectsCount { get; set; }
        public int? TotalPages { get; set; }
    }
}