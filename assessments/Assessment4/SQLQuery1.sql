-- #1
CREATE TABLE Movies 
(
	id INT IDENTITY(1, 1) PRIMARY KEY,
	genre NVARCHAR(45),
	title NVARCHAR(250),
	releaseyear INT
);

-- #2
INSERT Movies
(
	genre,
	title,
	releaseyear
)
VALUES
('Comedy', 'Mary Poppins', 1964),
('Drama', 'Saving Mr. Banks', 2013),
('Action', 'Big Hero 6', 2014),
('Action', 'The Last Dragon', 1985),
('Documentary', 'Superheroes', 2011);

-- #3
UPDATE Movies
SET genre = 'Comedy'
WHERE id = 4

-- #4
DELETE FROM Movies
WHERE id = 5

-- #5
SELECT * 
FROM Movies 
WHERE genre = 'Action'

-- #6
SELECT *
FROM Movies
WHERE id < 3

-- #7
SELECT *
FROM Movies
WHERE title = 'Mary Poppins' AND releaseyear < 2000


-- #8
SELECT * 
FROM Movies
WHERE genre != 'Documentary'


-- #9
UPDATE Movies
SET genre = null
WHERE id = 3

-- #10
DROP TABLE Movies