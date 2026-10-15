
int nOre,totN30=0, totN20=0, totN1000=0, n20=0, sommaFollower=0, nFollower, nDirette, totOre=0, totFollower=0, totDirette=0, n30=0, n1000=0, sommaOre=0, sommaDirette=0;
double percentualeN20, mediaSpettatori,totMediaSpettatori=0, mediaOre, mediaFollower;

for (int i = 0; i < 12; i++)
{
    Console.WriteLine("inserire il numero di ore trasemsse");
    nOre = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("inserire il numero medio di spettatori");
    mediaSpettatori = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("inserire il numero di nuovi follower");
    nFollower = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("inserire il numero di dirette effettuate");
    nDirette = Convert.ToInt32(Console.ReadLine());

    sommaOre = sommaOre + nOre;
    sommaFollower = sommaFollower + nFollower;
    sommaDirette = sommaDirette + nDirette;
    sommaFollower = sommaFollower / nFollower;
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
totFollower = totFollower + sommaFollower;
totDirette = totDirette + sommaDirette;
totN30 = totN30 + n30;
totN20 = totN20 + n20;
totN1000 = totN1000 + n1000;
mediaFollower = sommaFollower / totFollower * 100;
percentualeN20 = totN20 / totOre * 100;
mediaOre = totOre / 12 * 100;
Console.WriteLine("Il totale delle ore è" + totOre);
Console.WriteLine("Il totale dei nuovi follower è" + totFollower);
Console.WriteLine("Il totale delle dirette è" + totDirette);
Console.WriteLine("Il numero di creator che hanno trasmesso almeno 30 ore è" + totN30);
Console.WriteLine("Il numero di creator che hanno ottenuto almeno 1000 nuovi follower è" + totN1000);
Console.WriteLine("La media dei nuovi follower è" + mediaFollower);
Console.WriteLine("La percentuale deri creator che hanno trasmesso almeno 20 ore è" + percentualeN20 + percentualeN20);
Console.WriteLine("La media delle ore trasmesse per creator è" + mediaOre);

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