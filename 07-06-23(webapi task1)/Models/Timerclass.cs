namespace _07_06_23_webapi_task1_.Models
{
    public class Timer :ITimer1
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
