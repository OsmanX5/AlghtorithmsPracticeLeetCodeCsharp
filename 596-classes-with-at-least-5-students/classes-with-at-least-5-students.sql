WITH filter AS(
    SELECT
    class,COUNT(student) AS cnt
    FROM Courses
    GROUP BY class
)

SELECT class
FROM filter
WHERE cnt >=5