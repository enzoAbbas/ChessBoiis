namespace Schach_Ferien;

public abstract class Piece
{
    private int xCoord;
    private int yCoord;

    protected Piece(int xCoord, int yCoord)
    {
        this.xCoord = xCoord;
        this.yCoord = yCoord;
    }

    public void SetXCoord(int x)
    {
        this.xCoord = xCoord;
    }

    public void SetYCoord(int y)
    {
        this.yCoord = yCoord;
    }

    public int GetXCoord()
    {
        return xCoord;
    }

    public int GetYCoord()
    {
        return yCoord;
    }

    public int[] GetCoords()
    {
        int[] coords = new int[]{};
        
        coords[0] = this.xCoord;
        coords[1] = this.yCoord;
        
        return coords;
    }
}