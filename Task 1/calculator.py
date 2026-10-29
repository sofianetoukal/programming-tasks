
print("Simple Calculator")

a = float(input("First number: "))
b = float(input("Second number: "))
op = input("Choose +, -, * or /: ")

if op == "+":
    print("Result:", a + b)
elif op == "-":
    print("Result:", a - b)
elif op == "*":
    print("Result:", a * b)
elif op == "/":
    if b == 0:
        print("Cannot divide by zero")
    else:
        print("Result:", a / b)
else:
    print("Wrong operation")
