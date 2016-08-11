using Command_and_Conquer_Style_RTS.Interfaces.Common;

namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces
{
    public interface IUnit : IOwnable, IDescribable, ICollidable, IVisible
    {
        bool IsCombatUnit { get; set; }
        void DestroyUnit();
    }
}