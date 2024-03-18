using Microsoft.Extensions.Logging;
using NLog.Extensions.Logging;

class Program{
    static void Main(){
        ILoggerFactory loggerFactory = LoggerFactory.Create(log => {
            {
                log.SetMinimumLevel(LogLevel.Information);
                log.AddNLog("nlog.config");
            }
        });
        ILogger<GameController> logger = loggerFactory.CreateLogger<GameController>();
    }
}

class GameController{
    private ILogger<GameController>? _log;
    IPlayer _player;
    IBoard _board;

    public GameController(IPlayer player, IBoard board, ILogger<GameController>? logger = null){ // pakai ? biar kalau tidak dipakai bisa null
        this._player = player;
        this._board = board;
        _log = logger;
    }

    public bool AddCards(IPlayer player, params ICard[] cards){
        if(player == null){
            _log?.LogWarning("player is null"); //pake ? buat kalau null (ngga ada) nanti ngga di jalankan
        }
        return true;
    }
}

public interface IPlayer{}
public interface IBoard{}
public interface ICard{}