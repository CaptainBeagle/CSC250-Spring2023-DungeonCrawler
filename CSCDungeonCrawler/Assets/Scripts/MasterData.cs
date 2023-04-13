using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterData
{
    public static int count = 0;
    public static string whereDidIComeFrom = "?";
    public static bool isExiting = true;
    public static bool isDungeonSetup = false;
    public static Dungeon cs = null;
    public static Player p = null;
    public static string id;
    public static bool nON;
    public static bool sON;
    public static bool eON;
    public static bool wON;

    public static void setupDungeon()
    {
        if(MasterData.isDungeonSetup == false)
        {
            MasterData.cs = new Dungeon(100);
            MasterData.cs.populateCSDepartment();

            MasterData.p = new Player("Mike");
            MasterData.cs.addPlayer(p);
            MasterData.id = "e";
            MasterData.isDungeonSetup = true;
        }
    }
}
