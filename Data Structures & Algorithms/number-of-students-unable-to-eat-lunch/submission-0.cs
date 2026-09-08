public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        
        int[] count = new int[2];

        foreach(int student in students)
        {
            count[student]++;
        }

        foreach(int sandwich in sandwiches)
        {
            if(count[sandwich] == 0)
            {
                return count[0] + count[1];
            }
            count[sandwich]--;
        }
        return 0;
    }
}