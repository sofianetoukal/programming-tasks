
print("Student Grade Average")

n = int(input("How many grades? "))
total = 0

if n > 0:
    for i in range(n):
        grade = float(input("Enter grade: "))
        total = total + grade

    average = total / n
    print("Average:", f"{average:.2f}")

    if average >= 3.0:
        print("The student passed.")
    else:
        print("The student failed.")
else:
    print("Enter at least one grade.")
