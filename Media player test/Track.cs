using System;

namespace Media_player_test
{
    
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }

    
    public class Track : IPlayable
    {
        
        public string Name { get; set; }
        public string Path { get; set; }
        public double Duration { get; set; }

        
        public Track(string name, string path, double duration = 0)
        {
            Name = name;
            Path = path;
            Duration = duration;
        }

     
        public void Play()
        {
            Console.WriteLine($"Възпроизвеждане на: {Name}");
        }

        public void Pause()
        {
            Console.WriteLine($"Пауза на: {Name}");
        }

        public void Stop()
        {
            Console.WriteLine($"Спиране на: {Name}");
        }

        public override string ToString()
        {
            return $"{Name} ({Duration} sec.)";
        }
    }
}