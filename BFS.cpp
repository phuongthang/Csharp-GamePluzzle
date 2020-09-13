#include <iostream>
#include <fstream>
#include <queue>
using namespace std;
#define MAX 100
struct Graph{
	int n;
	int matrix[MAX][MAX];
	bool visited[MAX];
};

void Init(Graph &g)
{
    ifstream file("matrix.txt");
    file >> g.n;
    for(int i = 1; i <= g.n; i++)
    {
        for(int j = 1; j <= g.n; j++)
        {
            file >> g.matrix[i][j];
        }
        g.visited[i] = false;
    }
}

void BFS(Graph &g,int u)
{
    cout << "BFS(" << u << "): ";
    queue<int> Q;
    Q.push(u);
    g.visited[u] = true;
    while(!Q.empty())
    {
        int s = Q.front();
        cout << s << " ";
        Q.pop();
        for(int t = 1; t <= g.n; t++)
        {
            if(g.visited[t] == false && g.matrix[s][t] == 1)
            {
                Q.push(t);
                g.visited[t] = true;
            }
        }
    }
}

int main()
{
	Graph g;
    int u;
    Init(g);
    cout << "Dinh xuat phat: ";
    cin >> u;
    BFS(g,u);
}
