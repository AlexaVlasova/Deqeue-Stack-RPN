using MyDeqeue;
internal class Program
{
    static async Task Main(string[] args)
    {
        #region MyDeqeue check

        MyDeqeue<int> n = new MyDeqeue<int>();
        n.EmptyCheck();
        n.AddToEnd(1);
        n.AddToEnd(2);
        n.AddToStart(10);
        n.Print();
        Console.WriteLine();

        n.EmptyCheck();
        n.AddToEnd(6);
        n.PopFromStart();
        n.Print();

        Console.WriteLine();
        n.WatchFirst();
        n.WatchLast();
        n.EmptyCheck();

        #endregion

        #region RPN

        // FOR READING FROM FILE
        //string Path = @"C:\Users\Саша\Desktop\file.txt";
        //using (FileStream fstream = File.OpenRead(Path))
        //{
        //    byte[] buffer = new byte[fstream.Length];
        //    string[] mas = new string[fstream.Length];
        //    await fstream.ReadAsync(buffer, 0, buffer.Length);
        //    string textFromFile = Encoding.Default.GetString(buffer);
        //    Console.WriteLine($"Пример из файла: {textFromFile}");
        //    textFromFile.Split(" ");
        //mas = textFromFile.Split(' ').ToArray();


        string[] mas = { "8", "9", "+", "1", "7","-", "*"};
        Stack<string> stack = new Stack<string>();
        int result = 0;
        int last, prelast;
        foreach (string symbol in mas)
        {


            if (symbol != "+" & symbol != "-" & symbol != "*" & symbol != " ")
            {
                stack.Push(symbol);
            }
            else
            {
                switch (symbol)
                {
                    case "+":
                        last = (int)Convert.ToInt32(stack.Pop());
                        prelast = (int)Convert.ToInt32(stack.Pop());
                        result = prelast + last;
                        stack.Push(result.ToString());
                        break;
                    case "-":
                        last = (int)Convert.ToInt32(stack.Pop());
                        prelast = (int)Convert.ToInt32(stack.Pop());
                        result = prelast - last;
                        stack.Push(result.ToString());
                        break;
                    case "*":
                        last = (int)Convert.ToInt32(stack.Pop());
                        prelast = (int)Convert.ToInt32(stack.Pop());
                        result = prelast * last;
                        stack.Push(result.ToString());
                        break;
                    default: break;
                }
            }

        }

        Console.WriteLine($"Ответ:{result}");

        #endregion
    }


}

