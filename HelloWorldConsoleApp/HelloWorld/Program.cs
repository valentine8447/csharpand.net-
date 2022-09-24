using HelloWorld.NAMESPACEEX; 

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 20;
            string myName = "Valentine";
            bool myBool = false;
            DateTime myDateTime = DateTime.Now;
            object myObject = new { name = "Valentine", age = 38, code = true};
            double[] myArray = new double[] { 2.3, 33.2, 10.5 };
            List<double> myArray2 = new List<double>() { 2.3, 33.2, 10.5 };

            Console.WriteLine("myNumber: " + myNumber);
            Console.WriteLine("myName: " + myName);
            Console.WriteLine("myBool: " + myBool);
            Console.WriteLine("myDateTime: " + myDateTime);
            Console.WriteLine("myObject: " + myObject);

            foreach (double numbers in myArray)
            {
                Console.WriteLine("numbers: " + numbers);
            }

            foreach (double numbers in myArray2)
            {
                Console.WriteLine("numbers: " + numbers);
            }

            Class1.MyName = "Valentine";+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Class1.MyMethod();

            //bool isHot = true;



            // implicit convert
            int myNum = 56;
             long myLongNumber = myNum;


            int myNum2 = Convert.ToInt32(myLongNumber);
            int myNum3 = (int)myLongNumber;





            int i = 75;
            float f = 53.005f;
            double d = 2345.7652;
            bool b = true;



            Console.WriteLine(i.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine(d.ToString());
            Console.WriteLine(b.ToString());



            char c = Convert.ToChar(26);
            Console.WriteLine(c);


            int userNumber;
            Console.WriteLine("Enter a number from 1 to 100");
            userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userNumber.GetType());

            userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(userNumber.GetType());
        }
    }
}
