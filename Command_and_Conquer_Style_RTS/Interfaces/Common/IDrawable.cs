using System.Windows.Controls;
using Command_and_Conquer_Style_RTS.Interfaces.Map;

namespace Command_and_Conquer_Style_RTS.Interfaces.Common
{
    public interface IDrawable : IPositionable
    {
        void Draw();
        Image GetImage();
        int GetImageHeight();
        int GetImageWidth();

        Image CurrentImage { get; set; }
    }
}