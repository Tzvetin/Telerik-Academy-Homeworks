function solve() {

    function isStringValid(str, minLength, maxLength){
        return (typeof str === 'string' && str.length >= minLength && str.length <= maxLength);
    }

    var item = (function() {
        var lastId = 0;
        var item = {
            init: function(name, description) {
                this.name = name;
                this.description = description;
                this.id = ++lastId;
                return this;
            },
            get name() {
                return this._name;
            },
            set name(newName) {
                if (!isStringValid(newName, 2, 40)) {
                    throw {
                        name:'invalid name',
                        message: 'invalid name'
                    };
                }
                this._name = newName;
            },
            get description() {
                return this._description;
            },
            set description(newDescription) {
                if (!isStringValid(newDescription, 1, 9007199254740992)) {
                    throw {
                        name:'invalid description',
                        message: 'invalid description'
                    };
                }
                this._description = newDescription;
            }
        };
        return item;
    }());


    var book = (function(parent){
        var book = Object.create(parent);
        book.init = function(name, isbn, genre, description) {
            parent.init.call(this, name, description);
            this.isbn = isbn;
            this.genre = genre;
            return this;
        };

        Object.defineProperty(book, 'isbn', {
            get: function() {
                return this._isbn;
            },
            set: function(newisbn) {
                var i, len;

                for (i = 0, len = newisbn.length; i < len; i += 1) {
                    if (isNaN(newisbn[i])) {
                        throw {
                            name: 'invalid isbn',
                            message: 'invalid isbn'
                        };
                    }
                }

                if (newisbn.length !== 10 && newisbn.length !== 13) {
                    throw {
                        name: 'invalid isbn length',
                        message: 'invalid isbn length'
                    };
                }
                this._isbn = newisbn;
            }
        });

        Object.defineProperty(book, 'genre', {
            get: function() {
                return this._genre;
            },
            set: function(newGenre) {
                if (!isStringValid(newGenre, 2, 20)) {
                    throw {
                        name:'invalid genre',
                        message: 'invalid genre'
                    };
                }
                this._genre = newGenre;
            }
        });

        return book;
    }(item));


    var media = (function(parent){
        var media = Object.create(parent);
        media.init = function(name, rating, duration, description) {
            parent.init.call(this, name, description);
            this.rating = rating;
            this.duration = duration;
            return this;
        };

        Object.defineProperty(media, 'duration', {
            get: function() {
                return this._duration;
            },
            set: function(newDuration) {
                //newDuration = +newDuration;
                if (typeof newDuration !== 'number' || newDuration <= 0) {
                    throw {
                        name:'invalid duration',
                        message: 'invalid duration'
                    };
                }
                this._duration = newDuration;
            }
        });

        Object.defineProperty(media, 'rating', {
            get: function() {
                return this._rating;
            },
            set: function(newRating) {
                //newRating = +newRating;
                if (typeof newRating !== 'number' || newRating < 1 || newRating > 5){
                    throw {
                        name:'invalid rating',
                        message: 'invalid rating'
                    };
                }
                this._rating = newRating;
            }
        });

        return media;
    }(item));


    var catalog = (function(){
        var lastId = 0;
        var catalog = {
            init: function(name) {
                this.name = name;
                this.id = ++lastId;
                this.items = [];
                return this;
            },
            get name() {
                return this._name;
            },
            set name(newName) {
                if (!isStringValid(newName, 2, 40)) {
                    throw {
                        name:'invalid catalog name',
                        message: 'invalid catalog name'
                    };
                }
                this._name = newName;
            },
            add: function() {
                var arrayOfItems = [];
                var i,
                    len = arguments.length;
                if (len === 0){
                    throw {
                        name:'no items are passed to the catalog',
                        message: 'no items are passed to the catalog'
                    };
                }
                else if (len === 1 && Array.isArray(arguments[0])){
                    if (arguments[0] = []){
                        throw {
                            name:'array is empty',
                            message: 'array is empty'
                        };
                    }
                    arrayOfItems = arguments[0];
                }
                else
                {
                    for(i = 0; i < len; i += 1) {
                        if(typeof (arguments[i]) !== 'object' || arguments[i] === 'undefined' ||
                                typeof(arguments[i].id) === 'undefined'){
                            throw {
                                name:'not an Item-like object',
                                message: 'not an Item-like object'
                            };
                        }
                        arrayOfItems.push(arguments[i]);
                    }
                }

                for(i = 0; i < arrayOfItems.length; i += 1){
                    this.items.push(arrayOfItems[i]);
                }

                return this;
            },
            find: function() {
                var i,
                    len;

                if(arguments.length === 1 && typeof(arguments[0]) === 'number'){
                    var id = arguments[0];
                    for (i = 0, len = this.items.length; i < len; i += 1) {
                        if (this.items[i].id === id) {
                            return this.items[i];
                        }
                    }
                    return null;
                }

                else{
                    if(arguments.length === 1 && typeof(arguments[0]) === 'object'){
                        var result = [];

                        if(arguments[0].id && arguments[0].name){
                            for (i = 0, len = this.items.length; i < len; i += 1) {
                                if (this.items[i].id === arguments[0].id &&
                                    this.items[i].name === arguments[0].name) {
                                    result.push(this.items[i]);
                                }
                            }
                            if(result.length){
                                return result;
                            }
                            return [];
                        }
                        else if(arguments[0].id){
                            for (i = 0, len = this.items.length; i < len; i += 1) {
                                if (this.items[i].id === arguments[0].id) {
                                    result.push(this.items[i]);
                                }
                            }
                            if(result.length){
                                return result;
                            }
                            return [];
                        }
                        else if(arguments[0].name){
                            for (i = 0, len = this.items.length; i < len; i += 1) {
                                if (this.items[i].name === arguments[0].name) {
                                    result.push(this.items[i]);
                                }
                            }
                            if(result.length){
                                return result;
                            }
                            return [];
                        }

                    }
                    else{
                        throw {
                            name:'not a number or object',
                            message: 'not a number or object'
                        };
                    }

                }
            },
            search: function(pattern){
                var i, len, result = [];
                if (typeof pattern != 'string' || pattern.length < 1){
                    throw {
                        name:'invalid pattern',
                        message: 'invalid pattern'
                    };
                }
                pattern = pattern.toLowerCase();

                for (i = 0, len = this.items.length; i < len; i += 1) {
                    if(this.items[i].name.toLowerCase().indexOf(pattern) >= 0 ||
                        this.items[i]._description.toLowerCase().indexOf(pattern) >= 0){
                        result.push(this.items[i]);
                    }
                }

                return result;
            }

        };

        return catalog;
    }());


    var bookCatalog = (function(parent){
        bookCatalog = Object.create(parent);
        bookCatalog.init = function(name){
            parent.init.call(this, name);
            return this;
        };
        bookCatalog.add = function() {
            return parent.add.call(this);
        };
        bookCatalog.find = function() {
            return parent.find.call(this);
        };

        Object.defineProperty(bookCatalog, 'getGenres', {
            value: function() {
                var result = [],
                    i, j,
                    len, length,
                    contained;
                for (i = 0, len = this.items.length; i < len; i += 1){
                    contained = false;
                    for (j = 0, length = result.length; j < length; j += 1){
                        if(this.items[i]._description.toLowerCase() === result[j]){
                            contained = true;
                            break;
                        }
                    }
                    if (contained === false){
                        result.add(this.items[i]._description.toLowerCase());
                    }
                }
                return result;
            }
        });


        return bookCatalog;
    }(catalog));


    var mediaCatalog = (function(parent){

        function byDurationThenById(pl1, pl2) {
            if (pl1.duration === pl2.duration) {
                return pl1.id - pl2.id;
            }
            return pl2.duration.localeCompare(pl1.duration);
        }

        mediaCatalog = Object.create(parent);
        mediaCatalog.init = function(name){
            parent.init.call(this, name);
            return this;
        };
        mediaCatalog.add = function() {
            return parent.add.call(this);
        };

        Object.defineProperty(mediaCatalog, 'getTop', {
            value: function(count) {
                var result = [];

                if (typeof count !== 'number' || count < 1){
                    throw {
                        name:'invalid count',
                        message: 'invalid count'
                    };
                }

                this.items.sort(function(item1, item2){
                   return item2.rating - item1.rating;
                });

                for (var i = 0; i < count; i += 1){
                    result.push(this.items[i]);
                }

                return result;
            }
        });

        Object.defineProperty(mediaCatalog, 'getSortedByDuration', {
            value: function() {
                var result = [], i, len;
                this.items.sort(byDurationThenById);
                for(i = 0, len = this.items.length; i < len; i += 1){
                    result.push(this.items[i]);
                }
                return result;
            }
        });

        return mediaCatalog;
    }(catalog));


    return {
        getBook: function (name, isbn, genre, description) {
            return Object.create(book).init(name, isbn, genre, description);
        },
        getMedia: function (name, rating, duration, description) {
            return Object.create(media).init(name, rating, duration, description);
        },
        getBookCatalog: function (name) {
            return Object.create(bookCatalog).init(name);
        },
        getMediaCatalog: function (name) {
            return Object.create(mediaCatalog).init(name);
        }
    };
}


var module = solve();
var catalog = module.getBookCatalog('John\'s catalog');

var book1 = module.getBook('The secrets of the JavaScript Ninja', '1234567890', 'IT', 'A book about JavaScript');
var book2 = module.getBook('JavaScript: The Good Parts', '0123456789', 'IT', 'A good book about JS');
catalog.add(book1);
//catalog.add(book2);
//
//console.log(catalog.find(book1.id));
////returns book1
//
//console.log(catalog.find({id: book2.id, genre: 'IT'}));
////returns book2
//
//console.log(catalog.search('js'));
//// returns book2
//
//console.log(catalog.search('javascript'));
////returns book1 and book2
//
//console.log(catalog.search('Te sa zeleni'))
////returns []
