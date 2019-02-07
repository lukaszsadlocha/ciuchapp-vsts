using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CiuchApp.Domain
{
    public class SizeAmountPair : CiuchAppBaseModel
    {
        public int PieceId { get; set; }
        [JsonIgnore]
        public Piece Piece { get; set; }
        public int SizeId { get; set; }
        [DisplayName("Rozmiar")]
        public virtual Size Size { get; set; }
        [DisplayName("Ilość")]
        public int Amount { get; set; }
    }
}
