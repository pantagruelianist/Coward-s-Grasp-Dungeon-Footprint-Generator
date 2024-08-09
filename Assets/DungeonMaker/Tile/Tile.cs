using UnityEngine;

public class Tile : MonoBehaviour
{
    //cardinal neighbors..
    public Tile neighborLeft;
    public Tile neighborRight;
    public Tile neighborUp;
    public Tile neighborDown;

    //ordinal neighbors... 
    public Tile topLeft;
    public Tile topRight;
    public Tile bottomLeft;
    public Tile bottomRight;

    //axed a lot of stuff in here from my original tile class, this exists really to act as a new base. The most clever way to do this imo 
    //would be storing all of the directions in a gameobject array and just having a nice unity interface that automagically returns the dir names on the 
    //inspector... 
    public Vector2Int position;  //store a position... 




    //getset group for neighbors.. 
    #region GetSets
    public void SetNeighbors(Tile left, Tile right, Tile up, Tile down,
                             Tile tl, Tile tr, Tile bl, Tile br)
    {
        neighborLeft = left;
        neighborRight = right;
        neighborUp = up;
        neighborDown = down;
        topLeft = tl;
        topRight = tr;
        bottomLeft = bl;
        bottomRight = br;
    }
    public Tile[] GetNeighbors()
    {
        return new Tile[] { neighborLeft, neighborRight, neighborUp, neighborDown, topLeft, topRight, bottomLeft, bottomRight };
    }
    #endregion GetSets

}



