


SELECT DISTINCT
    s.user_id , 
    ROUND(
        IFNULL(SUM(action = 'confirmed') OVER (PARTITION BY user_id),0)
        /
        COUNT(*) OVER (PARTITION BY user_id) 
        ,2
    )AS confirmation_rate
FROM Signups s
LEFT JOIN Confirmations c
ON s.user_id = c.user_id