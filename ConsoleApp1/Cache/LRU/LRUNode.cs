﻿namespace ConsoleApp1.LRU
{
    class LRUNode
    {
        public int Key { get; set; }
        public int Value { get; set; }
        public LRUNode Previous { get; set; }
        public LRUNode Next { get; set; }
        public LRUNode() { }
        public LRUNode(int k, int v)
        {
            this.Key = k;
            this.Value = v;
        }
    }
}
