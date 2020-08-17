# Merge Sort
------------------
- It is a sorting algorithm Merge that divides an array into sub arrays and when then when sorts those
- sub arrays and merges it back to become one sorted array.
- This task is accomplished by using recursion and a while Loop.
# Pseudo Code
---------------
ALGORITHM Mergesort(arr)
    DECLARE n <-- arr.length
           
    if n > 1
      DECLARE mid <-- n/2
      DECLARE left <-- arr[0...mid]
      DECLARE right <-- arr[mid...n]
      // sort the left side
      Mergesort(left)
      // sort the right side
      Mergesort(right)
      // merge the sorted left and right sides together
      Merge(left, right, arr)

ALGORITHM Merge(left, right, arr)
    DECLARE i <-- 0
    DECLARE j <-- 0
    DECLARE k <-- 0

    while i < left.length && j < right.length
        if left[i] <= right[j]
            arr[k] <-- left[i]
            i <-- i + 1
        else
            arr[k] <-- right[j]
            j <-- j + 1
            
        k <-- k + 1

    if i = left.length
       set remaining entries in arr to remaining values in right
    else
       set remaining entries in arr to remaining values in left

# Trace
Sample Array : [8,4,23,42,16,15]


# Visuals
![Image](\assets\Visual.png)

- Checks the length of the array.
- If number of the length is greater than one then the array is split into 2 sides(left and right).
- Recursively mergesort the left side until there is only one in each sub array.
- Then it does the same to the other side.
- Once done it get thrown into the merge method.
- In the merge the value of the left and right are checked in a while loop and sorted and put back in the array.


# Efficiency
---------------
- Time - O(nlogn)
- Space - O(n)