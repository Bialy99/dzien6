using dzien6;

User user1 = new User("Adam", "ssss");
user1.AddScore(5);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);
