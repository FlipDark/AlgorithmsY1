using UnityEngine;
using System.Collections.Generic;

public class DungeonGenerator : MonoBehaviour
{

    [Header("Dungeon Size")]
    [SerializeField] private int DungeonWidth = 100;
    [SerializeField] private int DungeonLength = 50;

    [Header("Dungeon Rooms")]
    [SerializeField] private int RoomLength = 100;
    [SerializeField] private int RoomWidth = 50;

    List<RectInt> rooms;


    void Start()
    {
        rooms = new List<RectInt>();
        rooms.Add(new RectInt(0, 0, DungeonWidth, DungeonLength));

    }

    private void CreateRooms()
    {
        for(int i = 0; i < 10; i++)
        {
            foreach (RectInt room in rooms)
            {
                // randomly splitting yes or no?
                if(Random.Range(1,2) == 1)
                {
                    if(Random.Range(1,2) == 1)
                    {
                        SplitRoomVertically(room);
                        
                    }
                }

                // if yes randomly splitting over x or y?

                // remove original room if it was split
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        foreach (RectInt room in rooms)
        {
            AlgorithmsUtils.DebugRectInt(room, Color.red);
        }
    }

    private void SplitRoomVertically(RectInt room)
    {
        RectInt roomLeft = new RectInt(0, 0, RoomWidth / 2, RoomLength);
        RectInt roomRight = new RectInt(0 + RoomWidth / 2, 0, RoomWidth / 2, RoomLength);
        
    }
}
