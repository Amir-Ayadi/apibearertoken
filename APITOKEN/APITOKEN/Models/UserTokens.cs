namespace APITOKEN.Models
{
    public class UserTokens
    {
        public string Token
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        /*
         * 
            TimeSpan(Int32, Int32, Int32)  
            public TimeSpan(int hours,int minutes,int seconds)

            TimeSpan(Int32, Int32, Int32, Int32)  
            public TimeSpan(int days,int hours,int minutes,int seconds)  

            TimeSpan(Int32, Int32, Int32, Int32, Int32)  
            public TimeSpan(int days,int hours,int minutes,int seconds,int milliseconds)  

            TimeSpan(Int64)  
            public TimeSpan(long ticks)  

        */
        public TimeSpan Validaty
        {
            get;
            set;
        }
        public string RefreshToken
        {
            get;
            set;
        }
        public Guid Id
        {
            get;
            set;
        }
        public string EmailId
        {
            get;
            set;
        }
        public Guid GuidId
        {
            get;
            set;
        }
        public DateTime ExpiredTime
        {
            get;
            set;
        }= DateTime.Now;
    }
}
