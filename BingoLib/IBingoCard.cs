using System;
namespace BingoLib
{
    interface IBingoCard
    {
        bool Contains(int ballNum);
        void Daub(int x, int y);
        CardPattern GetGrid();
        CardPattern GetMask();
        long SessionID { get; }
    }
}
