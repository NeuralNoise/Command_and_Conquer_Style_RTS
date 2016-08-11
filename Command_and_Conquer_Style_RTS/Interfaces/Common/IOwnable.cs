namespace Command_and_Conquer_Style_RTS.Interfaces.Common
{
    public interface IOwnable
    {
        int GetOwningPlayerId();
        void SetOwningPlayerId(int PlayerId);

        int OwningPlayerId { get; set; }

        bool IsCurrentTurn();
        bool IsCurrentPlayer();
    }
}