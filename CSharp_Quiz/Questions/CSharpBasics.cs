using sync.Globalization.Localization
namespace Quiz_Beginners
{
    class CSharpBasics
    {

        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.
        /// </summary>
        /// 
         public void ImageSize()
        {
         Console.WriteLine("Enter the height of the image");// getting input from user(height)
         x=Convert.ToInt32(Console.ReadLine());// getting the value to a variable
         Console.WriteLine("Enter the width of the image");//getting input from user(width)
         y=Convert.ToInt32(Console.ReadLine());
        if (y > x)   
            type = "landscape";
        else
            type = "portrait";

        }


        /// <summary>
        /// Write a program which takes a single argument from the console, computes the factorial and prints the 
        /// value on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        /// and display it as 5! = 120.
        /// </summary>
        /// 
            public void Factorial()
            {
                 Console.WriteLine("Enter the number");// getting input 
                 x=Convert.ToInt32(Console.ReadLine());// getting the value to a variable
                while (x!=1)
                {
                     result=result*x; //calculating factorial
                     x=x-1;// decrementing the value by 1
                }  
                
               Console.WriteLine(result);
                
            }
            
                      
                              


        /// <summary>
        /// Ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. 
        /// Display the reversed name on the console.
        /// </summary>
        /// 
        public void DisplayName()
        {
            string str = "", reverse = "";  
            int Length = 0;  
            Console.WriteLine("Enter a Word"); //Getting String(word) from Console  
            str = Console.ReadLine();  
            Length = str.Length - 1;  //Calculate length of string str 
            while(Length>=0)  
            {  
                reverse = reverse + str[Length];  
                Length--;  
            }   
             Console.WriteLine("Reverse word is {0}",reverse);
            }  
            

     

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen. Work out 
        /// if the numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        /// display a message: "Consecutive"; otherwise, display "Not Consecutive".
        /// </summary>
        /// 

 public void ConsecutiveNumbers()
             {
                Console.WriteLine("Input a few numbers separated by a hyphen : ");
                string input = Console.ReadLine();
                string[] split = input.Split('-');
                string temp = split[0];

                for (int i = 1; i < split.Length; i++)
                   {
                       temp++;
                       Console.WriteLine(temp);

    
                if (temp == split[i])
                 {
                     Console.WriteLine("Consecutive");
                  }
                 else
                 {
                     Console.WriteLine("Not Consecutive");
                 }
                }
     
      }

    }
}
