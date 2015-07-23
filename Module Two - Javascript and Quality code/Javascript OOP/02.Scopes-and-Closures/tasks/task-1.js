/* Task Description */
/*
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/catagory has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function() {
        var books = [],
            categories = [];

        function isUnique(arr, newValue, prop) {
            var resultArray;

            if (!newValue) {
                throw new Error("isUnique:: value is missing.");
            }

            resultArray = arr.filter(function(val) {
                return val[prop] === newValue;
            });

            return resultArray.length === 0;
        }

        function isUniqueCategory(categoryName) {
            var resultArray;

            if (!categoryName) {
                throw new Error("isUnique:: value is missing.");
            }

            resultArray = categories.filter(function(val) {
                return val.name === categoryName;
            });

            return resultArray.length === 0;
        }

        function validateBook(book) {
            var category = {};

            if (!book.author) {
                throw new Error('no author!');
            }
            if (!isUnique(books, book.title, 'title')) {
                throw new Error('not unique!');
            }
            if (book.title.length < 2 || book.title.length > 100) {
                throw new Error('bad length');
            }
            if (!isUnique(books, book.isbn, 'isbn')) {
                throw new Error('bad isbn');
            }
            if (book.isbn.length < 10 || book.isbn.length > 13) {
                throw new Error('bad isbn length');
            }
            if (isUniqueCategory(book.category)) {
                category.id = categories.length + 1;
                category.b = book.category;

                categories.push(category);
            }

        }

		function listBooks(sortPropertyObj) {
			var sortProperties,
				sortProperty;

			sortPropertyObj = sortPropertyObj || {};
			sortProperties = Object.keys(sortPropertyObj);
			sortProperty = sortProperties[0];

			return books.filter(function (obj) {
				return obj[sortProperty] === sortPropertyObj[sortProperty];
			}).sort(function (a, b) {
				return a.id - b.id;
			});
		}

        function addBook(book) {
            validateBook(book);

            book.ID = books.length + 1;
            books.push(book);

            return book;
        }

        function listCategories() {
            return categories.sort(function(a, b) {
                return a.id - b.id;
            }).map(function(category) {
                return category.name;
            });
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
    }());
    return library;
}
module.exports = solve;
