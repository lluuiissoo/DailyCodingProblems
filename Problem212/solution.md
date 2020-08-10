Store all letters of the alphabet in a hashmap for easier retrieval

This solution will use recursivity

For a given column number, do the following:

- If column number is lower than 26,
    - find the corresponding letter in the hashmap
- If number is grerater than 26,
    - Divide the number by 26 and get the remainder and quotient
    - Find the encoding for the quotient and the encoding for the reminder, then merge the two of them

To improve the solution over time, consider populating a cache/hashtable with found keys, so that retrieval is faster.