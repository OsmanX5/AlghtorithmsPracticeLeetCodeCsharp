WITH even AS (
    SELECT id-1 AS id, student
    FROM Seat
    WHERE id %2=0
),
odd AS (
    SELECT id+1 AS id, student
    FROM Seat
    WHERE id %2 !=0 AND id != (SELECT COUNT(id) FROM Seat)
),
final AS (
    SELECT id AS id, student
    FROM Seat
    WHERE id %2 !=0 AND id = (SELECT COUNT(id) FROM Seat)
)
SELECT * 
FROM (
    (SELECT * FROM even)
    UNION
    (SELECT * FROM odd)
    UNION
    (SELECT * FROM final)
)
ORDER BY id

