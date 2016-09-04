using Command_and_Conquer_Style_RTS.Enums.Terrain;

namespace Command_and_Conquer_Style_RTS.Interfaces.Map
{
    public interface ITerrainTile
    {
        TerrainType TerrainType { get; set; }
        void SetTerrainType(int typeId);

        double DefBonus { get; set; }
        double AtkBonus { get; set; }
        int MovementCost { get; set; }

        bool IsPassable { get; set; }
        bool BlocksDirectFire { get; set; }
    }
}