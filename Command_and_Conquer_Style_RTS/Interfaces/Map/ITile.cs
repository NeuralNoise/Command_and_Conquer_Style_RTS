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

        bool AddItem();
        bool CanAddItem(IUnit unit);

        bool BlocksDirectFire();
        bool IsPassable();

        void RenderTile();

        ITerrainTile GetTerrain();
        void SetTerrain();

        List<IUnit> GetUnitList();
        void SetUnitList(IEnumerable<IUnit> unitList);

    }
}
