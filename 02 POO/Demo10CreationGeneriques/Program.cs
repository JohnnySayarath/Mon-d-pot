using Demo10CreationGeneriques.Classes;
using Demo10CreationGeneriques.Classes.TourneVis;

//Demarreur<List<string>> t = new Demarreur<List<string>>();
//Demarreur<Queue<string>> t2 = new Demarreur<Queue<string>>();
//Demarreur<string[]> t3 = new Demarreur<string[]>();

//Demarreur<Ordinateur> demarreurDOrdinateur = new Demarreur<Ordinateur>();

//demarreurDOrdinateur.DemarreCetteChose(new Ordinateur());
////demarreurDOrdinateur.DemarreCetteChose(new Tronconeuse());


//Arreteur arreteur = new Arreteur();

//arreteur.ArreteCetteChose<Tronconeuse>(new Tronconeuse());
//arreteur.ArreteCetteChose(new Ordinateur());


//Scribe.EcritPlusieursFois("chaine",2);
//Scribe.EcritPlusieursFois(1,5);
//Scribe.EcritPlusieursFois(1.5,3);
//Scribe.EcritPlusieursFois(new Tronconeuse(),1);


Queue<Vis> visAVisser = new Queue<Vis>();

visAVisser.Enqueue(new VisCruciforme());
visAVisser.Enqueue(new VisCruciforme());
visAVisser.Enqueue(new VisPlate());
visAVisser.Enqueue(new VisPlate());
visAVisser.Enqueue(new VisCruciforme());
visAVisser.Enqueue(new VisPlate());

//CLASSE GENERIQUE

// toutes les vis
TourneVisPour<Vis> tourneVisAEmbouts = new TourneVisPour<Vis>();

// bloqué sur un type de vis
TourneVisPour<VisCruciforme> tourneVisCruciforme = new TourneVisPour<VisCruciforme>();
TourneVisPour<VisPlate> tourneVisPlat = new TourneVisPour<VisPlate>();

while (visAVisser.Count > 0)
{
    Vis laVis = visAVisser.Dequeue();

    tourneVisAEmbouts.Visser(laVis);

    if (laVis is VisCruciforme visCruciforme)
    {
        tourneVisCruciforme.Visser(visCruciforme);
    }
    else if (laVis is VisPlate visPlate)
    {
        tourneVisPlat.Visser(visPlate);
    }
}

Console.WriteLine("--------------");

visAVisser.Enqueue(new VisCruciforme());
visAVisser.Enqueue(new VisCruciforme());
visAVisser.Enqueue(new VisPlate());
visAVisser.Enqueue(new VisPlate());
visAVisser.Enqueue(new VisCruciforme());
visAVisser.Enqueue(new VisPlate());

// METHODE GENERIQUE

TourneVisAEmbouts tourneVisAEmbouts2 = new TourneVisAEmbouts();

while (visAVisser.Count > 0)
{
    Vis laVis = visAVisser.Dequeue();

    tourneVisAEmbouts2.Visser(laVis);
}