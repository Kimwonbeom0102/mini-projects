using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercise4
{
    // DbConnection 기반 클래스 (부모클래스)
    // 두가지 속성을 가질 것
    // 생성자를 생성해서 속성의 문자열을 전달받도록하고
    // null 로 예외발생
    // 2가지 메서드가 있지만 추상적임(자식클래스에서 확장)
    // 해당 부모클래스에서 메서드는 추상메서드로 선언 
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            this.ConnectionString = connectionString;

            if (connectionString == null || string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString), "문자열이 null 이거나 비어있습니다.");

            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException(nameof(connectionString), "문자열이 null이거나 비어 있습니다.");

            //throw new ArgumentNullException("빈 문자열입니다.");
            
            Timeout = TimeSpan.FromSeconds(10);

        }

        public abstract void Open(); // 여는 메서드 

        public abstract void Close(); // 닫는메서드 
    }

    // 상속받는 클래스 구현 
    // 자식 클래스는 생성했는데 속성은 따라오지만 생성자는 어떻게 해야하지 ?
    //
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }
        
        public override void Open()
        {
            Console.WriteLine("SQL 데이터베이스 연결을 열었습니다." + ConnectionString);
        }

        public override void Close()
        {
            Console.WriteLine("SQL 데이터베이스 연결을 닫았습니다.");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void Open()
        {
            Console.WriteLine("Oracle 데이터베이스를 열었습니다." + ConnectionString);
        }
        public override void Close()
        {
            Console.WriteLine("Oracle 데이터베이스를 닫았습니다.");
        }
    }

    
}


