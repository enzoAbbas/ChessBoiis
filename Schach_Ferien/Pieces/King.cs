namespace Schach_Ferien;

public class King : Piece
{
    private bool active = true;

    public King(int xCoord, int yCoord):base(xCoord, yCoord)
    {
        
    }
    public void ChangeState()
    {
        this.active = false;
    }
}