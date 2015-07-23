function solve() {
    var module = (function() {
        var playable,
            validator,
            audio,
            video,
            playlist,
            player;

        function getSortingFunction(firstParameter, secondParameter) {
            return function(first, second) {
                if (first[firstParameter] < second[firstParameter]) {
                    return -1;
                } else if (first[firstParameter] > second[firstParameter]) {
                    return 1;
                }

                if (first[secondParameter] < second[secondParameter]) {
                    return -1;
                } else if (first[secondParameter] > second[secondParameter]) {
                    return 1;
                } else {
                    return 0;
                }
            };
        }

        validator = {
            validateIfUndefined: function(obj) {
                if (obj === undefined) {
                    throw new Error('Undefined passed as an argument');
                }
            },
            validateString: function(str) {
                if (str.length < 3 || str.length > 25) {
                    throw new Error('Invalid string length');
                }
            },
            validateIfPositiveNumber: function(num) {
                if (num <= 0) {
                    throw new Error('Negative number');
                }
            },
            validateRating: function(rating) {
                if (rating < 1 || rating > 5) {
                    throw new Error('Invalid rating');
                }
            }
        };

        player = (function() {
            var player = Object.create({}),
                currentId = 0;

            Object.defineProperty(player, 'init', {
                value: function(name) {
                    this.name = name;
                    this._id = ++currentId;
                    this._playlists = [];

                    return this;
                }
            });

            Object.defineProperty(player, 'name', {
                get: function() {
                    return this._name;
                },
                set: function(value) {
                    validator.validateIfUndefined(value);
                    validator.validateRating(value);

                    this._name = value;
                }
            });

            Object.defineProperty(player, 'id', {
                get: function() {
                    return this._id;
                }
            });

            Object.defineProperty(player, 'addPlaylist', {
                value: function(playlist) {
                    validator.validateIfUndefined(playlist);
                    if (playlist.id === undefined) {
                        throw new Error('undefined playlist id');
                    }

                    this._playlists.push(playlist);
                    return this;
                }
            });

            Object.defineProperty(player, 'getPlaylistById', {
                value: function(id) {
                    validator.validateIfUndefined(id);
                    validator.validateIfPositiveNumber(id);

                    var foundIndex = -1;

                    for (var i = 0; i < this._playlists.length; i++) {
                        if (this._playlists[i].id === id) {
                            foundIndex = i;
                            break;
                        }
                    }

                    if (foundIndex < 0) {
                        return null;
                    }

                    return this._playlists[foundIndex];
                }
            });

            Object.defineProperty(player, 'removePlaylist', {
                value: function(id) {
                    var foundIndex = -1;

                    if (typeof id !== 'number') {
                        id = id.id;
                    }
                    validator.validateIfUndefined(id);
                    validator.validateIfPositiveNumber(id);

                    for (var i = 0; i < this._playlists.length; i++) {
                        if (this._playlists[i].id === id) {
                            foundIndex = i;
                            break;
                        }
                    }

                    if (foundIndex < 0) {
                        throw new Error('Invalid index');
                    }

                    this._playlists.splice(foundIndex, 1);
                    return this;
                }
            });

            Object.defineProperty(player, 'listPlaylists', {
                value: function(page, size) {
                    validator.validateIfUndefined(page);
                    validator.validateIfUndefined(size);
                    validator.validateIfPositiveNumber(size);
                    if (page < 0) {
                        throw new Error('page is less than zero');
                    }
                    if (page * size > this._playlists.length) {
                        throw new Error('page * size is bigger than the collection');
                    }

                    return this
                        ._playlists
                        .slice()
                        .sort(getSortingFunction('title', 'id'))
                        .splice(page * size, size);
                }
            });

            return player;
        }());

        playlist = (function() {
            var playlist = Object.create({}),
                currentID = 0;

            Object.defineProperty(playlist, 'init', {
                value: function(name) {
                    this.name = name;
                    this._id = ++currentID;
                    this._playableCollection = [];

                    return this;
                }
            });

            Object.defineProperty(playlist, 'name', {
                get: function() {
                    return this._name;
                },
                set: function(value) {
                    validator.validateIfUndefined(value);
                    validator.validateString(value);

                    this._name = value;
                }
            });

            Object.defineProperty(playlist, 'id', {
                get: function() {
                    return this._id;
                }
            });

            Object.defineProperty(playlist, 'addPlayable', {
                value: function(playable) {
                    validator.validateIfUndefined(playable);
                    // //validator.validateIfUndefined(playable.title);
                    // validator.validateString(playable.title);
                    // validator.validateIfUndefined(playable.author);
                    // validator.validateString(playable.author);

                    this._playableCollection.push(playable);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'getPlayableById', {
                value: function(id) {
                    validator.validateIfUndefined(id);
                    validator.validateIfPositiveNumber(id);

                    var foundIndex = -1;

                    for (var i = 0; i < this._playableCollection.length; i++) {
                        if (this._playableCollection[i].id === id) {
                            foundIndex = i;
                            break;
                        }
                    }

                    if (foundIndex < 0) {
                        return null;
                    }

                    return this._playableCollection[foundIndex];
                }
            });

            Object.defineProperty(playlist, 'removePlayable', {
                value: function(id) {
                    var foundIndex = -1;

                    if (typeof id !== 'number') {
                        id = id.id;
                    }
                    validator.validateIfUndefined(id);
                    validator.validateIfPositiveNumber(id);

                    for (var i = 0; i < this._playableCollection.length; i++) {
                        if (this._playableCollection[i].id === id) {
                            foundIndex = i;
                            break;
                        }
                    }

                    if (foundIndex < 0) {
                        throw new Error('Invalid index');
                    }

                    this._playableCollection.splice(foundIndex, 1);
                    return this;
                }
            });

            Object.defineProperty(playlist, 'listPlayables', {
                value: function(page, size) {
                    validator.validateIfUndefined(page);
                    validator.validateIfUndefined(size);
                    validator.validateIfPositiveNumber(size);
                    if (page < 0) {
                        throw new Error('page is less than zero');
                    }
                    if (page * size > this._playableCollection.length) {
                        throw new Error('page * size is bigger than the collection');
                    }

                    return this
                        ._playableCollection
                        .slice()
                        .sort(getSortingFunction('title', 'id'))
                        .splice(page * size, size);
                }
            });

            return playlist;
        }());

        playable = (function() {
            var playable = Object.create({}),
                currentID = 0;

            Object.defineProperty(playable, 'init', {
                value: function(title, author) {
                    this.title = title;
                    this.author = author;
                    this._id = ++currentID;
                    return this;
                }
            });

            Object.defineProperty(playable, 'title', {
                get: function() {
                    return this._title;
                },
                set: function(value) {
                    validator.validateIfUndefined(value);
                    validator.validateString(value);

                    this._title = value;
                }
            });

            Object.defineProperty(playable, 'author', {
                get: function() {
                    return this._author;
                },
                set: function(value) {
                    validator.validateIfUndefined(value);
                    validator.validateString(value);

                    this._author = value;
                }
            });

            Object.defineProperty(playable, 'id', {
                get: function() {
                    return this._id;
                }
            });

            Object.defineProperty(playable, 'play', {
                value: function() {
                    return this.id + '. ' + this.title + ' - ' + this.author;
                }
            });

            return playable;
        }());

        audio = (function(parent) {
            var audio = Object.create(parent);

            Object.defineProperty(audio, 'init', {
                value: function(title, author, length) {
                    parent.init.call(this, title, author);
                    this.length = length;

                    return this;
                }
            });

            Object.defineProperty(audio, 'length', {
                get: function() {
                    return this._length;
                },
                set: function(value) {
                    validator.validateIfUndefined(value);
                    validator.validateIfPositiveNumber(value);

                    this._length = value;
                }
            });

            Object.defineProperty(audio, 'play', {
                value: function() {
                    var parentOutput = parent.play.call(this),
                        output = parentOutput + ' - ' + this.length;

                    return output;
                }
            });

            return audio;
        }(playable));

        video = (function(parent) {
            var video = Object.create(parent);

            Object.defineProperty(video, 'init', {
                value: function(title, author, imdbRating) {
                    parent.init.call(this, title, author);
                    this.imdbRating = imdbRating;

                    return this;
                }
            });

            Object.defineProperty(video, 'imdbRating', {
                get: function() {
                    return this._imdbRating;
                },
                set: function(value) {
                    validator.validateIfUndefined(value);
                    validator.validateRating(value);

                    this._imdbRating = value;
                }
            });

            Object.defineProperty(video, 'play', {
                value: function() {
                    var parentOutput = parent.play.call(this),
                        output = parentOutput + ' - ' + this.imdbRating;

                    return output;
                }
            });

            return video;
        }(playable));

        return {
            getPlayer: function(name) {
                return Object.create(player).init(name);
            },
            getPlaylist: function(name) {
                return Object.create(playlist).init(name);
            },
            getAudio: function(title, author, length) {
                return Object.create(audio).init(title, author, length);
            },
            getVideo: function(title, author, imdbRating) {
                return Object.create(video).init(title, author, imdbRating);
            }
        };
    }());

    return module;
}
