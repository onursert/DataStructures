import java.util.Iterator;
import java.util.LinkedList;

public class Graph
{
    int vertexCount = 0;
    LinkedList<Integer> adjacency[];
    public Graph(int vertexCount)
    {
        this.vertexCount = vertexCount;
        adjacency = new LinkedList[vertexCount];
        for(int i = 0; i < vertexCount ; i++){
            adjacency[i] = new LinkedList<>();
        }
    }

    public void addEdge(int src, int dest)
    {
        adjacency[src].add(dest);
        adjacency[dest].add(src);
    }

    public void DFS(int s)
    {
        boolean visited[] = new boolean[vertexCount];
        DFSUtil(s, visited);
        System.out.println();
    }
    public void DFSUtil(int s,boolean visited[])
    {
        visited[s] = true;
        System.out.print(s+" ");

        Iterator<Integer> i = adjacency[s].listIterator();
        while (i.hasNext())
        {
            int n = i.next();
            if (!visited[n])
            {
                DFSUtil(n, visited);
            }
        }
    }

    public void BFS(int s)
    {
        boolean visited[] = new boolean[vertexCount];
        LinkedList<Integer> queue = new LinkedList<Integer>();

        visited[s]=true;
        queue.add(s);

        while (queue.size() != 0)
        {
            s = queue.poll();
            System.out.print(s+" ");

            Iterator<Integer> i = adjacency[s].listIterator();
            while (i.hasNext())
            {
                int n = i.next();
                if (!visited[n])
                {
                    visited[n] = true;
                    queue.add(n);
                }
            }
        }
        System.out.println();
    }

    public void Print()
    {
        for(int v = 0; v < vertexCount; v++)
        {
            for(int i = 0; i < adjacency[v].size(); i++){
                System.out.print(adjacency[v].get(i) + " -> ");
            }
            System.out.println();
        }
    }
}
