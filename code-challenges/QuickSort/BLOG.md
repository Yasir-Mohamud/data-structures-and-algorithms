# Quick sort
------------------


# Pseudo Code
---------------

ALGORITHM QuickSort(arr, left, right)
    if left < right
        // Partition the array by setting the position of the pivot value 
        DEFINE position <-- Partition(arr, left, right)
        // Sort the left
        QuickSort(arr, left, position - 1)
        // Sort the right
        QuickSort(arr, position + 1, right)

ALGORITHM Partition(arr, left, right)
    // set a pivot value as a point of reference
    DEFINE pivot <-- arr[right]
    // create a variable to track the largest index of numbers lower than the defined pivot
    DEFINE low <-- left - 1
    for i <- left to right do
        if arr[i] <= pivot
            low++
            Swap(arr, i, low)

     // place the value of the pivot location in the middle.
     // all numbers smaller than the pivot are on the left, larger on the right. 
     Swap(arr, right, low + 1)
    // return the pivot index point
     return low + 1

ALGORITHM Swap(arr, i, low)
    DEFINE temp;
    temp <-- arr[i]
    arr[i] <-- arr[low]
    arr[low] <-- temp
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
![image](assets\one.png)
![image](assets\two.png)
![image](assets\three.png)
![image](assets\four.png)

-The for loop runs the length of the array.
- The i keeps track of the sorted and unsorted sides
-Set J to be i - 1 
- Set temp to be arr[i]
- In the while it check to see if the temp is less than arr[j] and if j is greater/equal to 0
- Makes value arr[j+1] equal to the value of arr[j]
- Set j to j - 1
- if the conditions in the while loop were false then set arr[j+1] = temp

# Efficiency
---------------
  