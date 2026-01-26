WITH full_table AS (
    SELECT *
    FROM Students
    JOIN Subjects
),
exams_attend AS (
SELECT student_id,subject_name,COUNT(*) as attended_exams
FROM Examinations
GROUP BY student_id , subject_name
)
SELECT 
    full_table.student_id,
    full_table.student_name,
    full_table.subject_name,
    IFNULL(exams_attend.attended_exams,0) AS attended_exams
FROM full_table
LEFT JOIN exams_attend
ON 
    full_table.student_id= exams_attend.student_id
    AND
    full_table.subject_name = exams_attend.subject_name
ORDER BY full_table.student_id,full_table.subject_name

