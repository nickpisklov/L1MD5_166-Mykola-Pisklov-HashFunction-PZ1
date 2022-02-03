using HashFunction;

string message = "Hello";
string hash = MySHA256.GetHashCodeForMessage(message);
Console.WriteLine("Hash data for message '{0}' is {1}", message, hash);
    
