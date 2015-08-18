/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		ok*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		ok*	age must always be a number in the range 0 150
			ok*	the setter of age can receive a convertible-to-number value
		ok*	if any of the above is not met, throw Error
	*	property `fullname`
		ok*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		ok*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			ok*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {
		function Person(firstname, lastname, age) {
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = +age;
		}

		function validateName(name){
			var i,
				len,
				charCode;

			if (typeof(name) !== 'string') {
				return false;
			}

			if (name.length < 3 || name.length > 20) {
				return false;
			}

			for (i = 0, len = name.length; i < len; i += 1) {
				charCode = name.charCodeAt(i);
				if ((charCode < 65 && charCode > 90) && (charCode < 97 && charCode > 122)) {
					return false;
				}
			}

			return true;
		}

		function validateAge(age) {
			if (isNaN(+age)) {
				return false;
			}

			if (+age < 0 || +age > 150) {
				return false;
			}

			return true;
		}

		Object.defineProperty(Person.prototype, 'firstname', {
			get: function () {
				return this._firstname;
			},
			set: function (firstname) {
				if (!validateName(firstname)) {
					throw new Error('Name is invalid');
				}
				this._firstname = firstname;

				return this;
			}

		});

		Object.defineProperty(Person.prototype, 'lastname', {
			get: function () {
				return this._lastname;
			},
			set: function (lastname) {
				if (!validateName(lastname)) {
					throw new Error('Name is invalid');
				}
				this._lastname = lastname;

				return this;
			}
		});

		Object.defineProperty(Person.prototype, 'age', {
			get: function () {
				return this._age;
			},
			set: function (age) {
				if (!validateAge(age)) {
					throw new Error('Age is invalid');
				}
				this._age = +age;

				return this;
			}
		});

		Object.defineProperty(Person.prototype, 'fullname', {
			get: function () {
				return this._firstname + ' ' + this._lastname;
			},
			set: function (fullname) {
				var full = fullname.split(' ');
				this._firstname = full[0];
				this._lastname = full[1];

				return this;
			}
		});

		Person.prototype.introduce = function() {
			return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
		};
		
		return Person;
	} ());
	return Person;
}
module.exports = solve;