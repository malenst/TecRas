// See https://aka.ms/new-console-template for more information

    string str = "";
    int a = 0;
    int b = 0;
    int res = 0;
    str = Console.ReadLine();
    if (str.Contains("+"))
    {
        a = Convert.ToInt32(str.Split("+")[0]);
        b = Convert.ToInt32(str.Split("+")[1]);
        res = a + b;
    }
    else if (str.Contains("-"))
    {
        a = Convert.ToInt32(str.Split("-")[0]);
        b = Convert.ToInt32(str.Split("-")[1]);
        res = a - b;
    }
    else if (str.Contains("*"))
    {
        a = Convert.ToInt32(str.Split("*")[0]);
        b = Convert.ToInt32(str.Split("*")[1]);
        res = a * b;
    }
    else if (str.Contains("/"))
    {
        a = Convert.ToInt32(str.Split("/")[0]);
        b = Convert.ToInt32(str.Split("/")[1]);
        res = a / b;
    }    
    Console.WriteLine(res);