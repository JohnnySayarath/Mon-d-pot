using Demo05Heritage;

Animal animal = new Animal("nom animal", true);

Console.WriteLine(animal.Nom);
animal.SeDeplacer();
animal.Respirer();
animal.Crier();

Mammifere mammifere = new Mammifere("nom mamifere", true, "Féminin");
//Mammifere mammifere2 = new Mammifere();

Console.WriteLine(mammifere.Nom);
mammifere.SeDeplacer();
mammifere.Respirer();
mammifere.Crier();

Chien chien = new("Pepette", true, "femelle", "Rottweiler");
Console.WriteLine(chien.Nom);
chien.SeDeplacer();
chien.Respirer();
chien.Crier();

Chat chat = new("Mistigri", true, "femelle", false);
Console.WriteLine(chat.Nom);
chat.SeDeplacer();
chat.Respirer();
chat.Crier();