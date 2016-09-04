using Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_and_Conquer_Style_RTS.Interfaces.Map
{
    public interface ITile
    {
        string GetTerrainDescription();
        IPosition Position { get; set; }
        bool AddItem();
        bool CanAddItem(IUnit unit);

        bool BlocksDirectFire();
        bool IsPassable();

        void RenderTile();

        ITerrainTile Terrain { get; set; }

        List<IUnit> GetUnitList();
        void SetUnitList(IEnumerable<IUnit> unitList);

    }
}
