namespace ChessBoard.Tests;

[TestClass]
public class ChessBoardTest
{
    /* 
        Test the following moves for a White Knight with a starting position of x=2 and y=1:
            x=1,y=3,expected=true
            x=4,y=2,expected=true
            x=4,y=3,expected=false

        Test the following moves for a Black Knight with a starting position of x=7 and y=8:
            x=6,y=6,expected=true
            x=5,y=7,expected=true
            x=8,y=8,expected=false        
    */
    [DataTestMethod]
    [DataRow()]
    public void CanMove_Knight(int startX, int startY, int x, int y, bool isWhite, bool expected)
    {
        // Assert that the boolean value returned from the CanMove method equals the expected boolean value
    }

    /* 
        Test the following moves for a White Bishop with a starting position of x=3 and y=6:
            x=0,y=3,expected=true
            x=4,y=5,expected=true
            x=4,y=3,expected=false

        Test the following moves for a Black Bishop with a starting position of x=6 and y=3:
            x=6,y=6,expected=false
            x=4,y=1,expected=true
            x=2,y=0,expected=false        
    */
    [DataTestMethod]
    [DataRow()]
    public void CanMove_Bishop(int startX, int startY, int x, int y, bool isWhite, bool expected)
    {
        // Assert that the boolean value returned from the CanMove method equals the expected boolean value
    }
}