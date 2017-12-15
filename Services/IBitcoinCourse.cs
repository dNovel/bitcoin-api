namespace BitcoinInfo.API
{
    using System.Threading.Tasks;

    public interface IBitcoinCourse
    {
        Task<string> GetCurrentBtcCourse();

        Task<string> GetBtcCourseAtTime(int time);
    }
}