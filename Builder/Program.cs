// See https://aka.ms/new-console-template for more information

using Builder.Classes;

var pb = new PersonBuilder();

Person person = pb.Lives
    .In("London")
    .At("Some Street")
    .WithPostalCode("0123")
    .Works
    .At("Google")
    .AsA("Software Engineer")
    .Earning(10_000);