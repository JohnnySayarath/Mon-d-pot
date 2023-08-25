using Demo08Enum;

// Un enum est une énumerations de possibilités pour une variable
// elle ne pourra être que l'une des valeurs définies dans l'enum

// exemple ConsolColor donne toutes les couleurs existantes pour une console
Console.ForegroundColor = ConsoleColor.White;

Genre genre = Genre.Masculin;

Console.WriteLine(genre);


genre = (Genre)1;

Console.WriteLine(genre);


switch (genre)
{
	case Genre.Feminin:
        Console.WriteLine("Vous êtes une Femme");
        break;
	case Genre.Masculin:
        Console.WriteLine("Vous êtes un Homme");
        break;
	case Genre.Autre:
        Console.WriteLine("Vous êtes Indéterminé");
        break;
	default:
		break;
}