using NexumInterview.Models;

namespace NexumInterview.Interfaces
{
    public interface IMoveable
    {
        void Move(char[] moveLetters, Plane plane);

        void MoveProcess();

        void TurnLeft();

        void TurnRight();
    }
}
