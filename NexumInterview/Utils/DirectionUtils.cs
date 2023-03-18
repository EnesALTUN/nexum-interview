using NexumInterview.Enums;

namespace NexumInterview.Utils
{
    public static class DirectionUtils
    {
        public static bool CheckDirectionValue(char direction) => direction != (char)DirectionEnum.North || direction != (char)DirectionEnum.West || direction != (char)DirectionEnum.South || direction != (char)DirectionEnum.East;

        public static bool CheckMoveLetters(char[] moveLetters) => moveLetters.All(moveLetter => moveLetter == (char)MoveLetterEnum.Left || moveLetter == (char)MoveLetterEnum.Right || moveLetter == (char)MoveLetterEnum.Move);
    }
}
