﻿namespace HackerNewsApi.Models.QueryParams
{
    public class QueryParams
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;
        public string Query { get; set; } = string.Empty;
    }
}
