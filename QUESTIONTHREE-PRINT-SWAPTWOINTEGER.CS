def swap_integers(a, b):
    # Print the original values
    print("Original values: a =", a, ", b =", b)

    # Swap the values using a temporary variable
    temp = a
    a = b
    b = temp

    # Alternatively, you can use a one-liner for swapping without a temporary variable:
    # a, b = b, a

    # Print the values after swapping
    print("After swapping: a =", a, ", b =", b)

# Example usage
integer1 = 5
integer2 = 10

swap_integers(integer1, integer2)
