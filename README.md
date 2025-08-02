# GPA Calculator

This is a simple C# console application for calculating a student's Grade Point Average (GPA) based on multiple course inputs.

## Features

- Input any number of courses.
- For each course, input:
  - Course name
  - Course code (currently not displayed in the results)
  - Course unit
  - Course score
- Calculates grade, grade unit, weight point, and remark for each course.
- Computes total units registered, total units passed, total weight point, and GPA.
- Displays a formatted table of results.

## How to Use

1. Run the application.
2. Enter the number of courses you want to input.
3. For each course, follow the prompts to enter the required details.
4. After all courses are entered, the program will display a summary table and your GPA.

## Grading System

| Score Range | Grade | Grade Unit | Remark      |
|-------------|-------|------------|-------------|
| 70 - 100    | A     | 5          | Excellent   |
| 60 - 69     | B     | 4          | Very Good   |
| 50 - 59     | C     | 3          | Good        |
| 45 - 49     | D     | 2          | Fair        |
| 40 - 44     | E     | 1          | Pass        |
| 0  - 39     | F     | 0          | Fail        |

## File Structure

- [`Program.cs`](Program.cs): Main application logic, including course input, GPA calculation, and result display.

## Example Output

```
How many courses do you want to input? 2
Enter course name: Mathematics
Enter course code: MTH101
Enter course unit: 3
Enter course score: 75
Enter course name: English
Enter course code: ENG101
Enter course unit: 2
Enter course score: 65
|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------|
| COURSE & CODE   | COURSE UNIT | GRADE | GRADE-UNIT | WEIGHT Pt.  | REMARK       |
|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------|
| Mathematics              | 3            | A      | 5          | 15              | Excellent      |
| English                  | 2            | B      | 4          | 8               | Very Good      |
|----------------------------|-----------------------|------------|---------------------|-------------------|-------------------|
Total Course Unit Registered is 5
Total Course Unit Passed is 5
Total Weight Point is 23
Your GPA is = 4.60 to 2 decimal places.
```

## Notes

- The course code is prompted but not displayed in the results table.
- Input validation is minimal; invalid inputs may cause errors.
