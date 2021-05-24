namespace Pitwall_corelib.Connections
{
    public interface IConnection
    {
        void Connect();
        void Disconnect();
        bool IsAlive();
        void Send();
    }
}