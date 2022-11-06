using ShapeClassDiagram;

Circle circle = new Circle(2.0, 5.3);
circle.SetRadius(5.6);
Console.WriteLine($"The Area of the circle is: {circle.Area()}");
Console.WriteLine($"The Parametar of the circle is: {circle.Parametar()}");
Console.WriteLine($"The location of the circle is: {circle.ToString()}");