WITH start AS(
    SELECT machine_id,process_id,timestamp 
    FROM Activity 
    WHERE activity_type = 'start'
), end AS(
        SELECT machine_id,process_id,timestamp 
    FROM Activity 
    WHERE activity_type = 'end'
)
SELECT s.machine_id ,
    ROUND(AVG(e.timestamp - s.timestamp ),3) AS processing_time
FROM start s
JOIN end e
ON s.machine_id = e.machine_id AND e.process_id = s.process_id
GROUP BY machine_id