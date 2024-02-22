class MonopolyGame {
	IPlayer[] players;
	public void AddPlayer(IPlayer p) {
		//...
		//players + p
	}
}
class MobileLegendGame {
	IOnlinePlayer[] onlinePlayers;
	public void AddPlayer(IOnlinePlayer p) {
		//...
		//onlinePlayers + p
	}
	public string CheckUsername(IOnlinePlayer p) {
		//...
		return p.UserName;
	}
}
public interface IPlayer {
	public int ID {get;set;}
	public string Name {get;set;}
}
public interface IOnlinePlayer : IPlayer {
	public string UserName {get;set;}
	public string Email {get;set;}
}
class Player : IPlayer {
	public int ID {get;set;}
	public string Name {get;set;}
}
class OnlinePlayer : IOnlinePlayer {
	public int ID {get;set;}
	public string Name {get;set;}
	public string UserName {get;set;}
	public string Email {get;set;}
}
class PUBGPlayer : IOnlinePlayer {
	public int ID {get;set;}
	public string Name {get;set;}
	public string UserName {get;set;}
	public string Email {get;set;}
	public string Rank {get;set;}
}