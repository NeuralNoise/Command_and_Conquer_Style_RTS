using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces;
using System.Collections.Generic;

namespace Command_and_Conquer_Style_RTS.Interfaces.Map
{
    public interface ITile
    {
        string GetTerrainDescription();
        IPosition Position { get; set; }
        bool AddItem(IUnit unit);
        bool CanAddItem(IUnit unit);

        bool BlocksDirectFire();
        bool IsPassable();

        void RenderTile();

        ITerrainTile Terrain { get; set; }

        List<IUnit> UnitList { get; set; }
    }
}
