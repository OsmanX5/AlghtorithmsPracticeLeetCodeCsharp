# Write your MySQL query statement below
SELECT
    r.contest_id ,ROUND(100 * (COUNT(r.user_id)/ (SELECT COUNT(*) FROM Users) ),2) AS percentage
FROM
    Register r
LEFT JOIN
    Users u
ON
    r.user_id = u.user_id
GROUP BY
    r.contest_id
ORDER BY 2 DESC , 1 