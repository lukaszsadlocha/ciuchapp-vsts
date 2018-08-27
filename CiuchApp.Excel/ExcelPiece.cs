using CiuchApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CiuchApp.Excel
{
    class ExcelPiece : Piece
    {
        public string ProducerSymbol => Name;
        public double Margin => SellPrice / BuyPrice;
    }
}
