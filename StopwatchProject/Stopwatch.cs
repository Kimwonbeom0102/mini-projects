using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceExcercise
{
    public class Stopwatch
    {
        private DateTime _startTime;  // 시작시간 
        private DateTime _endTime;    // 끝 시간 
        private bool _isRunning;      // 작동중인지 아닌지 < 작동중이면 다시 작동못하도록 bool타입 

        public void Start()
        {
            if (_isRunning)  // 작동중이면 
                throw new InvalidOperationException("Stopwatch is working");  // 이미 작동중으로 예외처리 

            _startTime = DateTime.Now;
            _isRunning = true;  // 작동중 
        }

        public void Stop()
        {
            if (!_isRunning)  // 작동중이 아니면 
                throw new InvalidOperationException("Stopwatch doesn't work yet");  // 아직 작동하지 않았음 
            _endTime = DateTime.Now;
            _isRunning = false;
        }

        public TimeSpan GetDuration()
        {
            return _endTime - _startTime;  // 시간을 빼주고 return
        }
    }
}
