namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.ActionsRecieved
{
    public interface IBuffable:IRecievesAction
    {
        bool RecievesBuffs { get; set; }
    }
}