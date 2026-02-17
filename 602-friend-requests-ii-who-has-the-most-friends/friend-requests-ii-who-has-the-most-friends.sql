WITH req AS(
    SELECT 
        requester_id AS id,
        COUNT(*) As num
    FROM
        RequestAccepted
    GROUP BY
        requester_id
),
acc AS (
    SELECT 
        accepter_id AS id,
        COUNT(*) As num
    FROM
        RequestAccepted
    GROUP BY
        accepter_id
),
_all AS (
    SELECT id , SUM(num) AS num 
    FROM (
        SELECT * FROM req
        UNION ALL
        SELECT * FROM acc
    )
    GROUP BY id
)
SELECT 
    * 
FROM _all
ORDER BY num DESC
LIMIT 1

