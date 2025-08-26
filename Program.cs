const int WATTS_PAR_HEURE = 150;
const double COUTS_POUR_100WATTS_PAR_HEURE = 0.15;
const int WATTS_100 = 100;

double Watts;
double Heure;

Console.WriteLine("inscrivez le nombre heure.");
Console.ReadLine;
Console.clear();

couts = nombreHeure * WATTS_PAR_HEURE / WATTS_100 * COUTS_POUR_100WATTS_PAR_HEURE;

Console.WriteLine("Cout pour le nombre d'heure donner:" + couts);