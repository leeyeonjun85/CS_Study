//기타
////주석 추가           Ctrl+KC
////주석 제거           Ctrl+KU
////솔루션 창 열기      Ctrl+Alt+L
////Tool Window 전환    Shift+Alt+F6
////책갈피              Ctrl+KK




//Hello World - C# 소개 대화형 C# 자습서
//https://learn.microsoft.com/ko-kr/dotnet/csharp/tour-of-csharp/tutorials/hello-world
Console.WriteLine("■■■■  첫 번째 C# 프로그램 실행  ■■■■");
Console.WriteLine("Hello World!");


Console.WriteLine("■■■■  변수 선언 및 사용  ■■■■");
string aFriend = "Bill";
Console.WriteLine(aFriend);

aFriend = "Maira";
Console.WriteLine(aFriend);

Console.WriteLine("Hello " + aFriend);

////문자열 보간 사용
Console.WriteLine($"Hello {aFriend}");


Console.WriteLine("■■■■  문자열 작업  ■■■■");

string firstFriend = "Maria";
string secondFriend = "Sage";
Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");     // .Length 는 문자열의 길이를 정수로 반환
Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


Console.WriteLine("■■■■  더 많은 문자열 작업  ■■■■");

//Trim
string greeting = "      Hello World!       ";      // C#의 문자열은 공백을 모두 표현한다
Console.WriteLine($"[{greeting}]");

string trimmedGreeting = greeting.TrimStart();      // 왼쪽 공백 제거
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.TrimEnd();               // 오른쪽 공백 제거
Console.WriteLine($"[{trimmedGreeting}]");

trimmedGreeting = greeting.Trim();                  // 양쪽 공백 제거
Console.WriteLine($"[{trimmedGreeting}]");

//Replace
string sayHello = "Hello World!";
Console.WriteLine(sayHello);
sayHello = sayHello.Replace("Hello", "Greetings");  // Hello를 Greeings로 변경
Console.WriteLine(sayHello);

Console.WriteLine(sayHello.ToUpper());              // 문자열을 대문자로 변경
Console.WriteLine(sayHello.ToLower());              // 문자열을 소문자로 변경


Console.WriteLine("■■■■  검색 문자열  ■■■■");

string songLyrics = "You say goodbye, and I say hello";
Console.WriteLine(songLyrics.Contains("goodbye"));          // 있으니깐 True
Console.WriteLine(songLyrics.Contains("greetings"));        // 없으니깐 False

Console.WriteLine(songLyrics.StartsWith("You"));            // You로 시작하니깐 True
Console.WriteLine(songLyrics.EndsWith("hello"));            // hello로 끝나니깐 True





//C#에서 정수 및 부동 소수점 수 조작
//https://learn.microsoft.com/ko-kr/dotnet/csharp/tour-of-csharp/tutorials/numbers-in-csharp

Console.WriteLine("■■■■  정수 계산 살펴보기  ■■■■");

int a = 18;
int b = 6;

int c = a + b;
Console.WriteLine(c);   // 24
c = a - b;
Console.WriteLine(c);   // 12
c = a * b;
Console.WriteLine(c);   // 108
c = a / b;
Console.WriteLine(c);   // 3


Console.WriteLine("■■■■  연산 순서 알아보기  ■■■■");

int a = 5;
int b = 4;
int c = 2;
int d = a + b * c;
Console.WriteLine(d);










