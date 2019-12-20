namespace ConsoleApp1
{
    /// <summary>
    /// Тип подключения(enum, WIFI, 2G, 3G, 4G, ...)
    /// </summary>
    public enum ConnectionType
    {
        Unknown = 0,
        Wifi = 1,
        CellularData2G = 2,
        CellularData3G = 3,
        CellularData4G = 4
    }
}
