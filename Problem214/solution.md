1. Create a function to convert integer to binary reppresentation

2. Loop thru each binary digit and record consecutives 1, use a counter to keep the maximum count

Find binary representation:
This solution will use recursivity

For a given n integer, do the following:

- If number is 0 or 1,
    - return 0, 1 respectively
- If number is 2 or greater,
    - Divide the number by 2 and get the remainder and quotient
    - Find the binary representation for the quotient and the binary representation for the reminder, then merge the two of them

To improve the solution over time, consider populating a cache/hashtable with found keys, so that retrieval is faster.