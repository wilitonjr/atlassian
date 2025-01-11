Potential Improvement
  •	Hyphen Check Optimization: Instead of repeatedly checking whether response[index] is empty, 
    I could hace initialized it with an empty string and directly append word with a hyphen if necessary.
 
 
Complexity Analysis

Time Complexity:
	•	The loop iterates through all the words in the words array:
    O(n), where n is the number of words.

Space Complexity:
	•	The space required is proportional to the number of words and their total length since they are stored in the response list.
	•	If there are n words and the average word length is m, the space complexity for the response list is:
    O(n * m).
