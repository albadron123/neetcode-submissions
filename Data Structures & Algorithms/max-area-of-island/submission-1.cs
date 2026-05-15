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
    public int MaxAreaOfIsland(int[][] grid) {
        int sizeX = grid.Length;
        int sizeY = grid[0].Length;
        int maxArea = 0;
        for(int x = 0; x < sizeX; ++x)
        {
            for(int y = 0; y < sizeY; ++y)
            {
                if(grid[x][y] != 1) continue;
                int area = 0;
                Queue<Coord> q = new();
                q.Enqueue(new Coord(x,y));
                grid[x][y] = 2;
                                
                while(q.Count > 0)
                {
                    Coord coords = q.Dequeue();
                    ++area;
                    if(coords.x+1 < sizeX && grid[coords.x+1][coords.y] == 1)
                    {
                        q.Enqueue(new Coord(coords.x+1,coords.y));
                        grid[coords.x+1][coords.y] = 2;
                    }
                    if(coords.x-1 >= 0 && grid[coords.x-1][coords.y] == 1)
                    {
                        q.Enqueue(new Coord(coords.x-1,coords.y));
                        grid[coords.x-1][coords.y] = 2;
                    }
                    if(coords.y+1 < sizeY && grid[coords.x][coords.y+1] == 1)
                    {
                        q.Enqueue(new Coord(coords.x,coords.y+1));
                        grid[coords.x][coords.y+1] = 2;
                    }
                    if(coords.y-1 >= 0 && grid[coords.x][coords.y-1] == 1)
                    {
                        q.Enqueue(new Coord(coords.x,coords.y-1));
                        grid[coords.x][coords.y-1] = 2;
                    }
                }
                maxArea = area > maxArea ? area : maxArea;
            }
        }
        return maxArea;
    }
}
