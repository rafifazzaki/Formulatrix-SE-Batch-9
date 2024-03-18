class GameController : IDisposable
{
    public List<int> totalPlayers;
    public List<object> allPlayers;
    public ExternalResource externalResource;
    private bool disposedValue; //state for save if Dispose() already called

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue) //if dispose already called or not
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                //Objects/Instance
                totalPlayers = null;
                allPlayers = null;
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            // External resource object that do not have Dispose()
            externalResource = null;
            disposedValue = true;
        }
    }

    // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
    //Safety net
    ~GameController()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: false);
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

public class ExternalResource
{
}