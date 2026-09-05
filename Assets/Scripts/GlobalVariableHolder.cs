public static class GlobalVariableHolder
{
    private static int Score = 0;

    public static void SetScore(int num) 
    {
        Score = num;
    }

    public static int GetScore() 
    {
        return Score;
    }
}
