using Demo06HeritageOverrideAbstract;


// Animal étant maintenant une classe abstraite ON NE PEUT PLUS L'INSTANCIER
//Animal animal = new Animal("nom animal", true);
//Console.WriteLine(animal.Nom);
//animal.SeDeplacer();
//animal.Respirer();
//animal.Crier();

// Mammifere étant maintenant une classe abstraite ON NE PEUT PLUS L'INSTANCIER
//Mammifere mammifere = new Mammifere("nom mamifere", true, "Féminin");
//Console.WriteLine(mammifere.Nom);
//mammifere.SeDeplacer();
//mammifere.Respirer();
//mammifere.Crier();

Chien chien = new("Pepette", true, "femelle", "Rottweiler");
Console.WriteLine(chien.Nom);
chien.SeDeplacer();
chien.Respirer();
chien.Crier();
chien.Allaiter();

Chat chat = new("Mistigri", true, "femelle", false);
Console.WriteLine(chat.Nom);
chat.SeDeplacer();
chat.Respirer();
chat.Crier();
chat.Crier("le cri du chat");
chat.Allaiter();