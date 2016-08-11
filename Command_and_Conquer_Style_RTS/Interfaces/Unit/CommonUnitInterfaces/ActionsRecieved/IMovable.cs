using Command_and_Conquer_Style_RTS.Enums.Terrain;

namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.ActionsRecieved
{
    public interface IMovable : IUnit
    {
        // Default only pushes one tile
        void Push(Direction dir);
        void Push(Direction dir, int numberOfTiles);
    }
}