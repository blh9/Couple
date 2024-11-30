public class MainClass
{
    public static void Main()
    {

        myFunction([5, 1, 3, 1, 3, 5, 52]);

    }


    static void myFunction(int[] arr)
    {
        Array.Sort(arr);


        for (int i = 0; i < arr.Length; i += 2)
        {


            if (i + 1 < arr.Length)
            {
                if (arr[i] != arr[i + 1])
                {
                    Console.WriteLine(arr[i]);
                }
            }
            else
            {
                Console.WriteLine(arr[arr.Length - 1]);
            }

        }



    }

}