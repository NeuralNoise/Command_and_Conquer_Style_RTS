using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.Properties;

namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.ActionsRecieved
{
    public interface IHealable : IHasHp
    {
        void Heal(int amountToHeal);
        void Heal(double fractionOfHp);
    }
}