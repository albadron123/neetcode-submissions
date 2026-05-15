public struct Coord
{
    public int x;
    public int y;

    public Coord(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
}

public class Solution {

    

    public int NumIslands(char[][] grid) {
        int sizeX = grid.Length;
        int sizeY = grid[0].Length;
        int counter = 0;
        for(int x = 0; x < sizeX; ++x)
        {
            for(int y = 0; y < sizeY; ++y)
            {
                if(grid[x][y] != '1') continue;
                ++counter;
                Queue<Coord> q = new();
                q.Enqueue(new Coord(x,y));
                while(q.Count > 0)
                {
                    Coord coords = q.Dequeue();
                    grid[coords.x][coords.y] = '2';
                    if(coords.x+1 < sizeX && grid[coords.x+1][coords.y] == '1')
                    {
                        q.Enqueue(new Coord(coords.x+1,coords.y));
                    }
                    if(coords.x-1 >= 0 && grid[coords.x-1][coords.y] == '1')
                    {
                        q.Enqueue(new Coord(coords.x-1,coords.y));
                    }
                    if(coords.y+1 < sizeY && grid[coords.x][coords.y+1] == '1')
                    {
                        q.Enqueue(new Coord(coords.x,coords.y+1));
                    }
                    if(coords.y-1 >= 0 && grid[coords.x][coords.y-1] == '1')
                    {
                        q.Enqueue(new Coord(coords.x,coords.y-1));
                    }
                }
                
            }
        }
        return counter;
    }
}
