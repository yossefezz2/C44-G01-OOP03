internal class Program
{
    private static void Main(string[] args)
    {
        #region Part 1 Question 1  
        //Console.WriteLine(Calculator.Add(5, 15));
        //Console.WriteLine(Calculator.Add(5.5, 15));
        //Console.WriteLine(Calculator.Add(5, 15, 20));
        #endregion

        #region Part 1 Question 2  
        //Rectangle rectangle1 = new Rectangle();
        //Rectangle rectangle2 = new Rectangle(5,15); 
        //Rectangle rectangle3 = new Rectangle(5);

        //Console.WriteLine(rectangle1.GetArea());
        //Console.WriteLine(rectangle2.GetArea());
        //Console.WriteLine(rectangle3.GetArea());
        #endregion

        #region Part 1 Question 3
        //ComplexNumber complexNumber1 = new ComplexNumber(3, 4);
        //ComplexNumber complexNumber2 = new ComplexNumber(1, 2);

        //Console.WriteLine($"Complex + Complex : {complexNumber1 + complexNumber2}");
        //Console.WriteLine($"Complex + Int : {complexNumber1 + 5}");
        //Console.WriteLine($"Int + Complex : {5 + complexNumber1}");

        //Console.WriteLine("---------------------- Sub -------------------------");

        //Console.WriteLine($"Complex - Complex : {complexNumber1 - complexNumber2}");
        //Console.WriteLine($"Complex - Int : {complexNumber1 - 5}");
        //Console.WriteLine($"Int - Complex : {5 - complexNumber1}");

        #endregion

        #region Part 1 Question 4

        Employee employee = new Employee();
        Console.WriteLine(employee.Working());
        
        Manager manager = new Manager();
        Console.WriteLine(manager.Working());


        Employee employee1 = new Manager();
        Console.WriteLine(employee1.Working());
        #endregion


    }
}
