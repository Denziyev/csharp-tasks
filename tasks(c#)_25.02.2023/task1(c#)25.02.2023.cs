Console.Write("Enter your point: ");
int exam_score = int.Parse(Console.ReadLine());
if (exam_score < 0 || exam_score > 100)
    Console.WriteLine("The exam point should be in the range of 0-100.");
else if (exam_score < 51)
    Console.WriteLine("You failed");
else if (exam_score < 61)
    Console.WriteLine("Your letter grade: E");
else if (exam_score < 71)
    Console.WriteLine("Your letter grade: D");
else if (exam_score < 81)
    Console.WriteLine("Your letter grade: C");
else if (exam_score < 91)
    Console.WriteLine("Your letter grade: B");
else Console.WriteLine("Your letter grade: A");
