# Insertion sort
------------------
  - It is a sorting algorithm that traverses over an array and sorts them by 
  by choosing an item and sorting everything that is less than its value to the 
left.
- This task is accomplished by using a  for Loop(tracks of the sorted and unsorted) and a while loop 
(sorts current item)

# Pseudo Code
---------------

 InsertionSort(int[] arr)
  
    FOR i = 1 to arr.length
    
      int j <-- i - 1
      int temp <-- arr[i]
      
      WHILE j >= 0 AND temp < arr[j]
        arr[j + 1] <-- arr[j]
        j <-- j - 1
        
      arr[j + 1] <-- temp


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
- Space: O(1)
No additional space is being created. This array is being sorted in place.
- Time : O(N^2)
-It Loops the array twice .  