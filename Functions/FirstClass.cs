namespace BlazorTemplate.Functions
{
    public class FirstClass
    {
        public FirstClass()
        {
            Console.WriteLine("Hello");
        }

        public string GetHello()
        {
            return "My first method call - YAIIII";
        }
    }

    

    // VS -> View -> Terminal:
    // dotnet watch run debug
}
