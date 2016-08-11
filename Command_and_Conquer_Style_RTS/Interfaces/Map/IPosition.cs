using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Command_and_Conquer_Style_RTS.Interfaces.Map
{
    public interface IPosition
    {
        int GetX();
        void SetX(int x);

        int GetY();
        void SetY(int y);

        int XPosition { get; set; }
        int YPosition { get; set; }
    }
}
