# What database models do you know?

- Hierarchical (tree)
- Network (graph)
- Relational (table)
- Object-oriented

# Which are the main functions performed by a Relational Database Management System (RDBMS)?

Relational Database Management Systems (RDBMS) manage data stored in tables. RDBMS systems typically implement:
- Creating / altering / deleting tables and relationships between them (database schema)
- Adding, changing, deleting, searching and retrieving of data stored in the tables
- Support for the SQL language
- Transaction management (optional)

# Define what is "table" in database terms.

Database tables consist of data, arranged in rows and columns. All rows have the same structure. Columns have name and type (number, string, date, image, or other).

# Explain the difference between a primary and a foreign key.

The Primary key is a column of the table that uniquely identifies its rows (usually its is a number).
The foreign key is an identifier of a record located in another table (usually its primary key).

# Explain the different kinds of relationships between tables in relational databases.

- Relationship one-to-many (or many-to-one)
A single record in the first table has many corresponding records in the second table

- Relationship many-to-many
Records in the first table have many correspon-ding records in the second one and vice versa. Implemented through additional table

- Relationship one-to-one
A single record in a table corresponds to a single record in the other table. Used to model inheritance between tables

# When is a certain database schema normalized? What are the advantages of normalized databases?

Non-normalized schemas can contain many data repetitions. Normalization of the relational schema removes repeating data. 
The advantage is avoiding duplicated data and thus reducing the size of the Database

# What are database integrity constraints and when are they used?

Integrity constraints ensure data integrity in the database tables. They create data rules which cannot be violated

# Point out the pros and cons of using indexes in a database.

Pros
:   Indices speed up searching of values in a certain column or group of columns

Cons
:   Adding and deleting records in indexed tables is slower
:   Indices should be used for big tables only (e.g. 50 000 rows)

# What's the main purpose of the SQL language?

SQL (Structured Query Language) is a standardized declarative language for manipulation of relational databases. SQL language supports:
- Creating, altering, deleting tables and other objects in the database
- Searching, retrieving, inserting, modifying and deleting table data (rows)

# What are transactions used for? Give an example.

Transactions are a sequence of database operations which are executed as a single unit. Either all of them execute successfully, or none of them is executed at all
> **Example:** When a bank transfers money from one account to another, if the withdrawal or the deposit fails, the whole operation is cancelled.

# What is a NoSQL database?

NoSQL (non-relational) databases use document-based model (non-relational). This is a schema-free document storage which is highly optimized for append / retrieve

# Explain the classical non-relational data models.

In non-relational data models the data is stored as JSON strings or key-value pairs in documents. Documents do not have a fixed structure

# Give few examples of NoSQL databases and their pros and cons.

Redis
:   Ultra-fast in-memory data structures server
MongoDB
:   Mature and powerful JSON-document database
CouchDB
:   JSON-based document database with REST API
Cassandra
:   Distributed wide-column database