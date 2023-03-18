using NexumInterview.Exceptions;

namespace NexumInterview.Models
{
    public class Plane
    {
        public int XDimension { get; private set; }

        public int YDimension { get; private set; }

        public List<Traveller> Travellers { get; set; } = new();

        public Plane(string dimensions)
        {
            string[] splitedPlaneDimension = dimensions.Trim().Split(" ");

            (XDimension, YDimension) = CheckDimensions(splitedPlaneDimension);
        }

        private static (int, int) CheckDimensions(string[] dimensions)
        {
            if (dimensions?.Length != 2 ||
                !int.TryParse(dimensions[0], out int planeXDimension) || planeXDimension < 0 ||
                !int.TryParse(dimensions[1], out int planeYDimension) || planeYDimension < 0
            )
                throw new BusinessException("Girilen düzlem boyutları geçerli değildir");

            return (planeXDimension, planeYDimension);
        }
    }
}
