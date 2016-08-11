using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.Properties;

namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.ActionsRecieved
{
    public interface IBuffableByStrength : IHasStrength, IBuffable
    {
        void BuffStrength(int byNum);
        void BuffStrength(double asMultipleOfCurrentValue);
    }
}