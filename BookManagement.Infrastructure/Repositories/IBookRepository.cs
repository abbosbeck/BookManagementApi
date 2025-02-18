﻿using BookManagement.Infrastructure.Entities;

namespace BookManagement.Infrastructure.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookEntity>> GetAllAsync(int page, int pageSize);
        Task<IEnumerable<string>> GetBookTitlesAsync();
        Task<IEnumerable<string>> GetBookTitlesAsync(int page, int pageSize);
        Task<IEnumerable<BookEntity>> GetByIdsAsync(IEnumerable<int> ids);
        Task<BookEntity> GetByTitleAsync(string title);
        Task<BookEntity> GetByIdAsync(int id);
        Task AddAsync(BookEntity book);
        Task AddBulkAsync(IEnumerable<BookEntity> books);
        Task UpdateAsync(BookEntity book);
        Task UpdateBulkAsync(IEnumerable<BookEntity> books);
        Task DeleteAsync(int id);
        Task DeleteBulkAsync(IEnumerable<int> ids);
    }
}