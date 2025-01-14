namespace CodeAlong_01;

public class CurrentTime
{
    public static bool Time()
    {
        var startTime = DateTime.Today.AddHours(7);  // 7:00 AM today
        var endTime = DateTime.Today.AddHours(20);   // 8:00 PM today
        var now = DateTime.Now;

        if (now >= startTime && now <= endTime)
        {
            return true;
        }
        else
        {
            Console.WriteLine($"Current time is {now.ToShortTimeString()}. You cannot buy beer at this time.");
            return false;
        }
    }
}