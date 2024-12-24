Console.WriteLine("digite uma senha");

var password = Console.ReadLine();

var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

Console.WriteLine("digite sua senha novamente");

password = Console.ReadLine();

var isVerify = BCrypt.Net.BCrypt.Verify(password, hashedPassword);

Console.WriteLine(isVerify);