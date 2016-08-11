using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_and_Conquer_Style_RTS.Interfaces.Map
{
    public interface IPositionable
    {
        IPosition GetPosition();
        IPosition SetPosition();

        IPosition Position {get;set; }

        ITile GetTileFromMap();
    }
}
