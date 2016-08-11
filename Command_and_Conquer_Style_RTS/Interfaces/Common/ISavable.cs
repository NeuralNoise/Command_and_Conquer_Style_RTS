using System.IO;
using Command_and_Conquer_Style_RTS.Interfaces.Map;

namespace Command_and_Conquer_Style_RTS.Interfaces.Common
{
    public interface ISavable : IPositionable
    {
        string GetSerialisedString();
        void WriteToOutputStream(Stream s);
    }
}