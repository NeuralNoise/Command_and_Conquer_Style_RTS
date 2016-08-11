namespace Command_and_Conquer_Style_RTS.Interfaces.Common
{
    public interface IVisible : IDrawable
    {
        bool Visible { get; set; }

        bool GetVisible();
        void SetVisible(bool visibleValue);
    }
}