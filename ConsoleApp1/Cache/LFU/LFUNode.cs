namespace ConsoleApp1.LFU
{
    class LFUNode
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public int Frequency { get; set; }
        public LFUNode Previous { get; set; }
        public LFUNode Next { get; set; }
        public LFUNode(int key, int value)
        {
            this.Key = key;
            this.Value = value;
            Frequency = 1;
        }
        public LFUNode() { }
    }
}
