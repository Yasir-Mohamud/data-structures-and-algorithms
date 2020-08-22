# Hashtables
<!-- Short summary or background information -->
HashTables are data structures that utilizes key-value pairs meaning each bucket/node has a key-value pair.

## Challenge
<!-- Description of the challenge -->
Implement a Hashtable with methods Add, GetHash, Contains and Get
## Approach & Efficiency
<!-- What approach did you take? Why? What is the Big O space/time for this approach? -->
Time - O(1)
Space- O(n)

## API
<!-- Description of each method publicly available in each of your hashtable -->
Add: takes in both the key and value. This method uses Gethash and hashes the key and add the key and value pair to the table, handling collisions as needed.
Get: takes in the key and returns the value from the table.
Contains: takes in the key and returns a boolean, indicating if the key exists in the table already.
Gethash: takes in an string as a key and returns an index in the hashtable.