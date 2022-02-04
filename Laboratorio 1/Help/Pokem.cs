using System;

namespace Lab_1.Help
{
    public class Pokem
    {
        public string Gene { get; internal set; }
        public string Name { get; internal set; }
        public string Gender { get; internal set; }
        public string Type { get; internal set; }
        public int Id { get; set; }

        internal static object Save(Pokem pokem)
        {
            throw new NotImplementedException();
        }
    }
}