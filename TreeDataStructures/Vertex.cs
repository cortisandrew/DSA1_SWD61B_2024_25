namespace TreeDataStructures
{
    public class Vertex
    {
        public object? Value { get; set; }

        public List<Vertex> Children { get; internal set;} = new List<Vertex>();
    }
}