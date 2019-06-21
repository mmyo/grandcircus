CREATE SCHEMA Class;
GO

CREATE TABLE Class.Student
(
	StudentId INT IDENTITY(1, 1) PRIMARY KEY,
	FirstName VARCHAR(60),
	LastName VARCHAR(100)
);

--ALTER TABLE Class.Student
--ALTER COLUMN FirstName VARCHAR(60) NOT NULL;
--DROP TABLE Class.Student;

INSERT Class.Student
(
	FirstName,
	LastName
)
VALUES
(
	'jason',
	'robert'
)

--not going to work, because studentid must auto-increment
INSERT Class.Student
(
	StudentId,
	FirstName,
	LastName
)
VALUES
(
	2,
	'james',
	'jackson'
)

--not going to work, because FirstName can't be null
INSERT Class.Student
(
	LastName
)
VALUES
(
	'jackson'
)

-- see all data in class.student table
SELECT *
FROM Class.Student

UPDATE Class.Student
SET LastName = 'Roberts'
WHERE StudentId = 1

DELETE Class.Student
WHERE StudentId = 1


