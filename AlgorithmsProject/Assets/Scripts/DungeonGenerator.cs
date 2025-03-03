using UnityEngine;
using System.Collections.Generic;

public class DungeonGenerator : MonoBehaviour
{

    [Header("Dungeon Size")]
    [SerializeField] private int DungeonWidth;
    [SerializeField] private int DungeonLength;

    [Header("Dungeon Rooms")]
    [SerializeField] private int RoomLength;
    [SerializeField] private int RoomWidth;

    List<RectInt> rooms;


    void Start()
    {
        rooms = new List<RectInt>();
        rooms.Add(new RectInt(0, 0, DungeonWidth, DungeonLength));

        CreateRooms();

    }
    private void Update()
    {
        foreach (RectInt room in rooms) AlgorithmsUtils.DebugRectInt(room, Color.yellow);
    }

    private void CreateRooms()
    {
        for (int i = 0; i < 10; i++)
        {
            for (int k = rooms.Count - 1; k >= 0; k--)
            {
                SplitRoomVertically(rooms[k]);
            }
        }
    }

    private void SplitRoomVertically(RectInt room)
    {
        int splitX = room.x + room.width / 2;

        RectInt roomLeft = new RectInt(0, 0, RoomWidth / 2, RoomLength);
        RectInt roomRight = new RectInt(0 + RoomWidth / 2, 0, RoomWidth / 2, RoomLength);

        rooms.Add(roomLeft);
        rooms.Add(roomRight);
    }
}
