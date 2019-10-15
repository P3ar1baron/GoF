using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxFight = new BoxFight();
            var riskyPlayer = new RiskyPlayer();
            var conservativePlayer = new ConservativePlayer();

            boxFight.AttachObserver(riskyPlayer);
            boxFight.AttachObserver(conservativePlayer);

            boxFight.NextRound();
            boxFight.NextRound();
            boxFight.NextRound();
            boxFight.NextRound();
        }
    }
}
