
namespace Ferrari
{
    public interface IFerarri
    {
        string Model { get; }

        string Driver { get; }

        string UseBrakes();

        string GazPedal();
    }
}
