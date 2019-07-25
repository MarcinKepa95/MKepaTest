using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stopwatch.Model
{
    class StopWatchModel
    {
        private DateTime? _Started;

        private TimeSpan? _PreviousElapsedTime;

        public TimeSpan? LapTime { get; private set; }
        public bool running
        {
            get { return _Started.HasValue; }
        }
        private TimeSpan CalculateTimeElapsedSinceStarted()
        {
            return DateTime.Now - _Started.Value;
        }
        public TimeSpan? Elapsed
        {
            get
            {
                if (_Started.HasValue)
                    if (_PreviousElapsedTime.HasValue)
                        return CalculateTimeElapsedSinceStarted() + _PreviousElapsedTime;
                    else
                        return CalculateTimeElapsedSinceStarted();
                else return _PreviousElapsedTime;
            }
        }
        public void Start()
        {
            _Started = DateTime.Now;
            if (!_PreviousElapsedTime.HasValue)
                _PreviousElapsedTime = new TimeSpan(0);
        }

        public void Stop()
        {
            if (_Started.HasValue)
                _PreviousElapsedTime += DateTime.Now - _Started.Value;
            _Started = null;
        }

        public void Reset()
        {
            _Started = null;
            _PreviousElapsedTime = null;
            LapTime = null;
        }

        public void Lap()
        {
            LapTime = Elapsed;
            OnLapTimeUpdated(LapTime);
        }

        public event EventHandler<LapEventArgs> LapTimeUpdated;

        private void OnLapTimeUpdated(TimeSpan? lapTime)
        {
            LapTimeUpdated.Invoke(this, new LapEventArgs(LapTime));
        }

        public StopWatchModel()
        {
            Reset();
        }

    }
}
