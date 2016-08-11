using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.Properties;

namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.ActionsRecieved
{
    public interface IBuffableByHp : IHasHp,IBuffable
    {
        void BuffMaxHp(int byNum);
        void BuffMaxHp(double asMultipleOfCurrentValue);
    }
}