using Command_and_Conquer_Style_RTS.Enums.Terrain;

namespace Command_and_Conquer_Style_RTS.Interfaces.Map
{
    public interface ITerrainTile
    {
        TerrainType GetTerrainType();
        void SetTerrainType(int typeId);
        void SetTerrainType(TerrainType type);

        double GetDefBonus();
        double GetAtkBonus();

        int GetMovementCost();

        bool IsPassable { get; set; }
        bool BlocksDirectFire { get; set; }
        
    }
}