
/// <summary>
/// https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true
/// </summary>
class Program
{
    public static void Main(string[] args)
    {
        List<int> values = new List<int>()
        {
            73
            , 67
            , 38
            , 33
        };

        List<int> result = GradingStudents(values);
        
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }
    }   
    
    /// <summary>
    /// Returns Grades of Students
    /// </summary>
    /// <param name="grades"></param>
    /// <returns></returns>
    static List<int> GradingStudents(List<int> grades)
    {
        List<int> results = new ();
        
        // Proccess all grades
        foreach(int grade in grades)
        {
            int rounded = 0;

            if (grade < 38)
            {
                results.Add(grade);
                continue;
            }
            
            // next multiple of 5
            if ((grade % 5) == 0)
            {
                rounded = grade;
            }
            else
            {
                int multiple = (grade / 5) + 1;
                rounded = 5 * multiple;
            }

            int difference = rounded - grade;
            
            // less than 3
            if(difference < 3) {
                results.Add(rounded);
            }
            else {
                results.Add(grade);
            }
        }
        
        return results;
    }
    
}

