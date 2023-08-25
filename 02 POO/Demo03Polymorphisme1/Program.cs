using Demo03Polymorphisme1;

Enclos enclos1 = new Enclos("Le pré des vélociraptors", 500, 5);

Dinosaur denver = new Dinosaur("Denver", 10, "Corythosaurus", false);

// forme avec le dino par défaut
enclos1.AjouterDino();

Console.WriteLine(enclos1);

// forme "classique"
enclos1.AjouterDino(denver);
enclos1.AjouterDino(new Dinosaur());
enclos1.AjouterDino(new Dinosaur("Denver2", 10, "Corythosaurus", false));

Console.WriteLine(enclos1);

// forme sans instance de dinosaure 
enclos1.AjouterDino("Petit-Pied", 12, "Apatosaurus", true);
enclos1.AjouterDino("Petit-Pied2", 12, "Apatosaurus", true); // pas d'ajout car l'enclos est plein => la fonction retourne false

Console.WriteLine(enclos1);

string rexEstAjoute = enclos1.AjouterDino("Rex", 35, "Tyrannosaurus", false) ? "Rex est ajouté" : "Rex n'est pas ajouté car l'enclos est plein";
Console.WriteLine(rexEstAjoute);

Console.WriteLine(enclos1.ToString());


// utilisation du constructeur de recopie
Dinosaur cloneDeDenver = new Dinosaur(denver);
cloneDeDenver.Nom = "cloneDeDenver";

Console.WriteLine(denver);
Console.WriteLine(cloneDeDenver);