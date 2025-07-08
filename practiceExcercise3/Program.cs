namespace practiceExcercise3
{
    internal class Program
    {
        internal void Main(string[] args)
        {
            while (true)
            {
                var post = new Post("Excercise ", "Intiallizing on Constructors");

                Console.WriteLine(post.Title);  // 읽기, 쓰기 가능 
                Console.WriteLine($"{post.Description} \n");  // 읽기만 가능 
                post.Title = "Test - Change Title";
                //stackOverflow.Description = "Try to change properties"; // 쓰기 실패
                Console.WriteLine(post.Title); // 변경된 Title

                Console.WriteLine("Choice Vote (up/down)");

                while (true)
                {
                    string input = Console.ReadLine();

                    if (input == "up")
                    {
                        post.Upvote();
                    }
                    else if (input == "down")
                    {
                        post.Downvote();
                    }
                    else if (input != "up" && input != "down")
                        break;
                }
                Console.WriteLine($"Total VoteCount : {post.VoteCount}"); // Count 출력

                Console.WriteLine("Try again ? (y/n)");

                string s = Console.ReadLine();
                if (s != "y")
                    break;

            }
        }
    }
}
