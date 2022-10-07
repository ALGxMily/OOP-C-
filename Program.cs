//This changes the position of the parameter to -10 to the left side of the console
Console.WriteLine("Left justified width 10: {0,-10}", 99);
//This changes the position of the parameter to 10 to the right side of the console
Console.WriteLine("Right justified width 10:{0,10}", 99);

///////

Console.WriteLine("\n\nFormatting\n==========");
//This prints a currency symbol at position 0 which is at the beginning of the number and rounds it to the second decimal
Console.WriteLine("Currency formatting -{0:C}", 22.2);
/////////////IDK
Console.WriteLine("Integer formatting -{0:D5}", 22);
//Formats the number to an exponential form
Console.WriteLine("Exponential formatting -{0:E}", 222.2);
//Formats the number to the third decimal F3
Console.WriteLine("Fixed-point formatting -{0:F3}", 222.2222);
/////////////IDK
Console.WriteLine("General formatting -{0:G}", 222.2222);
//Formats the number by adding commas in thousands and rounds up to 3 decimal numbers
Console.WriteLine("Number formatting -{0:N}", 2222222.2);
//Transforms integers to hexadecimals numbers
Console.WriteLine("Hexadecimal formatting -{0:X4}", 22);