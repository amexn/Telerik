﻿namespace _01.KnapsackProblem
{
    public class Item
    {
        public Item(string name, int weight, int cost)
        {
            this.Name = name;
            this.Weight = weight;
            this.Cost = cost;
        }

        public string Name { get; set; }

        public int Weight { get; set; }

        public int Cost { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - weight: {1}, cost: {2}", this.Name, this.Weight, this.Cost);
        }
    }
}
