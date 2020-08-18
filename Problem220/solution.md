| c1 | c2 | c3 | c4 | c5 | c6 |

Always get the greater of two available coins.



1. Create and array with N values, create two pointers, Left and Right, to represent available corners

2. Loop thru all coins

3. For each iteration determine whose player's turn it is
(If iteration number is odd, then is P1's turn; else is P2's)

4. For each iteration, calculate the max available value, assign it to the corresponding player, and move the pointer accordingly

int[] arr = new arr[n] {1,2,3,4,5,6}

int P1 = P2 = 0; //Starting score

int pLeft = 0; //Left corner

int pRight = n-1; //Right corner

while (pLeft <= pRight)
{
    if (i % 2 == 1) //Odd, P1's turn
    {
        if (arr[pLeft] > arr[pRight])
        {
            P1 += arr[pLeft];
            pLeft++;            
        }
        else
        {
            P1 += arr[pRight];
            pRight--;            
        }
    }
    else //Even, P2's turn
    {
        if (arr[pLeft] > arr[pRight])
        {
            P2 += arr[pLeft];
            pLeft++;            
        }
        else
        {
            P2 += arr[pRight];
            pRight--;            
        }
    }
}


