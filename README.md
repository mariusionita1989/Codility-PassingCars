# Codility-PassingCars
A non-empty array A consisting of N integers is given.</br>
The consecutive elements of array A represent consecutive cars on a road.</br>
Array A contains only 0s and/or 1s:</br>
0 represents a car traveling east,</br>
1 represents a car traveling west.</br>
The goal is to count passing cars.</br>
We say that a pair of cars (P, Q), where 0 ≤ P < Q < N,</br>
is passing when P is traveling to the east and Q is traveling to the west.

For example, consider array A such that:</br>
A[0] = 0</br>
A[1] = 1</br>
A[2] = 0</br>
A[3] = 1</br>
A[4] = 1</br>
We have five pairs of passing cars: (0, 1), (0, 3), (0, 4), (2, 3), (2, 4).

Write a function:</br>
class Solution { public int solution(int[] A); }</br>
that, given a non-empty array A of N integers,</br> 
returns the number of pairs of passing cars.</br>
The function should return −1 if the number of pairs of passing cars exceeds 1,000,000,000.

For example, given:</br>
A[0] = 0</br>
A[1] = 1</br>
A[2] = 0</br>
A[3] = 1</br>
A[4] = 1</br>
the function should return 5, as explained above.

Write an efficient algorithm for the following assumptions:</br>
N is an integer within the range [1..100,000];</br>
each element of array A is an integer that can have one of the following values: 0, 1.
