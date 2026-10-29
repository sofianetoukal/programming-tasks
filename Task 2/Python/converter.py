
print("Temperature Converter")

choice = input("Choose c or f: ")
temp = float(input("Enter temperature: "))

if choice == "c":
    result = temp * 1.8 + 32
    print("Result:", result, "F")

elif choice == "f":
    result = (temp - 32) / 1.8
    print("Result:", result, "C")

else:
    print("Wrong choice")
