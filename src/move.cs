namespace Dastan
{
  class Move
  {
    protected int RowChange, ColumnChange;

    public Move(int R, int C)
    {
      RowChange = R;
      ColumnChange = C;
    }

    public int GetRowChange()
    {
      return RowChange;
    }

    public int GetColumnChange()
    {
      return ColumnChange;
    }
  }
}