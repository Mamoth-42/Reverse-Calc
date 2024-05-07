string[] inputVal = { "66", "3", "/", "5", "+" };
var cisla = new Stack<int>();
int numero = 0;
int output = Convert.ToInt16(inputVal[0]);
for (int i = 0; i < inputVal.Length; i++)
{
    if (int.TryParse(inputVal[i], out numero))
    {
        cisla.Push(numero);
//        Console.WriteLine(cisla.Peek());
    }
    else
    {
        switch (Convert.ToChar(inputVal[i]))
        {
            case '+':
                output += cisla.Pop();
                break;

            case '-':
                output -= cisla.Pop();
                break;

            case '*':
                output = output * cisla.Pop();
                break;

            case '/':
                output = output / cisla.Pop();
                break;
        }
    }
}
Console.WriteLine(output);
