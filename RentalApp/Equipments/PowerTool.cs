namespace RentalApp.Equipments
{
    public class PowerTool : Tool
    {
        public int? Power { get; set; }

        public override string ToString() => base.ToString() + $", Moc: {Power} W";
    }
}
