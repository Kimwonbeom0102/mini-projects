using PracticeExercise4;

namespace PracticeExercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 타임아웃 속성이 있을 수 있다
            // (예: 연결을 일정 시간 내에 열 수 없다면 예외가 발생한다)

            DbConnection Conn = new SqlConnection("Server=myServer;Database=myDb;");
            TimeSpan timeout = TimeSpan.FromSeconds(10);
            Console.WriteLine($"데이터 베이스를 연결하시겠습니까? (y/n)?  {timeout.TotalSeconds}초 안에 눌러주세요");

            // 이 부분에서 시간체크를 해야되는데 if 구문으로 하면 timeout은 int로 계산이 불가능하다네 ?
            

            string s1 = Console.ReadLine();
            if(s1 == "y")
            {
                Console.WriteLine("데이터 베이스를 연결합니다. \n도중에 중단하려면 y키를 누르세요 \n");
                string s2 = Console.ReadLine();
                if (s2 == "y")
                {
                    Console.WriteLine("연결을 종료합니다.");
                    Conn.Close();
                    return;
                }

                Conn.Open();

                Console.WriteLine("연결이 완료되었습니다. 연결을 닫으시려면 아무 키나 누르세요.\n");
                
                Console.ReadKey();
                Console.WriteLine();
                Conn.Close();

                Console.WriteLine("창을 끄시려면 아무키나 눌러주세요\n");
                Console.ReadKey();
            }
            else if(s1 == "n")
            {
                Conn.Close();

                Console.WriteLine("창을 끄시려면 아무키나 누르세요");
                Console.ReadKey();
            }
            Console.WriteLine(TimeSpan.FromSeconds(10));

            // 데이터 베이스를 연결하시려면 y/n? + Timeout 실행 
            // Timeout 시간 초과시 예외발생 
            // y창 누르면 sqlConn.Open()
            // n 창 누르면 exit sqlConn.Close() 실행
        }
    }
}
