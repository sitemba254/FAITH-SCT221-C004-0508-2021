def prefix_length(s, prefix):
    """
    Get the length of the prefix substring in the given string.

    Parameters:
    - s: The input string.
    - prefix: The prefix substring.

    Returns:
    - The length of the prefix substring. Returns 0 if the prefix is not found.
    """
    if s.startswith(prefix):
        return len(prefix)
    else:
        return 0

# Example usage
input_string = "MERCEDEZ_BENZ"
input_prefix = "MERCEDEZ"

result = prefix_length(input_string, input_prefix)
print("Length of prefix substring:", result)
