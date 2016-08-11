namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.Properties
{
    public interface IHasHp:IUnit
    {
        int Hp { get; set; }
        int MaxHp { get; set; }
    }
}