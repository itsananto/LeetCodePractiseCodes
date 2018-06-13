using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    class CanVisitAllRoomsSolution
    {
        bool[] visited;

        public void Travarse(IList<IList<int>> rooms, int roomId)
        {
            visited[roomId] = true;

            foreach (var room in rooms[roomId])
            {
                if (!visited[room])
                {
                    Travarse(rooms, room);
                }
            }
        }
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            visited = new bool[rooms.Count];
            Travarse(rooms, 0);

            return visited.Where(x => x == false).Count() == 0;
        }
    }
}
