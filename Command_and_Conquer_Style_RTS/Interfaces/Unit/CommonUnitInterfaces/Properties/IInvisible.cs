namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.Properties
{
    public interface IInvisible:IUnit
    {
        int GetRevealDistance();
        int RevealDistance { get; set; }
        bool IsRevealed { get; set; }
    }
}