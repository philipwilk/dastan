namespace Dastan
{
  class Player
  {
    private string Name;
    private int Direction, Score;
    private MoveOptionQueue Queue = new MoveOptionQueue();
    private bool WafrAwarded;

    public Player(string N, int D)
    {
      Score = 100;
      Name = N;
      Direction = D;
      WafrAwarded = false;
    }

    public bool SameAs(Player APlayer)
    {
      if (APlayer == null)
      {
        return false;
      }
      else if (APlayer.GetName() == Name)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public string GetPlayerStateAsString()
    {
      return Name + Environment.NewLine + "Score: " + Score.ToString() + Environment.NewLine + "Move option queue: " + Queue.GetQueueAsString() + Environment.NewLine;
    }

    public void AddToMoveOptionQueue(MoveOption NewMoveOption)
    {
      Queue.Add(NewMoveOption);
    }

    public void UpdateQueueAfterMove(int Position)
    {
      Queue.MoveItemToBack(Position - 1);
    }

    public void UpdateMoveOptionQueueWithOffer(int Position, MoveOption NewMoveOption)
    {
      Queue.Replace(Position, NewMoveOption);
    }

    public int GetScore()
    {
      return Score;
    }

    public string GetName()
    {
      return Name;
    }

    public int GetDirection()
    {
      return Direction;
    }

    public void ChangeScore(int Amount)
    {
      Score += Amount;
    }

    public bool CheckPlayerMove(int Pos, int StartSquareReference, int FinishSquareReference)
    {
      MoveOption Temp = Queue.GetMoveOptionInPosition(Pos - 1);
      return Temp.CheckIfThereIsAMoveToSquare(StartSquareReference, FinishSquareReference);
    }

    public bool getWafrAwarded()
    {
      return WafrAwarded;
    }

    public void setWafrAwarded(bool b)
    {
      WafrAwarded = b;
    }
  }
}