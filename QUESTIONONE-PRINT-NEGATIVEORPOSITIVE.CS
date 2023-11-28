import random

# Assign a random number to the variable n
n = random.randint(-20, 10)

# Print the value of n
print("Random number:", n)

# Check if the number is positive, negative, or zero
if n > 0:
    print("The number is positive.")
elif n < 0:
    print("The number is negative.")
else:
    print("The number is zero.")
