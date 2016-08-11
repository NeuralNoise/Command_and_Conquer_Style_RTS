namespace Command_and_Conquer_Style_RTS.Interfaces.Unit.CommonUnitInterfaces.Properties
{
    public interface IHasScalableStrength : IHasStrength, IHasHp
    {
        double StrengthFalloffFromHp { get; set; }

        // Default uses current HP
        int CalculateStrengthAtHp();
        int CalculateStrengthAtHp(int hpForCalc);
    }
}