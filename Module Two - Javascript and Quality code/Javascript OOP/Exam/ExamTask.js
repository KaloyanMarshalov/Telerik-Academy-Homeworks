function solve() {
    var module = (function() {
        var item,
            book,
            media,
            catalog,
            bookCatalog,
            mediaCatalog,
            validator;

        String.prototype.isNumber = function() {
            return /^\d+$/.test(this);
        };

        validator = {
            validateEmptyString: function(str) {
                if (str.length === 0) {
                    throw new Error('Empty string/arguments!');
                }
            },
            validateIfUndefined: function(val) {
                if (val === undefined) {
                    throw new Error('Undefined argument!');
                }
            },
            validateLength: function(val, startL, endL) {
                if (val.length < startL || val.length > endL) {
                    throw new Error('Inavlid length of string!');
                }
            },
            validateExactLength: function(val, length) {
                if (val.toString().length !== length) {
                    throw new Error('Not exact length!');
                }
            },
            validateIfOnlyDigits: function(val) {
                if (isNaN(val)) {
                    throw new Error('Does not contain only digits!');
                }
            },
            validateIfPositiveNumber: function(val) {
                if (val < 0) {
                    throw new Error('Negative number!');
                }
            },
            validateExactLengthOfTwo: function(val, first, second) {
                if (val.toString().length === first) {
                    return;
                } else if (val.toString().length === second) {
                    return;
                } else {
                    throw new Error('not exact' + first + ' ' + second);
                }
            }
        };

        item = (function() {
            var item = Object.create({}),
                currentId = 0;

            Object.defineProperty(item, 'init', {
                value: function(name, description) {
                    this._id = ++currentId;
                    this.name = name;
                    this.description = description;

                    return this;
                }
            });

            Object.defineProperty(item, 'name', {
                get: function() {
                    return this._name;
                },
                set: function(value) {
                    //validator.validateIfUndefined(value);
                    validator.validateLength(value, 2, 40);

                    this._name = value;
                }
            });

            Object.defineProperty(item, 'description', {
                get: function() {
                    return this._description;
                },
                set: function(value) {
                    //validator.validateIfUndefined(value);
                    validator.validateEmptyString(value);

                    this._description = value;
                }
            });

            Object.defineProperty(item, 'id', {
                get: function() {
                    return this._id;
                }
            });

            return item;
        }());

        book = (function(parent) {
            var book = Object.create(parent);

            Object.defineProperty(book, 'init', {
                value: function(name, isbn, genre, description) {
                    parent.init.call(this, name, description);
                    this.isbn = isbn;
                    this.genre = genre;

                    return this;
                }
            });

            Object.defineProperty(book, 'isbn', {
                get: function() {
                    return this._isbn;
                },
                set: function(value) {
                    //validator.validateIfUndefined(value);
                    validator.validateExactLengthOfTwo(value, 10, 13);
                    validator.validateIfOnlyDigits(value);

                    this._isbn = value;
                }
            });

            Object.defineProperty(book, 'genre', {
                get: function() {
                    return this._genre;
                },
                set: function(value) {
                    validator.validateLength(value, 2, 20);

                    this._genre = value;
                }
            });

            return book;
        }(item));

        media = (function(parent) {
            var media = Object.create(parent);

            Object.defineProperty(media, 'init', {
                value: function(name, rating, duration, description) {
                    parent.init.call(this, name, description);
                    this.duration = duration;
                    this.rating = rating;

                    return this;
                }
            });

            Object.defineProperty(media, 'duration', {
                get: function() {
                    return this._duration;
                },
                set: function(value) {
                    //validator.validateIfUndefined(value);
                    validator.validateIfPositiveNumber(value);

                    this._duration = value;
                }
            });

            Object.defineProperty(media, 'rating', {
                get: function() {
                    return this._rating;
                },
                set: function(value) {
                    validator.validateIfUndefined(value);
                    validator.validateLength(value, 1, 5);

                    this._rating = value;
                }
            });

            return media;
        }(item));

        catalog = (function() {
            var catalog = Object.create({}),
                currentId = 0;

            Object.defineProperty(catalog, 'init', {
                value: function(name) {
                    this._id = ++currentId;
                    this.name = name;
                    this._items = [];

                    return this;
                }
            });

            Object.defineProperty(catalog, 'name', {
                get: function() {
                    return this._name;
                },
                set: function(value) {
                    //validator.validateIfUndefined(value);
                    validator.validateLength(value, 2, 40);

                    this._name = value;
                }
            });

            Object.defineProperty(catalog, 'id', {
                get: function() {
                    return this._id;
                }
            });

            //Possible todo: define prop of the items

            Object.defineProperty(catalog, 'add', {
                value: function() {
                    validator.validateEmptyString(arguments[0]);
                    var argsArr;

                    if (Object.prototype.toString.call(arguments[0][0]) == '[object Array]') {
                        argsArr = arguments[0][0];
                    } else {
                        argsArr = arguments[0];
                    }

                    validator.validateEmptyString(argsArr);
                    return argsArr;
                }
            });

            Object.defineProperty(catalog, 'find', {
                value: function(value) {
                    validator.validateIfUndefined(value);
                    if (typeof value === 'number') {
                        for (var i = 0; i < this._items.length; i++) {
                            if (this._items[i]._id == value) {
                                return this._items[i];
                            }
                        }
                        return null;
                    } else if (typeof value === 'object') {
                        var returnObj = [],
                            name = value.name,
                            id = value.id;

                        for (var k = 0; k < this._items.length; k++) {
                            if (name !== undefined && id !== undefined) {
                                if (this._items[k].name === name && this._items[k].id === id) {
                                    returnObj.push(this._items[k]);
                                }
                            } else {
                                if (name !== undefined) {
                                    if (this._items[k].name === name) {
                                        returnObj.push(this._items[k]);
                                    }
                                } else if (id !== undefined) {
                                    if (this._items[k].id === id) {
                                        returnObj.push(this._items[k]);
                                    }
                                }
                            }
                        }
                        return returnObj;
                    } else {
                        throw new Error('not a number (id)');
                    }
                }
            });

            Object.defineProperty(catalog, 'search', {
                value: function(pattern) {
                    validator.validateIfUndefined(pattern);
                    validator.validateLength(pattern, 1, 22231123312132123);
                    pattern = pattern.toLowerCase();

                    var returnArr = [];

                    for (var i = 0; i < this._items.length; i++) {
                        if (this._items[i]._name.toLowerCase().indexOf(pattern) >= 0 || this._items[i]._description.toLowerCase().indexOf(pattern) >= 0) {
                            returnArr.push(this._items[i]);
                        }
                    }
                    if (returnArr.length == 1) {
                        return returnArr[0];
                    }
                    return returnArr;
                }
            });
            return catalog;
        }());

        bookCatalog = (function(parent) {
            var bookCatalog = Object.create(parent);

            Object.defineProperty(bookCatalog, 'init', {
                value: function(name) {
                    parent.init.call(this, name);

                    return this;
                }
            });

            Object.defineProperty(bookCatalog, 'add', {
                value: function() {
                    var argsArr = parent.add.call(this, arguments);

                    for (var i = 0; i < argsArr.length; i++) {
                        if (!(argsArr[i].hasOwnProperty('_isbn'))) {
                            throw new Error('Not a book!');
                        }
                    }
                    for (var j = 0; j < argsArr.length; j++) {
                        this._items.push(argsArr[j]);
                    }
                }
            });

            Object.defineProperty(bookCatalog, 'getGenres', {
                value: function() {
                    var uniques = [],
                        obj = {};

                    for (var i = 0; i < this._items.length; i++) {
                        if (obj.hasOwnProperty(this._items[i].genre)) {
                            continue;
                        }

                        uniques.push(this._items[i].genre.toLowerCase());
                        obj[this._items[i].genre] = 1;
                    }

                    return uniques;
                }
            });

            Object.defineProperty(bookCatalog, 'find', {
                value: function(value) {
                    validator.validateIfUndefined(value);
                    if (typeof value === 'number') {
                        for (var i = 0; i < this._items.length; i++) {
                            if (this._items[i]._id == value) {
                                return this._items[i];
                            }
                        }
                        return null;
                    } else if (typeof value === 'object') {
                        var returnObj = [],
                            name = value.name,
                            id = value.id,
                            genre = value.genre;

                        for (var k = 0; k < this._items.length; k++) {
                            if (name !== undefined && id !== undefined && genre !== undefined) {
                                if (this._items[k].name === name && this._items[k].id === id && this._items[k].genre === genre) {
                                    returnObj.push(this._items[k]);
                                }
                            } else {
                                if (name !== undefined) {
                                    if (this._items[k].name === name) {
                                        returnObj.push(this._items[k]);
                                    }
                                } else if (id !== undefined) {
                                    if (this._items[k].id === id) {
                                        returnObj.push(this._items[k]);
                                    }
                                }else if (genre !== undefined) {
                                    if (this._items[k].genre === genre) {
                                        returnObj.push(this._items[k]);
                                    }
                                }
                                else if (name !== undefined && id !== undefined) {
                                    if (this._items[k].name === name && this._items[k].id === id) {
                                        returnObj.push(this._items[k]);
                                    }
                                }
                                else if (name !== undefined && genre !== undefined) {
                                    if (this._items[k].name === name && this._items[k].genre === genre) {
                                        returnObj.push(this._items[k]);
                                    }
                                }
                                else if (genre !== undefined && id !== undefined) {
                                    if (this._items[k].genre === genre && this._items[k].id === id) {
                                        returnObj.push(this._items[k]);
                                    }
                                }
                            }
                        }
                        return returnObj;
                    } else {
                        throw new Error('not a number (id)');
                    }
                }
            });

            return bookCatalog;
        }(catalog));

        mediaCatalog = (function(parent) {
            var mediaCatalog = Object.create(parent);

            Object.defineProperty(mediaCatalog, 'init', {
                value: function(name) {
                    parent.init.call(this, name);

                    return this;
                }
            });

            Object.defineProperty(mediaCatalog, 'add', {
                value: function() {
                    var argsArr = parent.add.call(this, arguments);

                    for (var i = 0; i < argsArr.length; i++) {
                        if (!(argsArr[i].hasOwnProperty('_rating'))) {
                            throw new Error('Not a media!');
                        }
                    }
                    for (var j = 0; j < argsArr.length; j++) {
                        this._items.push(argsArr[j]);
                    }
                }
            });

            Object.defineProperty(mediaCatalog, 'getSortedByDuration', {
                value: function() {
                    var arr = this._items.sort(function (first, second) {
                        if (first.duration > second.duration) {
                            return -1;
                        }
                        else if (first.duration < second.duration) {
                            return 1;
                        }

                        if (first.id > second.id) {
                            return 1;
                        }
                        else if(first.id < second.id) {
                            return -1;
                        }
                        else {
                            return 0;
                        }
                    });
                }
            });
            Object.defineProperty(mediaCatalog, 'getTop', {
                value: function(count) {
                    if (isNaN(count)||count < 1) {
                        throw new Error();
                    }

                    var arr = this._items
                    .sort(function(a,b) {
                        return a.rating - b.rating;
                    })
                    .splice(0, count)
                    .map(function(a) {
                        return {
                            id: a.id,
                            name: a.name
                            };
                    });

                    return arr;
                }
            });
            return mediaCatalog;
        }(catalog));

        return {
            getBook: function(name, isbn, genre, description) {
                //return Object.create(book).init(name, isbn, genre, description);
                throw new Error('');
            },
            getMedia: function(name, rating, duration, description) {
                //return Object.create(media).init(name, rating, duration, description);
                throw new Error('');
            },
            getBookCatalog: function(name) {
                throw new Error('');
                //return Object.create(bookCatalog).init(name);
            },
            getMediaCatalog: function(name) {
                throw new Error('');
                //return Object.create(mediaCatalog).init(name);
            }
        };
    }());
    return module;
}

var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
catalog.add(book2);

console.log(catalog.find(book1.id));
//returns book1

console.log(catalog.find({id: book2.id, genre: 'IT'}));
//returns book2

console.log(catalog.search('js'));
// returns book2

console.log(catalog.search('javascript'));
//returns book1 and book2

console.log(catalog.search('Te sa zeleni'));
//returns []
