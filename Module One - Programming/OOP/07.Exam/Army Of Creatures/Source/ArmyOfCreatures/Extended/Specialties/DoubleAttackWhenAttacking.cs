namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;

    class DoubleAttackWhenAttacking : Specialty
    {
        private int rounds;
        public DoubleAttackWhenAttacking(int rounds)
        {
            this.Rounds = rounds;
        }
        public int Rounds
        {
            get { return this.rounds;}
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rounds should be between 0 and 10!");
                }
                this.rounds = value;
            }
        }
        public override void ApplyWhenAttacking(ICreaturesInBattle attackerWithSpecialty, ICreaturesInBattle defender)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("defenderWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("attacker");
            }

            if (this.rounds <= 0)
            {
                // Effect expires after fixed number of rounds
                return;
            }
            attackerWithSpecialty.CurrentAttack *= 2;
            this.rounds--;
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.rounds);
        }
    }
}
