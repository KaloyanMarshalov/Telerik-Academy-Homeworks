namespace ArmyOfCreatures.Extended.Specialties
{
    using System;

    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;
    using System.Globalization;

    public class DoubleDamage : Specialty
    {
        private int rounds;
        public DoubleDamage(int rounds)
        {
            this.Rounds = rounds;
        }
        public int Rounds
        {
            get { return this.rounds;}
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Rounds should be between 0 and 10!");
                }
                this.rounds = value;
            }
        }
        public override decimal ChangeDamageWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender, decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }
            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return currentDamage;
            }
            this.rounds--;
            return currentDamage *= 2;
        }
        public override string ToString()
        {
            return string.Format(
                CultureInfo.InvariantCulture,
                "{0}({1})",
                base.ToString(),
                this.rounds);
        }
    }
}
