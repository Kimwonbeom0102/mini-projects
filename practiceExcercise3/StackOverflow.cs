using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceExcercise3
{
    public class Post
    {
        private int _voteCount;
        public string Title {  get; set; }
        public string Description {  get; private set; }
        public DateTime CreatedDateTime { get; private set; }

        public Post(string title, string description) // 객체 생성할 때 호출됨. 매개변수를 인자 받을 수 있음
        {
            _voteCount = 0;
            Title = title;
            Description = description; 
            //Description = "Hi"; // 생성자 내부에서 변경가능
            CreatedDateTime = DateTime.Now;
        }

        public void Upvote()
        {
            _voteCount++;
        }

        public void Downvote()
        {
            _voteCount--;
        }

        public int VoteCount 
        {
            get
            {
                return _voteCount;
            }
        }
    }
}
