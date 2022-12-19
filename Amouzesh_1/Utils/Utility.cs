namespace NDRUtility
{
    public class Utility
    {
        public static bool IsCollided(float Ax, float Ay, float Bx, float By)
        {
            return Ax == Ay && Bx == By;
        }
    }
}