
int nOre, n20=0, sommaFollower=0, nFollower, nDirette, totOre=0, totFollower=0, totDirette=0, n30=0, n1000=0, sommaOre=0;
double mediaSpettatori,totMediaSpettatori=0, mediaOre, mediaFollower;
string nome;

for (int i = 0; i < 12; i++)
{
    Console.WriteLine("inserire il nome");
    nome = Console.ReadLine();
    Console.WriteLine("inserire il numero di ore trasemsse");
    nOre = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("inserire il numero medio di spettatori");
    mediaSpettatori = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("inserire il numero di nuovi follower");
    nFollower = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("inserire il numero di dirette effettuate");
    nDirette = Convert.ToInt32(Console.ReadLine());

    sommaOre = sommaOre + nOre;
    totFollower = totFollower + nOre;
    totDirette = totDirette + nOre;
    mediaOre = sommaOre / nDirette * 100;
    mediaFollower = sommaFollower / nOre;
    totMediaSpettatori = totMediaSpettatori + mediaSpettatori;

    if (nOre >= 30)
    {
        n30 = n30 + 1;
    }
    if (nFollower >= 1000)
    {
        n1000 = n1000 + 1;
    }
    if (nOre >= 20)
    {
        n20 = n20 + 1;
    }

    if (nFollower >= 2000)
    {
        Console.WriteLine("Creator top");
    }
    else if (nFollower >= 1000)
    {
        Console.WriteLine("Creator molto seguito");
    }
    else if (nFollower >= 500)
    {
        Console.WriteLine("Creator emergente");
    }
    else
    {
        Console.WriteLine("Creator in crescita");
    }
}
totOre = totOre + sommaOre;
if (totMediaSpettatori > 1500)
{
    Console.WriteLine("Periodo eccezionale");
}
else if (totMediaSpettatori >= 1000)
{
    Console.WriteLine("Periodo molto positivo");
}
else if (totMediaSpettatori >= 500)
{
    Console.WriteLine("Periodo positivo");
}
else
{
    Console.WriteLine("Necessario aumentare il pubblico");
}