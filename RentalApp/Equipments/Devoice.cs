namespace RentalApp.Equipments
{
    public class Devoice: EquipmentBase
    {
        public double? Weight { get; set; }

        public override string ToString() => base.ToString() + $", Waga: {Weight:N1} kg";
    }
}
