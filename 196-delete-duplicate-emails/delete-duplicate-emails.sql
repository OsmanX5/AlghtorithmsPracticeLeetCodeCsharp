WITH to_delete AS(
    SELECT 
    b.id
    FROM Person a
    JOIN Person b
    ON a.email = b.email AND b.id>a.id
)
DELETE 
FROM Person
WHERE id IN (SELECT * FROM to_delete)