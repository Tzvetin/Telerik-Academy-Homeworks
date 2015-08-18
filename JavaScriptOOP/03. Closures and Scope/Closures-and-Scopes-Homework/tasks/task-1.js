/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionality:
			*	Add a new book to category
				ok*	Each book has unique title, author and ISBN
				ok*	It must return the newly created book with assigned ID
				ok*	If the category is missing, it must be automatically created
			*	List all books
				ok*	Books are sorted by ID
				ok*	This can be done by author, by category or all
			*	List all categories
				ok*	Categories are sorted by ID
		*	Each book/category has a unique identifier (ID) that is a number greater than or equal to 1
			ok*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			ok*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			ok*	Author is any non-empty string
			ok*	Unique params are Book title and Book ISBN
			ok*	Book ISBN is an unique code that contains either 10 or 13 digits
			ok*	If something is not valid - throw Error
*/

function solve() {
	var library = (function () {
		var books = [];
		var categories = [];

		function listBooks(option) {
			var booksList;

			if (option === undefined) {
				return books.slice();
			}

			//sort by author
			if (option.hasOwnProperty('author')) {
				booksList = books.filter(function(book) {
					return book.author === option.author;
				});
			}

			//sort by category
			if (option.hasOwnProperty('category')) {
				booksList = books.filter(function(book) {
					return book.category === option.category;
				});
			}

			//sort by ID
			booksList = booksList.sort(function(book1, book2) {
				return book1.ID > book2.ID;
			});

			return booksList;
		}

		function addBook(book) {
			validateBook(book);
			validateCategory(book);
			book.ID = books.length + 1;
			books.push(book);
			return book;
		}

		function validateBook(book) {
			var i,
				len;

			for (i = 0, len = books.length; i < len; i += 1) {

				//unique title
				if (books[i].title === book.title) {
					throw new Error();
				}
				//unique isbn
				if(books[i].isbn === book.isbn) {
					throw new Error();
				}
			}

			//book title length
			if (book.title.length < 2 || book.title.length > 100) {
				throw new Error();
			}

			//author is a non-empty string
			if (book.author === '') {
				throw new Error();
			}

			//isbn has 10 or 13 digits
			if (book.isbn.length !== 10 && book.isbn.length !== 13) {
				throw new Error();
			}

			//isbn contains digits only
			for (i = 0, len = book.isbn.length; i < len; i += 1) {
				if (isNaN(book.isbn[i])) {
					throw new Error();
				}
			}
		}

		function validateCategory(book) {

			//category length
			if(book.category.length < 2 || book.category.length > 100) {
				throw new Error();
			}

			//add category if missing
			if(categories.indexOf(book.category) < 0) {
				categories.push(book.category);
			}
		}

		function listCategories() {
			return categories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
