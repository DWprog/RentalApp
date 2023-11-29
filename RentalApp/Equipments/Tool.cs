namespace RentalApp.Equipments
{
    public class Tool : EquipmentBase
    {
        public double? Price { get; set; }

        public override string ToString() => base.ToString() + $", Price: {Price}";
    }
}
