namespace Dastan
{
  class Piece
  {
    protected string TypeOfPiece, Symbol;
    protected int PointsIfCaptured;
    protected Player BelongsTo;

    public Piece(string T, Player B, int P, string S)
    {
      TypeOfPiece = T;
      BelongsTo = B;
      PointsIfCaptured = P;
      Symbol = S;
    }

    public string GetSymbol()
    {
      return Symbol;
    }

    public string GetTypeOfPiece()
    {
      return TypeOfPiece;
    }

    public Player GetBelongsTo()
    {
      return BelongsTo;
    }

    public int GetPointsIfCaptured()
    {
      return PointsIfCaptured;
    }
  }
}