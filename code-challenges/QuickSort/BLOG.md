# Quick Sort
------------------
- It is a sorting algorithm that sorts and array by partioning it into right and left sides of the same array
declaring a pivot and having all elements greater than the pivot on the right , and all less than on the right of the pivot
- This task is accomplished by using recursion and a for Loop.
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
# Trace
Sample Array : [8,4,23,42,16,15]


# Visuals
![Image](assets\Visual.png)
- Put in the array , its most left and right index.
- If the left index is smaller than the right index then the array is partioned 
and it returns the the array with its  pivot in the middle and the values greater 
than the pivot will be on the right while the values less than will be on the left.
- Then quick sort is recursively called on the left side until it is completley sorted
then the same happens to the right side.
- Returns the sorted array.



# Efficiency
---------------
- Time - O(nlogn)
- Space - O(log(n))