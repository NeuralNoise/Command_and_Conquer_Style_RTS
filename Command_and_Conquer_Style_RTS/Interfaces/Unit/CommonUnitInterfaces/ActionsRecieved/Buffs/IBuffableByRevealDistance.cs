using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.Properties;

namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.ActionsRecieved
{
    public interface IBuffableByRevealDistance : IInvisible, IBuffable
    {
        // Default removes exactly 1 tile reveal distance
        void BuffRevealDistance();
        void BuffRevealDistance(int amountToRemove);
        void BuffRevealDistance(double multiplier);
    }
}