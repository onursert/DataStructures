public class DijkstraSP {

    public int INFINITY = 1000;

    public void Distance(int N, int[][] cost, int[] D) {

        int w, v, min;
        boolean visited[] = new boolean[N];
        D[0] = 0;

        for (v = 1; v < N; v++) {
            visited[v] = false;
            D[v] = cost[0][v];
        }

        for (int i = 1; i < N; ++i) {
            min = INFINITY;
            for (w = 1; w < N; w++) {
                if (!visited[w]) {
                    if (D[w] < min) {
                        v = w;
                        min = D[w];
                    }
                }
            }

            visited[v] = true;
            for (w = 1; w < N; w++) {
                if (!visited[w]) {
                    if (min + cost[v][w] < D[w]) {
                        D[w] = min + cost[v][w];
                    }
                }
            }
        }
    }
}