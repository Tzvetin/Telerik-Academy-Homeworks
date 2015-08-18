/* Task Description */
/* 
* Create a module for a Telerik Academy course
  * The course has a title and presentations
    * Each presentation also has a title
    * There is a homework for each presentation
  * There is a set of students listed for the course
    * Each student has firstname, lastname and an ID
      * IDs must be unique integer numbers which are at least 1
  * Each student can submit a homework for each presentation in the course
  * Create method init
    * Accepts a string - course title
    * Accepts an array of strings - presentation titles
    * Throws if there is an invalid title
      * Titles do not start or end with spaces
      * Titles do not have consecutive spaces
      * Titles have at least one character
    * Throws if there are no presentations
  * Create method addStudent which lists a student for the course
    * Accepts a string in the format 'Firstname Lastname'
    * Throws if any of the names are not valid
      * Names start with an upper case letter
      * All other symbols in the name (if any) are lowercase letters
    * Generates a unique student ID and returns it
  * Create method getAllStudents that returns an array of students in the format:
    * {firstname: 'string', lastname: 'string', id: StudentID}
  * Create method submitHomework
    * Accepts studentID and homeworkID
      * homeworkID 1 is for the first presentation
      * homeworkID 2 is for the second one
      * ...
    * Throws if any of the IDs are invalid
  * Create method pushExamResults
    * Accepts an array of items in the format {StudentID: ..., Score: ...}
      * StudentIDs which are not listed get 0 points
    * Throw if there is an invalid StudentID
    * Throw if same StudentID is given more than once ( he tried to cheat (: )
    * Throw if Score is not a number
  * Create method getTopStudents which returns an array of the top 10 performing students
    * Array must be sorted from best to worst
    * If there are less than 10, return them all
    * The final score that is used to calculate the top performing students is done as follows:
      * 75% of the exam result
      * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
*/

function solve() {
	var Course = {
		init: function(title, presentations) {
			checkTitle(title);
			this.title = title;
			checkPresentations(presentations);
			this.presentations = presentations;
			this.students = [];
			return this;
		},
		addStudent: function(name) {
			var names,
				student = {};

			if (typeof name !== 'string') {
				throw new Error();
			}

			names = name.split(' ');

			if (names.length !== 2) {
				throw new Error();
			}

			//Names start with an upper case letter
			//All other symbols in the name (if any) are lowercase letters
			names.forEach(function(n){
				if(!/^[A-Z][a-z]*$/.test(n)){
					throw new Error();
				}
			});

			student.firstname = names[0];
			student.lastname = names[1];
			student.id = this.students.length + 1;
			student.visitedExam = false;
			student.score = 0;
			this.students.push(student);
			return student.id;
		},
		getAllStudents: function() {
			return this.students.slice();
		},
		submitHomework: function(studentID, homeworkID) {
			checkID(studentID, this.students);
			checkID(homeworkID, this.presentations);

			this.students.forEach(function (student) {
				if (student.id === studentID) {
					if (student.homeworks === undefined) {
						student.homeworks = 1;
					} else {
						student.homeworks += 1;
					}
				}
			});

		},
		pushExamResults: function(results) {
			var i,
				len,
				studentId,
				score;

			if(!isArray(results)) {
				throw new Error();
			}

			for (i = 0, len = results.length; i < len; i += 1) {
				studentId = results[i].StudentID;
				score = results[i].Score;

				if (isNaN(score) || score === ''){
					throw new Error();
				}

				if (!this.students[studentId - 1]) {
					throw new Error();
				}

				if (this.students[studentId - 1].visitedExam === true) {
					throw new Error();
				}

				this.students[studentId - 1].visitedExam = true;
				this.students[studentId - 1].score = score;
			}
			return this;
		},
		getTopStudents: function() {
			var topStudents;

			this.students.forEach(function(student) {
				student.totalScore = (0.75 * student.score) + (0.25 * student.homeworks * 100/ this.presentations.length);
			});

			this.students.sort(function(student1, student2) {
				return student1.totalScore - student2.totalScore;
			});

			topStudents = this.students.slice(10);

			return topStudents;
		}
	};

	function checkTitle(title) {
	//Titles do not start or end with spaces
	//Titles do not have consecutive spaces
	//Titles have at least one character
		if (title.length < 1 || typeof title !== 'string') {
			throw new Error();
		}

		if (/^\s|\s$|\s{2,}/.test(title)) {
			throw new Error();
		}
	}

	function checkPresentations(presentations) {
		if (presentations.length === 0 || presentations === null) {
				throw new Error();
		}
		presentations.forEach(function(title) {
			checkTitle(title);
		});
	}

	function checkID(id, collection) {
		if (id !== Number(id)) {
			throw new Error();
		}
		if (id < 1 || id > collection.length) {
			throw new Error();
		}
	}

	return Course;
}


module.exports = solve;
