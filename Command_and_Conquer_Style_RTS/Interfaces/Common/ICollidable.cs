using Command_and_Conquer_Style_RTS.Interfaces.Map;

namespace Command_and_Conquer_Style_RTS.Interfaces.Common
{
    public interface ICollidable : IPositionable
    {
        bool IsCollidable { get; set; }
    }
}