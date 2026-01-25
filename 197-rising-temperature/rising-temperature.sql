SELECT w.id
FROM Weather  w 
LEFT JOIN Weather  w2
ON w.recordDate -INTERVAL 1 DAY= w2.recordDate 
WHERE w.temperature >w2.temperature
