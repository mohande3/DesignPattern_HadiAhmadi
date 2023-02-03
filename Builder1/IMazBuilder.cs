namespace Builder1
{
    internal interface IMazBuilder
    {
        void AddRoom(int index);
        void AddDoor(int from,int to);
        Maz Build();
    }

    internal class StandardMazBuilder : IMazBuilder
    {
        public void AddDoor(int from, int to)
        {
            throw new NotImplementedException();
        }

        public void AddRoom(int index)
        {
            throw new NotImplementedException();
        }

        public Maz Build()
        {
            throw new NotImplementedException();
        }
    }

    internal class CountingMazBuilder : IMazBuilder
    {
        public void AddDoor(int from, int to)
        {
            throw new NotImplementedException();
        }

        public void AddRoom(int index)
        {
            throw new NotImplementedException();
        }

        public Maz Build()
        {
            throw new NotImplementedException();
        }
    }
}
