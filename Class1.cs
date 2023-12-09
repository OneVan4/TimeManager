public class Timer
{
    int seconds, minutes, hours, Gotmin;
    public Timer() { seconds = 0; minutes = 0; hours = 0; Gotmin = 0; }
    public void Add()
    {
        if (minutes == 59 && seconds == 59) { hours++; minutes = 0; }
        if (seconds == 59) { minutes++; seconds = 0; Gotmin++; }
        seconds++;
    }
    public string GetTime()
    {
        string str = "00:00:00"; string h, m, s;
        if (hours < 10) h = "0" + hours.ToString();
        else h = hours.ToString();
        if (minutes < 10) m = "0" + minutes.ToString();
        else m = minutes.ToString();
        if (seconds < 10) s = "0" + seconds.ToString();
        else s = seconds.ToString();
        str = h + ":" + m + ":" + s;
        return str;
    }
    public int Get() { return Gotmin; }
    public void reset() { seconds = 0; minutes = 0; hours = 0; Gotmin = 0; }
};
