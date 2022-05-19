using System;


namespace ClothStock_ClassLibrary
{
    public class Cloth
    {
        public string ClothName
        { get; set; }
        public ProducingFactory Factory { get; set; }
        public Types ClothType { get; set; }
        public double? CostPerPiece { get; set; }

        public DateTime? CheckDate { get; set; }
        public double? MetresInStock { get; set; }
        public double? Markup { get; set; }

        public Cloth()
        {
            ClothName = "Неведомая ткань";
            Factory = ProducingFactory.Прочие;
            ClothType = Types.Прочие;
            CostPerPiece = null;
            CheckDate = null;
            MetresInStock = null;
            Markup = null;
        }
        public Cloth(string clothName, ProducingFactory factory, Types clothType, double cost,
                     DateTime date, double metres, double markup)
        {
            ClothName = clothName;
            Factory = factory;
            ClothType = clothType;
            CostPerPiece = cost;
            CheckDate = date;
            MetresInStock = metres;
            Markup = markup;
        }
    }
}
