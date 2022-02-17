// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = true;
bool y = true;

bool logicValue = !(x || y) == !x && !y;
System.Console.WriteLine(logicValue);
