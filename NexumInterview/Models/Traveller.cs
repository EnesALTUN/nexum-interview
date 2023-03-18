using NexumInterview.Enums;
using NexumInterview.Exceptions;
using NexumInterview.Interfaces;
using NexumInterview.Utils;

namespace NexumInterview.Models
{
    public class Traveller : IMoveable
    {
        public int XPoint { get; private set; }

        public int YPoint { get; private set; }

        public char Direction { get; private set; }


        public Traveller(string fullData, Plane plane)
        {
            string[] splitedTravellerDimensionAndDirection = fullData.Trim().Split(" ");

            (XPoint, YPoint, Direction) = CheckValues(splitedTravellerDimensionAndDirection);
            plane.Travellers.Add(this);
        }

        public void GetCurrentInfo()
        {
            Console.WriteLine($"{XPoint} {YPoint} {Direction}");
        }

        public void Move(char[] moveLetters, Plane plane)
        {
            foreach (var moveLetter in moveLetters)
            {
                switch (moveLetter)
                {
                    case (char)MoveLetterEnum.Move:
                        MoveProcess();
                        break;
                    case (char)MoveLetterEnum.Left:
                        TurnLeft();
                        break;
                    case (char)MoveLetterEnum.Right:
                        TurnRight();
                        break;
                }
            }

            CheckPointLimit(plane);
        }

        public void MoveProcess()
        {
            switch (Direction)
            {
                case (char)DirectionEnum.North:
                    ++YPoint;
                    break;
                case (char)DirectionEnum.West:
                    --XPoint;
                    break;
                case (char)DirectionEnum.South:
                    --YPoint;
                    break;
                case (char)DirectionEnum.East:
                    ++XPoint;
                    break;
            }
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case (char)DirectionEnum.North:
                    Direction = (char)DirectionEnum.West;
                    break;
                case (char)DirectionEnum.West:
                    Direction = (char)DirectionEnum.South;
                    break;
                case (char)DirectionEnum.South:
                    Direction = (char)DirectionEnum.East;
                    break;
                case (char)DirectionEnum.East:
                    Direction = (char)DirectionEnum.North;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case (char)DirectionEnum.North:
                    Direction = (char)DirectionEnum.East;
                    break;
                case (char)DirectionEnum.East:
                    Direction = (char)DirectionEnum.South;
                    break;
                case (char)DirectionEnum.South:
                    Direction = (char)DirectionEnum.West;
                    break;
                case (char)DirectionEnum.West:
                    Direction = (char)DirectionEnum.North;
                    break;
            }
        }

        private static (int, int, char) CheckValues(string[] values)
        {
            if (values?.Length != 3 ||
                !int.TryParse(values[0], out int travellerXDimension) || travellerXDimension < 0 ||
                !int.TryParse(values[1], out int travellerYDimension) || travellerYDimension < 0 ||
                !char.TryParse(values[2], out char travellerDirection) ||
                !DirectionUtils.CheckDirectionValue(travellerDirection)
            )
                throw new BusinessException("Gezgin için girilen değerler geçersizdir");

            return (travellerXDimension, travellerYDimension, travellerDirection);
        }

        private void CheckPointLimit(Plane plane)
        {
            if (XPoint > plane.XDimension)
                XPoint = plane.XDimension;

            if (XPoint < 0)
                XPoint = 0;

            if (YPoint > plane.YDimension)
                YPoint = plane.YDimension;

            if (YPoint < 0)
                YPoint = 0;
        }
    }
}
