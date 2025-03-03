using System;
using System.Collections;
using System.Collections.Generic;

[Serializable]
public class NetworkingPlayer
{
    public string gameName;//to be set from editor
    public string playerName;
    public string playerId;
    public string playerIdToBeSentorReceived;
    public string imageURL;
    public string RoomID;
    public int score;
    public bool isGameStarted;
    public bool finishedPlaying;
    public bool iWon = false;
    public int playerDisconnectionCounter = 3;
    public bool isConnected = false;
    public bool isBot = false;
    public float[] incrementFactor;
    public string player_id;
    public string player_id1;
    public string room_id;
    public string game_mode;
    public WinningDetails winning_details;
    public string wallet_amt; //change it to game_fee
    public string game_status;
    public string game_id;
    public string battle_tournament_id;
}

[Serializable]
public class WalletInfo
{
    public string status;
    public string code;
    public string message;
    public WalletInfoData data;
}

[Serializable]
public class WalletInfoData
{
    public string cash_balance;
    public string winning_balance;
    public string bonus_amount;
    public string coin_balance;
}

[Serializable]
public class WallUpdate
{
    public string user_id;
    public string game_id;
    public string amount;
    public string type;
}

[Serializable]
public class SendData
{
    public string user_id;
    public string player_id;
    public string room_id;
    public string game_mode;
    public WinningDetails winning_details;
    public string game_end_time;
    public string wallet_amt; //change it to game_fee
    public string game_status;
    public string game_id;
    public string battle_tournament_id;
    public string id;
}

[Serializable]
public class GetAttempt
{
    public string status;
    public string code;
    public string message;
    public AttemptData data;
}

[Serializable]
public class AttemptData
{
    public string remainAttemp;
}

[Serializable]
public class BotList
{
    public string status;
    public string code;
    public string message;
    public BotListData[] data;
}

[Serializable]
public class BotListData
{
    public string id;
    public string first_name;
    public string last_name;
    public string image;
}

[Serializable]
public class WalletCheckPost
{
    public string game_id;
    public string tournament_battle_id;
    public string type;
}

[Serializable]
public class WalletCheck
{
    public string status;
    public string code;
    public string message;
    public string data;
}