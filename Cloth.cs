using System;
using System.Collections.Generic;

namespace ClothStock_ClassLibrary
{
    public class Cloth
    {
        public string ClothName
        { get; set; }
        public ProducingFactory Factory { get; set; }
        public Types ClothType { get; set; }
        public double? CostPerMetre { get; set; }

        public DateTime CheckDate { get; set; }
        public double? MetresInStock { get; set; }
        public Markup? Markup { get; set; }

        public Cloth()
        {
            ClothName = "Неведомая ткань";
            Factory = ProducingFactory.Прочие;
            ClothType = Types.Прочие;
            CostPerMetre = null;
            CheckDate = DateTime.Now;
            MetresInStock = null;
            Markup = null;
        }
        public Cloth(string clothName, 
                     ProducingFactory factory, Types clothType, double cost,
                     DateTime date, double metres, Markup markup)
        {
            ClothName = clothName;
            Factory = factory;
            ClothType = clothType;
            CostPerMetre = cost;
            CheckDate = date;
            MetresInStock = metres;
            Markup = markup;
        }

        public override string ToString()
        {
            return $"Ткань {ClothName}, изготовленная на фабрике {Factory} (тип {ClothType}): " +
                $"цена за один метр {CostPerMetre}, " +
                $"дата инвентаризации {CheckDate.ToString("dd.MM.yyyy")}, " +
                $"количество на складе {MetresInStock}" +
                $", наценка {Markup}(%)";
        }
    }
}
