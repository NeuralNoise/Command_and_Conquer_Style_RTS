using Command_and_Conquer_Style_RTS.Interfaces.Map;

namespace Command_and_Conquer_Style_RTS.Interfaces.Common
{
    public interface IDescribable : IPositionable
    {
        string GetDescription();
        void SetDescription();

        string Description { get; set; }
    }
}