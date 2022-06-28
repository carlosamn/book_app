﻿using book_app.Models;
using MongoDB.Driver;

namespace book_app.Services
    
{
    public class BookService: IBookService
    {
        private readonly IMongoCollection<Book> _books;
        public BookService(Models.IDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _books = database.GetCollection<Book>(settings.BooksCollectionName);
        }

        public Book Create(Book book)
        {
            _books.InsertOne(book);
            return book;
        }
        public List<Book> Get()
        {
            return _books.Find(books => true).ToList();
        }
        public Book Get(String id)
        {
            return _books.Find(book => book.Id == id).FirstOrDefault();
        }

        public void Remove(String id)
        {
            _books.DeleteOne(book => book.Id == id);
        }

        public void Update(String id, Book book)
        {
            _books.ReplaceOne(book => book.Id == id, book);
        }
    }
}
