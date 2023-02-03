namespace Builder1
{
    internal class Director
    {
        private readonly IMazBuilder _mazBuilder;

        public Director(IMazBuilder mazBuilder)
        {
            _mazBuilder = mazBuilder;
        }

        public void EasyMaz()
        {
            _mazBuilder.AddRoom(1);
            _mazBuilder.AddRoom(2);
            _mazBuilder.AddRoom(3);
            _mazBuilder.AddDoor(1, 2);
        }
        public void DifficultMaz()
        {
            _mazBuilder.AddRoom(1);
            _mazBuilder.AddRoom(2);
            _mazBuilder.AddDoor(1, 2);
            _mazBuilder.AddRoom(300);
        }
    }
}
