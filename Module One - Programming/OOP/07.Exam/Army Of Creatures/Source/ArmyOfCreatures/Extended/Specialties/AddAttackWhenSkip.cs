namespace ArmyOfCreatures.Extended.Specialties
{
    using System;
    using System.Globalization;

    using ArmyOfCreatures.Logic.Specialties;
    using ArmyOfCreatures.Logic.Battles;

    public class AddAttackWhenSkip : Specialty
    {
        private int attackPointsToAdd;
        public AddAttackWhenSkip(int attackPointsToAdd)
        {
            this.AttackPointsToAdd = attackPointsToAdd;
        }
        private int AttackPointsToAdd
        {
            get { return this.attackPointsToAdd; }
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("attackPointsToAdd", "attackPointsToAdd should be between 1 and 20, inclusive");
                }
                this.attackPointsToAdd = value;
            }
        }
        public override void ApplyOnSkip(ICreaturesInBattle skipCreature)
        {
            if (skipCreature == null)
            {
                throw new ArgumentNullException("skipCreature");
            }

            skipCreature.PermanentAttack += this.AttackPointsToAdd;
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(), this.attackPointsToAdd);
        }
    }
}
