using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.Properties;

namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.ActionsRecieved
{
    public interface IDamageable : IHasHp
    {
        void Damage(int amountToDamage);
        void Damage(double fractionOfHp);
    }
}