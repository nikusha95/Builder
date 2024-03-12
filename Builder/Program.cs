// See https://aka.ms/new-console-template for more information

using Builder.Email;
using Builder.Person;

var pb = new PersonBuilder();

Person person = pb.Lives
    .In("London")
    .At("Some Street")
    .WithPostalCode("0123")
    .Works
    .At("Google")
    .AsA("Software Engineer")
    .Earning(10_000);

Console.WriteLine(person);
//use of email

var ms = new MailService();
ms.SendEmail(x=>x
    .To("user1@gmail.com")
    .From("user2@gmail.com")
    .WithBody("Hello")
    .WithSubject("Sample"));

Console.WriteLine(ms);