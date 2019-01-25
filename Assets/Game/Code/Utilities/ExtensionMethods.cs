using Code.Enums;

namespace Code.Utilities
{
    public static class ExtensionMethods
    {
        public static bool Is(this GameState gameState, GameState checkState)
        {
            return gameState == checkState;
        }
    }
}