// int(func*)(int, int); C++

Funcs<int> f;
f = Sum;
Console.WriteLine($"Sum: {f(10, 20)}");

f = new Funcs<int>(Mult);
Console.WriteLine($"Mult: {f(10, 20)}");


Console.WriteLine($"Calc Sum: {Calc(40, 50, Sum)}");
Console.WriteLine($"Calc Mult: {Calc(40, 50, Mult)}");

var oper = OperationFactory('*');
Console.WriteLine($"Oper: {oper(100, 200)}");


SendMessage handlerMessages;

handlerMessages = HelloMessage;
handlerMessages += ByMessage;

handlerMessages("Bobby");

//handlerMessages -= HelloMessage;
//handlerMessages("Jimmy");

SendMessage handlerMessages2 = HiMessage;
handlerMessages2 += WowMessage;
handlerMessages2 += HiMessage;

handlerMessages2("Jimmy");

SendMessage handlerMessagesAll = handlerMessages + handlerMessages2;
handlerMessagesAll("Leopold");


SendMessage? mes1 = HelloMessage;
mes1.Invoke("Sam");
mes1 -= HelloMessage;
mes1?.Invoke("Sam");


int Sum(int a, int b)
{
    return a + b;
}

int Mult(int a, int b)
{
    return a * b;
}

int Calc(int a, int b, Operation op)
{
    return op(a, b);
}

Operation OperationFactory(char code)
{
    switch(code)
    {
        case '+': return Sum; break;
        case '*': return Mult; break;
        default: return null;
    }
}


void HelloMessage(string message)
{
    Console.WriteLine($"Hello! {message}");
}

void ByMessage(string message)
{
    Console.WriteLine($"Good by! {message}");
}

void HiMessage(string message)
{
    Console.WriteLine($"Hi! {message}");
}

void WowMessage(string message)
{
    Console.WriteLine($"Wow! {message}");
}

delegate T Funcs<T>(T a, T b); // C#
delegate int Operation(int a, int b);

delegate void SendMessage(string message);